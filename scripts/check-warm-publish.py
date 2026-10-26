#!/usr/bin/env python3
"""Execute cold, changed-graph, fresh-output and removed-PackageReference publish contracts."""
import argparse
import hashlib
import json
from pathlib import Path
import platform
import shutil
import subprocess
import tempfile
import time
from xml.sax.saxutils import escape

REPO = Path(__file__).resolve().parents[1]
TARGETS = REPO / "build/AutoSDK.WarmPublish.targets"
CONTAINER = None


def command(args, cwd, log):
    start = time.monotonic()
    if CONTAINER:
        args = ['docker', 'exec', '--workdir', str(cwd), CONTAINER, *args]
    result = subprocess.run(args, cwd=cwd, text=True, stdout=subprocess.PIPE,
                            stderr=subprocess.STDOUT, timeout=600, check=False)
    log.write_text(result.stdout)
    return result.returncode, result.stdout, round(time.monotonic() - start, 3)


def program(serialize, packaged):
    if packaged:
        setup = 'using WarmSdk; var model = Codec.Read("{\\"Value\\":\\"works\\"}");'
        write = 'if (Codec.Write(model) != "{\\"Value\\":\\"works\\"}") throw new Exception("write");'
        declarations = ""
    else:
        setup = ('using System.Text.Json; using System.Text.Json.Serialization; '
                 'var model = JsonSerializer.Deserialize("{\\"Value\\":\\"works\\"}", Context.Default.Model)!;')
        write = ('if (JsonSerializer.Serialize(model, Context.Default.Model) != '
                 '"{\\"Value\\":\\"works\\"}") throw new Exception("write");')
        declarations = ('public sealed class Model { public string? Value { get; set; } } '
                        '[JsonSerializable(typeof(Model))] internal partial class Context : JsonSerializerContext {}')
    return setup + ' if (model.Value != "works") throw new Exception("read"); ' + (
        write if serialize else '') + ' Console.WriteLine("contract passed"); ' + declarations


def project(packaged, guard, targets):
    return f'''<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup>
<OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework>
<ImplicitUsings>enable</ImplicitUsings><Nullable>enable</Nullable>
<PublishTrimmed>true</PublishTrimmed><TrimMode>full</TrimMode>
<JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
<TreatWarningsAsErrors>true</TreatWarningsAsErrors><ILLinkTreatWarningsAsErrors>true</ILLinkTreatWarningsAsErrors>
</PropertyGroup>
{'<ItemGroup><PackageReference Include="WarmSdk" Version="1.0.0" /></ItemGroup>' if packaged else ''}
{f'<Import Project="{escape(str(targets))}" />' if guard else ''}
</Project>'''


def run_case(root, rid, aot, guard, packaged):
    root.mkdir()
    (root / 'Probe.csproj').write_text(project(packaged, guard, root.parent / TARGETS.name))
    (root / 'NuGet.Config').write_text('''<configuration><packageSources><clear/>
<add key="local" value="../feed"/><add key="nuget.org" value="https://api.nuget.org/v3/index.json"/>
</packageSources><packageSourceMapping><clear/><packageSource key="local"><package pattern="WarmSdk"/></packageSource>
<packageSource key="nuget.org"><package pattern="*"/></packageSource></packageSourceMapping></configuration>''')
    results = []
    stages = ['read', 'write', 'fresh-output'] + (['removed-reference'] if packaged else [])
    for stage in stages:
        if stage == 'removed-reference':
            (root / 'Probe.csproj').write_text(project(False, guard, root.parent / TARGETS.name))
            (root / 'Program.cs').write_text('Console.WriteLine("contract passed");')
        else:
            (root / 'Program.cs').write_text(program(stage != 'read', packaged))
        out = root / ('fresh' if stage == 'fresh-output' else 'publish')
        args = ['dotnet', 'publish', 'Probe.csproj', '-c', 'Release', '-r', rid,
                '--self-contained', 'true', '-o', str(out), '--disable-build-servers']
        if aot:
            args.append('-p:PublishAot=true')
        code, output, seconds = command(args, root, root / f'{stage}-publish.log')
        execution = None
        if code == 0:
            exe = out / ('Probe.exe' if rid.startswith('win-') else 'Probe')
            execution, text, _ = command([str(exe)], root, root / f'{stage}-run.log')
            if execution == 0 and 'contract passed' not in text:
                execution = -1
        deps = out / 'Probe.deps.json'
        manifest = json.loads(deps.read_text()) if deps.exists() else None
        if stage == 'removed-reference' and manifest and any(
                name.startswith('WarmSdk/') for name in manifest.get('libraries', {})):
            execution = -2
        results.append({'stage': stage, 'publishExitCode': code, 'runExitCode': execution,
                        'publishSeconds': seconds,
                        'depsSha256': hashlib.sha256(deps.read_bytes()).hexdigest() if deps.exists() else None,
                        'libraries': sorted(manifest.get('libraries', {})) if manifest else None})
    return {'profile': 'aot' if aot else 'trim', 'guard': guard, 'package': packaged, 'stages': results}


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--output', type=Path, help='New, empty directory for durable logs and results')
    parser.add_argument('--rid', default=('osx' if platform.system() == 'Darwin' else 'linux') +
                        ('-arm64' if platform.machine() in {'arm64', 'aarch64'} else '-x64'))
    parser.add_argument('--aot', action='store_true', help='Also execute all NativeAOT stages')
    parser.add_argument('--container', help='Execute commands inside an existing container; mount repo and output at identical absolute paths')
    args = parser.parse_args()
    global CONTAINER
    CONTAINER = args.container
    root = args.output.resolve() if args.output else Path(tempfile.mkdtemp(prefix='autosdk-warm-publish-'))
    if args.output:
        root.mkdir(parents=True, exist_ok=False)
    shutil.copyfile(TARGETS, root / TARGETS.name)
    print(f'Validation artifacts: {root}', flush=True)
    sdk_code, _, _ = command(['dotnet', '--info'], root, root / 'dotnet-info.txt')
    if sdk_code:
        raise RuntimeError('dotnet --info failed')
    library = root / 'library'
    library.mkdir()
    (library / 'WarmSdk.csproj').write_text('''<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup>
<TargetFramework>net10.0</TargetFramework><ImplicitUsings>enable</ImplicitUsings><Nullable>enable</Nullable>
<Version>1.0.0</Version><JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
</PropertyGroup></Project>''')
    (library / 'Codec.cs').write_text('''using System.Text.Json; using System.Text.Json.Serialization;
namespace WarmSdk;
public sealed class Model { public string? Value { get; set; } }
public static class Codec {
 public static Model Read(string value) => JsonSerializer.Deserialize(value, Context.Default.Model)!;
 public static string Write(Model value) => JsonSerializer.Serialize(value, Context.Default.Model);
}
[JsonSerializable(typeof(Model))] internal partial class Context : JsonSerializerContext {}''')
    code, _, _ = command(['dotnet', 'pack', '-c', 'Release', '-o', str(root / 'feed')], library,
                         root / 'pack.log')
    if code:
        raise RuntimeError(f'Fixture pack failed; see {root / "pack.log"}')
    results = []
    for aot in ([False, True] if args.aot else [False]):
        for guard in [False, True]:
            for packaged in [False, True]:
                name = f'{"aot" if aot else "trim"}-{guard}-{packaged}'
                result = run_case(root / name, args.rid, aot, guard, packaged)
                results.append(result)
                (root / 'results.json').write_text(json.dumps(results, indent=2))
                print(name, [(row['stage'], row['publishExitCode'], row['runExitCode'])
                             for row in result['stages']], flush=True)
    # Baseline failure is retained as evidence, never hidden. Every guarded publish must run.
    return int(any(stage['publishExitCode'] != 0 or
                   (stage['runExitCode'] != 0 and (result['guard'] or result['profile'] == 'aot' or
                                                  stage['stage'] in {'read', 'removed-reference'}))
                   for result in results for stage in result['stages']))


if __name__ == '__main__':
    raise SystemExit(main())
