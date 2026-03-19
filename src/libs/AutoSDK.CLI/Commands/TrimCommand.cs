using System.CommandLine;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace AutoSDK.CLI.Commands;

internal sealed class TrimCommand : Command
{
    private Argument<string> CsprojPath { get; } = new(
        name: "csproj-path")
    {
        Description = "Path to the .csproj to validate for trimming/NativeAOT compatibility",
    };

    private Option<string> TargetFramework { get; } = new(
        name: "--target-framework",
        aliases: ["-t"])
    {
        DefaultValueFactory = _ => "net10.0",
        Description = "Target framework for publish",
    };

    private Option<string> RuntimeId { get; } = new(
        name: "--rid",
        aliases: ["-r"])
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Runtime identifier override (e.g., linux-x64, win-x64, osx-arm64). Auto-detected if not specified.",
    };

    private Option<bool> Verbose { get; } = new(
        name: "--verbose",
        aliases: ["-v"])
    {
        DefaultValueFactory = _ => false,
        Description = "Show full dotnet publish output",
    };

    public TrimCommand() : base(name: "trim", description: "Validates trimming/NativeAOT compatibility for a .csproj")
    {
        Arguments.Add(CsprojPath);
        Options.Add(TargetFramework);
        Options.Add(RuntimeId);
        Options.Add(Verbose);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        var csprojPath = parseResult.GetRequiredValue(CsprojPath);
        var targetFramework = parseResult.GetRequiredValue(TargetFramework);
        var runtimeId = parseResult.GetRequiredValue(RuntimeId);
        var verbose = parseResult.GetRequiredValue(Verbose);

        var fullCsprojPath = Path.GetFullPath(csprojPath);
        if (!File.Exists(fullCsprojPath))
        {
            await Console.Error.WriteLineAsync($"Error: File not found: {fullCsprojPath}").ConfigureAwait(false);
            return;
        }

        var projectDir = Path.GetDirectoryName(fullCsprojPath)!;
        var projectFileName = Path.GetFileName(fullCsprojPath);
        var projectName = Path.GetFileNameWithoutExtension(fullCsprojPath);

        // Extract assembly name from .csproj (fallback to filename)
        var assemblyName = projectName;
        try
        {
            var doc = XDocument.Load(fullCsprojPath);
            var asmElement = doc.Descendants("AssemblyName").FirstOrDefault();
            if (asmElement != null && !string.IsNullOrWhiteSpace(asmElement.Value))
            {
                assemblyName = asmElement.Value;
            }
        }
        catch (Exception ex) when (ex is System.Xml.XmlException or IOException)
        {
            // Fallback to filename-based name
        }

        // Detect runtime identifier (or use override)
        var rid = string.IsNullOrWhiteSpace(runtimeId)
            ? GetRuntimeIdentifier()
            : runtimeId;

        var tempDir = Path.Combine(projectDir, ".autosdk-trim");

        try
        {
            // Create temp directory
            Directory.CreateDirectory(tempDir);

            // Write Program.cs
            var programCs = """
                Console.WriteLine("Trimming check.");
                """;
            await File.WriteAllTextAsync(
                Path.Combine(tempDir, "Program.cs"),
                programCs).ConfigureAwait(false);

            // Write TrimmingCheck.csproj with relative reference to the target project
            var relativePath = Path.GetRelativePath(tempDir, fullCsprojPath);
            var trimmingCsproj = $"""
                <Project Sdk="Microsoft.NET.Sdk">

                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>{targetFramework}</TargetFramework>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <PublishTrimmed>true</PublishTrimmed>
                  </PropertyGroup>

                  <ItemGroup>
                    <ProjectReference Include="{relativePath}" />
                  </ItemGroup>

                  <ItemGroup>
                    <TrimmerRootAssembly Include="{assemblyName}" />
                  </ItemGroup>

                  <PropertyGroup Label="Publish">
                    <RuntimeIdentifier>{rid}</RuntimeIdentifier>
                    <SelfContained>true</SelfContained>
                  </PropertyGroup>

                </Project>
                """;
            await File.WriteAllTextAsync(
                Path.Combine(tempDir, "TrimmingCheck.csproj"),
                trimmingCsproj).ConfigureAwait(false);

            await Console.Out.WriteLineAsync($"Validating trimming compatibility for {projectName}...").ConfigureAwait(false);
            await Console.Out.WriteLineAsync($"  Target framework: {targetFramework}").ConfigureAwait(false);
            await Console.Out.WriteLineAsync($"  Runtime identifier: {rid}").ConfigureAwait(false);
            await Console.Out.WriteLineAsync($"  Assembly name: {assemblyName}").ConfigureAwait(false);
            await Console.Out.WriteLineAsync().ConfigureAwait(false);

            // Run dotnet publish
            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = "publish TrimmingCheck.csproj -c Release",
                WorkingDirectory = tempDir,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            using var process = Process.Start(psi);
            if (process == null)
            {
                await Console.Error.WriteLineAsync("Error: Failed to start dotnet process.").ConfigureAwait(false);
                return;
            }

            var stdout = await process.StandardOutput.ReadToEndAsync().ConfigureAwait(false);
            var stderr = await process.StandardError.ReadToEndAsync().ConfigureAwait(false);
            await process.WaitForExitAsync().ConfigureAwait(false);

            if (verbose)
            {
                if (!string.IsNullOrWhiteSpace(stdout))
                {
                    await Console.Out.WriteLineAsync(stdout).ConfigureAwait(false);
                }
                if (!string.IsNullOrWhiteSpace(stderr))
                {
                    await Console.Error.WriteLineAsync(stderr).ConfigureAwait(false);
                }
            }

            // Parse trimming warnings from output
            var allOutput = stdout + Environment.NewLine + stderr;
            var lines = allOutput.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            var trimmingWarnings = lines
                .Where(l => l.Contains("warning IL", StringComparison.OrdinalIgnoreCase))
                .Select(l => l.Trim())
                .ToList();
            var errors = lines
                .Where(l => l.Contains("error ", StringComparison.OrdinalIgnoreCase) &&
                            !l.Contains("0 Error", StringComparison.OrdinalIgnoreCase))
                .Select(l => l.Trim())
                .ToList();

            if (trimmingWarnings.Count > 0)
            {
                await Console.Out.WriteLineAsync($"Found {trimmingWarnings.Count} trimming warning(s):").ConfigureAwait(false);
                await Console.Out.WriteLineAsync().ConfigureAwait(false);
                foreach (var warning in trimmingWarnings)
                {
                    await Console.Out.WriteLineAsync($"  {warning}").ConfigureAwait(false);
                }
                await Console.Out.WriteLineAsync().ConfigureAwait(false);
            }

            if (errors.Count > 0 || process.ExitCode != 0)
            {
                if (errors.Count > 0)
                {
                    await Console.Error.WriteLineAsync($"Build failed with {errors.Count} error(s):").ConfigureAwait(false);
                    await Console.Error.WriteLineAsync().ConfigureAwait(false);
                    foreach (var error in errors)
                    {
                        await Console.Error.WriteLineAsync($"  {error}").ConfigureAwait(false);
                    }
                    await Console.Error.WriteLineAsync().ConfigureAwait(false);
                }
                else if (!verbose)
                {
                    await Console.Error.WriteLineAsync("Build failed. Run with --verbose for details.").ConfigureAwait(false);
                    await Console.Error.WriteLineAsync().ConfigureAwait(false);
                }

                Environment.ExitCode = 1;
                return;
            }

            if (trimmingWarnings.Count == 0)
            {
                await Console.Out.WriteLineAsync("No trimming warnings found. The project is trimming-compatible.").ConfigureAwait(false);
            }
            else
            {
                Environment.ExitCode = 1;
            }
        }
        finally
        {
            // Clean up temp directory
            try
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, recursive: true);
                }
            }
            catch (IOException)
            {
                // Best effort cleanup
            }
        }
    }

    private static string GetRuntimeIdentifier()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return RuntimeInformation.OSArchitecture == Architecture.Arm64
                ? "win-arm64"
                : "win-x64";
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return RuntimeInformation.OSArchitecture == Architecture.Arm64
                ? "osx-arm64"
                : "osx-x64";
        }

        return RuntimeInformation.OSArchitecture == Architecture.Arm64
            ? "linux-arm64"
            : "linux-x64";
    }
}
