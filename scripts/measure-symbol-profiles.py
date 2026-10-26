#!/usr/bin/env python3
"""Compare SDK symbols without changing generated sources, runtime roots or compiler budgets."""
import argparse
import hashlib
import json
from pathlib import Path
import shutil
import subprocess
import time
import zipfile

REPO = Path(__file__).resolve().parents[1]
IMAGE = 'mcr.microsoft.com/dotnet/sdk:10.0.402-noble-aot'
PACK_RESULTS = None


def call(args, log, cwd=None):
    started = time.monotonic()
    result = subprocess.run(args, cwd=cwd, stdout=subprocess.PIPE, stderr=subprocess.STDOUT,
                            text=True, timeout=1800, check=False)
    log.write_text(result.stdout)
    return result.returncode, result.stdout, round(time.monotonic() - started, 3)


def container(root, source, memory, package_cache=None):
    return subprocess.check_output(['docker', 'run', '-d', '--rm', '--cpus=2', f'--memory={memory}',
                                    f'--memory-swap={memory}', '-v', f'{root}:{root}',
                                    *(['-v', f'{PACK_RESULTS}:{PACK_RESULTS}:ro'] if PACK_RESULTS else []),
                                    '-v', f'{source}:{source}:ro', '-e', f'NUGET_PACKAGES={package_cache or root / "packages"}',
                                    IMAGE, 'sleep', 'infinity'], text=True).strip()


def execute(cid, cwd, args, log):
    return call(['docker', 'exec', '--workdir', str(cwd), cid, *args], log)


def peak(cid):
    return int(subprocess.check_output(['docker', 'exec', cid, 'cat', '/sys/fs/cgroup/memory.peak'], text=True))


def cpu(cid):
    text = subprocess.check_output(['docker', 'exec', cid, 'cat', '/sys/fs/cgroup/cpu.stat'], text=True)
    return int(dict(line.split() for line in text.splitlines())['usage_usec']) / 1_000_000


def stop(cid):
    subprocess.run(['docker', 'stop', cid], check=True, stdout=subprocess.DEVNULL)


def check_image(folder, publication, label):
    """Run the copied application in an ordinary runtime-deps image without network."""
    import uuid
    tag = 'autosdk-symbol-probe:' + uuid.uuid4().hex
    (folder / 'Dockerfile').write_text('FROM mcr.microsoft.com/dotnet/runtime-deps:10.0.13-noble\n'
        'ARG PUBLISH_DIRECTORY\nCOPY ${PUBLISH_DIRECTORY}/ /app/\nWORKDIR /app\nENTRYPOINT ["./Probe"]\n')
    (folder / '.dockerignore').write_text('*\n!Dockerfile\n!publish/\n!publish/**\n!diagnostic/\n!diagnostic/**\n')
    try:
        code, _, _ = call(['docker', 'build', '--network=none', '-t', tag, '--build-arg',
                          'PUBLISH_DIRECTORY=' + publication, str(folder)], folder / (label + '-image-build.log'))
        if code:
            return {'buildExitCode': code}
        code, text, _ = call(['docker', 'run', '--rm', '--network=none', '--memory=6g', '--memory-swap=6g', tag],
                             folder / (label + '-image-run.log'))
        has_pdb = subprocess.run(['docker', 'run', '--rm', '--network=none', '--entrypoint', 'sh', tag,
                                  '-c', 'test -f /app/AppStoreConnect.pdb'], check=False).returncode == 0
        return {'buildExitCode': 0, 'runExitCode': code, 'sdkPdbPresent': has_pdb,
                'sdkSourceLine': '.g.cs:line ' in text}
    finally:
        subprocess.run(['docker', 'image', 'rm', tag], stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL, check=False)


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--source', required=True, type=Path, help='Clean pinned AppStoreConnect checkout')
    parser.add_argument('--output', required=True, type=Path, help='New results directory')
    parser.add_argument('--docker-images', action='store_true', help='Build and run ordinary and optional diagnostic application images')
    parser.add_argument('--profiles', nargs='+', choices=['embedded', 'portable', 'none'], default=['embedded', 'portable', 'none'])
    parser.add_argument('--pack-results', type=Path, help='Reuse completed immutable source packs; rerun only consumers')
    args = parser.parse_args()
    global PACK_RESULTS
    PACK_RESULTS = args.pack_results.resolve() if args.pack_results else None
    source, root = args.source.resolve(), args.output.resolve()
    if subprocess.check_output(['git', 'status', '--porcelain'], cwd=source, text=True):
        raise RuntimeError('Source checkout must be clean')
    root.mkdir(parents=True, exist_ok=False)
    sha = subprocess.check_output(['git', 'rev-parse', 'HEAD'], cwd=source, text=True).strip()
    project = source / 'src/libs/AppStoreConnect/AppStoreConnect.csproj'
    shutil.copyfile(REPO / 'build/AutoSDK.Symbols.props', root / 'AutoSDK.Symbols.props')
    inspector = root / 'Inspector'
    inspector.mkdir()
    shutil.copyfile(REPO / 'scripts/fixtures/SymbolInspector/Program.cs', inspector / 'Program.cs')
    shutil.copyfile(REPO / 'src/libs/AutoSDK.CLI/Trimming/AssemblyFootprint.cs', inspector / 'AssemblyFootprint.cs')
    (inspector / 'Inspector.csproj').write_text('''<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup>
<OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><ImplicitUsings>enable</ImplicitUsings>
<Nullable>enable</Nullable><TreatWarningsAsErrors>true</TreatWarningsAsErrors>
</PropertyGroup></Project>''')
    setup = container(root, source, '4g')
    try:
        code, _, _ = execute(setup, inspector, ['dotnet', 'build', '-c', 'Release'], root / 'inspector-build.log')
        if code:
            raise RuntimeError('Inspector failed to build')
        execute(setup, root, ['dotnet', '--info'], root / 'dotnet-info.txt')
    finally:
        stop(setup)
    results = {'sourceCommit': sha, 'image': IMAGE, 'cpus': 2, 'sourceMemoryLimitGiB': 16,
               'consumerMemoryLimitGiB': 6, 'profiles': []}
    inspector_dll = inspector / 'bin/Release/net10.0/Inspector.dll'
    for profile in args.profiles:
        folder = root / profile
        folder.mkdir()
        if args.pack_results:
            previous = json.loads((args.pack_results / 'results.json').read_text())
            if previous['sourceCommit'] != sha or previous['image'] != IMAGE:
                raise RuntimeError('Reused source packs must match the source and toolchain')
            original = next(row for row in previous['profiles'] if row['profile'] == profile)
            row = {key: value for key, value in original.items() if key.startswith('pack') or key in
                   {'profile', 'debug', 'nupkgBytes', 'snupkgBytes', 'sdkPdbInMainPackage'}}
            if row['packExitCode']:
                raise RuntimeError('Cannot reuse failed source pack')
            results['profiles'].append(row)
            feed = args.pack_results.resolve() / profile / 'feed'
            symbols = list(feed.glob('*.snupkg'))
        else:
            artifacts, feed = folder / 'artifacts', folder / 'feed'
            properties = [f'-p:AutoSDKSymbolProfile={profile}', '-p:MinVerVersionOverride=1.0.0', '-p:GeneratePackageOnBuild=false',
                          f'-p:CustomBeforeMicrosoftCommonTargets={root}/AutoSDK.Symbols.props']
            restore = container(root, source, '4g')
            try:
                code, _, _ = execute(restore, source, ['dotnet', 'restore', str(project), '--artifacts-path', str(artifacts), *properties], folder / 'restore.log')
                if code:
                    raise RuntimeError(f'{profile} restore failed')
            finally:
                stop(restore)
            pack = container(root, source, '16g')
            try:
                cpu_before = cpu(pack)
                code, _, seconds = execute(pack, source, ['dotnet', 'pack', str(project), '-c', 'Release',
                    '--no-restore', '--disable-build-servers', '--artifacts-path', str(artifacts), '-o', str(feed),
                    '-p:TreatWarningsAsErrors=true', *properties], folder / 'pack.log')
                memory = peak(pack)
                row = {'profile': profile, 'packExitCode': code, 'packSeconds': seconds, 'packPeakBytes': memory, 'packCpuSeconds': round(cpu(pack) - cpu_before, 3)}
                results['profiles'].append(row)
                (root / 'results.json').write_text(json.dumps(results, indent=2))
                if code:
                    print(profile, 'source pack failed', flush=True)
                    continue
                dll = next(artifacts.glob('bin/AppStoreConnect/release*/AppStoreConnect.dll'))
                pdb = dll.with_suffix('.pdb')
                inspect_args = ['dotnet', str(inspector_dll), str(dll)] + ([str(pdb)] if pdb.exists() else [])
                _, text, _ = execute(pack, root, inspect_args, folder / 'assembly.json')
                row['debug'] = json.loads(text)
                package = next(feed.glob('*.nupkg'))
                row['nupkgBytes'] = package.stat().st_size
                symbols = list(feed.glob('*.snupkg'))
                row['snupkgBytes'] = sum(p.stat().st_size for p in symbols)
                with zipfile.ZipFile(package) as archive:
                    row['sdkPdbInMainPackage'] = any(name.endswith('/AppStoreConnect.pdb') for name in archive.namelist())
            finally:
                stop(pack)
        package = next(feed.glob('*.nupkg'))
        row['packageSha256'] = hashlib.sha256(package.read_bytes()).hexdigest()
        row['symbolPackageSha256'] = [hashlib.sha256(path.read_bytes()).hexdigest() for path in symbols]
        with zipfile.ZipFile(package) as archive:
            member = next(name for name in archive.namelist() if name == 'lib/net10.0/AppStoreConnect.dll')
            row['sdkDllSha256'] = hashlib.sha256(archive.read(member)).hexdigest()
        if not args.pack_results and row['sdkDllSha256'] != hashlib.sha256(dll.read_bytes()).hexdigest():
            raise RuntimeError('NuGet DLL differs from the inspected source-build DLL')
        consumer = folder / 'consumer'
        consumer.mkdir()
        (consumer / 'Probe.csproj').write_text('''<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup>
<OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><ImplicitUsings>enable</ImplicitUsings>
<Nullable>enable</Nullable><PublishTrimmed>true</PublishTrimmed><TrimMode>full</TrimMode>
<JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
<TreatWarningsAsErrors>true</TreatWarningsAsErrors><ILLinkTreatWarningsAsErrors>true</ILLinkTreatWarningsAsErrors>
</PropertyGroup><ItemGroup><PackageReference Include="AppStoreConnect" Version="1.0.0"/></ItemGroup></Project>''')
        (consumer / 'Program.cs').write_text('''using AppStoreConnect; using System.Text.Json;
var model = BetaTesterInvitationResponse.FromJson("{\\"data\\":{\\"type\\":\\"betaTesterInvitations\\",\\"id\\":\\"offline\\"},\\"links\\":{\\"self\\":\\"https://example.test/item\\"}}")!;
using var document = JsonDocument.Parse(model.ToJson());
if (document.RootElement.GetProperty("data").GetProperty("id").GetString() != "offline") throw new Exception("round trip");
Console.WriteLine("contract passed");
using var client = new BetaGroupsClient(httpClient: new HttpClient(new BadResponse()), baseUri: new Uri("https://example.test"));
client.AuthorizeUsingBearer("offline-symbol-probe");
try { await client.BetaGroupsGetCollectionAsync(); throw new Exception("Expected invalid JSON failure"); } catch (ApiException exception) { Console.WriteLine(exception.ToString()); }
internal sealed class BadResponse : HttpMessageHandler {
 protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token) =>
 Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent("{") });
}
''')
        (consumer / 'NuGet.Config').write_text(f'''<configuration><packageSources><clear/>
<add key="local" value="{feed}"/><add key="nuget.org" value="https://api.nuget.org/v3/index.json"/></packageSources>
<packageSourceMapping><clear/><packageSource key="local"><package pattern="AppStoreConnect"/></packageSource>
<packageSource key="nuget.org"><package pattern="*"/></packageSource></packageSourceMapping>
<config><add key="globalPackagesFolder" value="{folder}/consumer-packages"/></config></configuration>''')
        restore = container(root, source, '4g', folder / 'consumer-packages')
        try:
            code, _, _ = execute(restore, consumer, ['dotnet', 'restore', '-r', 'linux-arm64'], folder / 'consumer-restore.log')
            if code:
                raise RuntimeError(f'{profile} consumer restore failed')
        finally:
            stop(restore)
        link = container(root, source, '6g', folder / 'consumer-packages')
        try:
            cpu_before = cpu(link)
            code, _, seconds = execute(link, consumer, ['dotnet', 'publish', '-c', 'Release', '-r', 'linux-arm64',
                 '--no-restore', '--self-contained', 'true', '-o', str(folder / 'publish')], folder / 'publish.log')
            row.update(publishExitCode=code, publishSeconds=seconds, publishPeakBytes=peak(link), publishCpuSeconds=round(cpu(link) - cpu_before, 3))
            if code == 0:
                out = folder / 'publish'
                code, text, _ = execute(link, consumer, [str(out / 'Probe')], folder / 'run.log')
                row['runExitCode'] = code
                row['defaultHasSdkSourceLine'] = '.g.cs:line ' in text
                row['defaultSdkPdbPublished'] = (out / 'AppStoreConnect.pdb').exists()
                row['publishBytes'] = sum(path.stat().st_size for path in out.rglob('*') if path.is_file())
                code, text, _ = execute(link, root, ['dotnet', str(inspector_dll), str(out / 'AppStoreConnect.dll')], folder / 'linked-assembly.json')
                row['linkedDebug'] = json.loads(text)
                if symbols:
                    # Restore optional symbols before linking, not beside an already-linked
                    # DLL: ILLink must rewrite matching sequence points and assembly tokens.
                    with zipfile.ZipFile(symbols[0]) as archive:
                        member = next(name for name in archive.namelist() if name.endswith('/AppStoreConnect.pdb'))
                        package_pdb = folder / 'consumer-packages/appstoreconnect/1.0.0/lib/net10.0/AppStoreConnect.pdb'
                        package_pdb.write_bytes(archive.read(member))
                    diagnostic = folder / 'diagnostic'
                    code, _, _ = execute(link, consumer, ['dotnet', 'publish', '-c', 'Release', '-r', 'linux-arm64',
                        '--self-contained', 'true', '--artifacts-path', str(folder / 'diagnostic-artifacts'),
                        '-p:CopyDebugSymbolFilesFromPackages=true', '-o', str(diagnostic)], folder / 'diagnostic-publish.log')
                    row['diagnosticPublishExitCode'] = code
                    if code == 0:
                        code, text, _ = execute(link, consumer, [str(diagnostic / 'Probe')], folder / 'diagnostic-run.log')
                        row['diagnosticRunExitCode'] = code
                        row['diagnosticHasSdkSourceLine'] = '.g.cs:line ' in text
                        row['diagnosticSdkPdbPublished'] = (diagnostic / 'AppStoreConnect.pdb').exists()

        finally:
            stop(link)
        if args.docker_images and row.get('runExitCode') == 0:
            row['defaultImage'] = check_image(folder, 'publish', 'default')
            if row.get('diagnosticRunExitCode') == 0:
                row['diagnosticImage'] = check_image(folder, 'diagnostic', 'diagnostic')
        (root / 'results.json').write_text(json.dumps(results, indent=2))
        print(profile, row, flush=True)
    comparable = [row['debug']['assembly'] for row in results['profiles'] if row.get('debug')]
    for field in ['TypeCount', 'MethodCount', 'FieldCount']:
        if len({assembly[field] for assembly in comparable}) > 1:
            raise RuntimeError('Symbol profiles changed managed member inventory: ' + field)
    separated = [row['debug']['assembly'] for row in results['profiles']
                 if row.get('debug') and row['profile'] in {'embedded', 'portable'}]
    for field in ['MetadataBytes', 'IlBytes']:
        if len({assembly[field] for assembly in separated}) > 1:
            raise RuntimeError('External symbols changed managed code footprint: ' + field)
    return int(any(p['packExitCode'] != 0 or p.get('publishExitCode') != 0 or p.get('runExitCode') != 0
                   or (p['profile'] == 'portable' and (p.get('defaultSdkPdbPublished') is not False
                       or p['sdkPdbInMainPackage'] or p['snupkgBytes'] <= 0
                       or p['debug']['externalPdbBytes'] <= 0 or sha not in p['debug']['sourceLink']
                       or p.get('diagnosticPublishExitCode') != 0 or p.get('diagnosticRunExitCode') != 0
                       or not p.get('diagnosticHasSdkSourceLine') or not p.get('diagnosticSdkPdbPublished')))
                   or (args.docker_images and (p.get('defaultImage', {}).get('runExitCode') != 0
                       or (p['profile'] == 'portable' and (p['defaultImage']['sdkPdbPresent']
                           or p.get('diagnosticImage', {}).get('runExitCode') != 0
                           or not p['diagnosticImage']['sdkPdbPresent'] or not p['diagnosticImage']['sdkSourceLine']))))
                   for p in results['profiles']))


if __name__ == '__main__':
    raise SystemExit(main())
