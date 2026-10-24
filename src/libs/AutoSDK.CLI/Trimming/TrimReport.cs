using System.Text.Json;
using System.Text.Json.Serialization;

namespace AutoSDK.CLI.Trimming;

internal sealed record TrimReport(
    int SchemaVersion,
    string Project,
    string AssemblyName,
    string TargetFramework,
    string RuntimeIdentifier,
    string PublishMode,
    string SymbolPolicy,
    string Rooting,
    double PublishSeconds,
    int PublishExitCode,
    int TrimmingWarningCount,
    long PublishDirectoryBytes,
    long ExternalSymbolBytes,
    long AppExecutableBytes,
    AssemblyFootprint[] Assemblies)
{
    public static TrimReport Collect(
        string directory,
        string project,
        string assemblyName,
        string targetFramework,
        string runtimeIdentifier,
        bool nativeAot,
        bool removeSymbols,
        double publishSeconds,
        int publishExitCode,
        int trimmingWarningCount)
    {
        var files = Directory.Exists(directory)
            ? Directory.GetFiles(directory, "*", SearchOption.AllDirectories)
            : [];
        var assemblies = files
            .Where(file => file.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
            .Order(StringComparer.Ordinal)
            .Select(AssemblyFootprint.Read)
            .OfType<AssemblyFootprint>()
            .ToArray();
        var executable = Path.Combine(directory,
            runtimeIdentifier.StartsWith("win-", StringComparison.Ordinal) ? "TrimmingCheck.exe" : "TrimmingCheck");
        return new(
            1, project, assemblyName, targetFramework, runtimeIdentifier,
            nativeAot ? "nativeaot" : "trim",
            removeSymbols ? "remove-managed" : "inherit",
            "whole-target-assembly-for-compatibility",
            publishSeconds, publishExitCode, trimmingWarningCount,
            files.Sum(file => new FileInfo(file).Length),
            files.Where(IsExternalSymbol).Sum(file => new FileInfo(file).Length),
            System.IO.File.Exists(executable) ? new FileInfo(executable).Length : 0L,
            assemblies);
    }

    public async Task WriteAsync(string path)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(path))!);
        var json = JsonSerializer.Serialize(this, TrimReportJsonSerializerContext.Default.TrimReport);
        await System.IO.File.WriteAllTextAsync(path, json + Environment.NewLine).ConfigureAwait(false);
    }

    private static bool IsExternalSymbol(string path) =>
        path.EndsWith(".pdb", StringComparison.OrdinalIgnoreCase) ||
        path.EndsWith(".dbg", StringComparison.OrdinalIgnoreCase) ||
        path.Split(Path.DirectorySeparatorChar).Any(part => part.EndsWith(".dSYM", StringComparison.OrdinalIgnoreCase));
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true)]
[JsonSerializable(typeof(TrimReport))]
internal sealed partial class TrimReportJsonSerializerContext : JsonSerializerContext;
