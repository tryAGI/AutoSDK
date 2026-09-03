using System.Globalization;
using System.Text;
using AutoSDK.Packaging;

namespace AutoSDK.CLI.Commands;

/// <summary>
/// Emits the project files, solution and manifest for a split-by-tags package family.
/// </summary>
/// <remarks>
/// Everything this writes is a plain text artifact derived from a <see cref="PackagePlan"/>, so
/// output is byte-stable across runs — the manifest deliberately carries no timestamps.
/// </remarks>
internal static class PackageFamilyScaffolder
{
    /// <summary>
    /// File name of the machine-readable tag-to-package map written at the packages root.
    /// </summary>
    public const string ManifestFileName = "autosdk-packages.json";

    /// <summary>
    /// Directory each package keeps its generated sources in, relative to the package directory.
    /// </summary>
    public const string GeneratedDirectoryName = "Generated";

    /// <summary>
    /// Builds every non-source artifact of the family: one .csproj per package, the solution and
    /// the manifest. Paths are relative to the packages root.
    /// </summary>
    /// <param name="generatedFileCounts">
    /// Generated sources routed to each package id. Recorded in the manifest so a repository can
    /// track how the family is balanced -- how much of it is still shared -- without re-deriving
    /// the routing or counting files on disk.
    /// </param>
    public static IReadOnlyList<(string RelativePath, string Text)> CreateFiles(
        PackagePlan plan,
        string strongNamePublicKey,
        IReadOnlyDictionary<string, int>? generatedFileCounts = null)
    {
        var files = new List<(string, string)>(plan.Packages.Length + 2);

        foreach (var package in plan.Packages)
        {
            files.Add((
                Path.Combine(package.DirectoryName, $"{package.PackageId}.csproj"),
                CreateProjectFile(plan, package, strongNamePublicKey)));
        }

        files.Add(($"{plan.BasePackageId}.slnx", CreateSolutionFile(plan)));
        files.Add((ManifestFileName, CreateManifest(plan, generatedFileCounts)));

        return files;
    }

    private static string CreateProjectFile(
        PackagePlan plan,
        PackageDescriptor package,
        string strongNamePublicKey)
    {
        var builder = new StringBuilder();
        builder.AppendLine("""<Project Sdk="Microsoft.NET.Sdk">""");
        builder.AppendLine();
        builder.AppendLine("  <PropertyGroup>");
        builder.AppendLine(FormattableString.Invariant($"    <TargetFramework>{plan.TargetFramework}</TargetFramework>"));
        builder.AppendLine(FormattableString.Invariant($"    <RootNamespace>{plan.Namespace}</RootNamespace>"));
        builder.AppendLine("  </PropertyGroup>");
        builder.AppendLine();
        builder.AppendLine("""  <PropertyGroup Label="Nuget">""");
        builder.AppendLine(FormattableString.Invariant($"    <PackageId>{package.PackageId}</PackageId>"));
        builder.AppendLine(FormattableString.Invariant($"    <Description>{DescribePackage(plan, package)}</Description>"));
        builder.AppendLine("  </PropertyGroup>");

        // `dotnet pack` turns ProjectReferences into package dependencies, so this single form
        // gives project references for repository builds and package references for published
        // output without a second code path.
        var references = GetProjectReferences(plan, package).ToArray();
        if (references.Length != 0)
        {
            builder.AppendLine();
            builder.AppendLine("  <ItemGroup>");
            foreach (var reference in references)
            {
                builder.AppendLine(FormattableString.Invariant(
                    $"""    <ProjectReference Include="..\{reference}\{reference}.csproj" />"""));
            }

            builder.AppendLine("  </ItemGroup>");
        }

        var visibleTo = GetInternalsVisibleTo(plan, package).ToArray();
        if (visibleTo.Length != 0 && !string.IsNullOrWhiteSpace(strongNamePublicKey))
        {
            builder.AppendLine();
            builder.AppendLine("  <ItemGroup>");
            foreach (var target in visibleTo)
            {
                builder.AppendLine(FormattableString.Invariant(
                    $"""    <InternalsVisibleTo Include="{target}, PublicKey={strongNamePublicKey}" />"""));
            }

            builder.AppendLine("  </ItemGroup>");
        }

        builder.AppendLine();
        builder.AppendLine("</Project>");

        return builder.ToString();
    }

    /// <summary>
    /// Core references nothing, every tag package references Core, and the facade references Core
    /// plus every tag package. That ordering is what keeps the graph acyclic.
    /// </summary>
    private static IEnumerable<string> GetProjectReferences(PackagePlan plan, PackageDescriptor package)
    {
        switch (package.Kind)
        {
            case PackageKind.Core:
                yield break;

            case PackageKind.Tag:
                yield return plan.Core.PackageId;
                yield break;

            case PackageKind.Facade:
                yield return plan.Core.PackageId;
                foreach (var tagPackage in plan.TagPackages)
                {
                    yield return tagPackage.PackageId;
                }

                yield break;

            default:
                yield break;
        }
    }

    /// <summary>
    /// Who needs to see this package's internals when a strong-name key lets AutoSDK keep the
    /// shared runtime members <c>internal</c>: Core is used by everyone, and each tag client's
    /// deferred serializer-context hook is assigned by the facade.
    /// </summary>
    private static IEnumerable<string> GetInternalsVisibleTo(PackagePlan plan, PackageDescriptor package)
    {
        switch (package.Kind)
        {
            case PackageKind.Core:
                foreach (var tagPackage in plan.TagPackages)
                {
                    yield return tagPackage.PackageId;
                }

                yield return plan.BasePackageId;
                yield break;

            case PackageKind.Tag:
                yield return plan.BasePackageId;
                yield break;

            default:
                yield break;
        }
    }

    private static string DescribePackage(PackagePlan plan, PackageDescriptor package)
    {
        return package.Kind switch
        {
            PackageKind.Core =>
                $"Shared models, converters and runtime support for the {plan.BasePackageId} SDK. Referenced by every package in the family.",
            PackageKind.Tag =>
                $"{string.Join(", ", package.Tags)} operations of the {plan.BasePackageId} SDK. Reference this package alone to avoid compiling the rest of the API.",
            _ =>
                $"The complete {plan.BasePackageId} SDK. References every generated tag package and exposes them through a single root client.",
        };
    }

    private static string CreateSolutionFile(PackagePlan plan)
    {
        var builder = new StringBuilder();
        builder.AppendLine("<Solution>");
        builder.AppendLine("""  <Folder Name="/packages/">""");
        foreach (var package in plan.Packages)
        {
            builder.AppendLine(FormattableString.Invariant(
                $"""    <Project Path="{package.DirectoryName}/{package.PackageId}.csproj" />"""));
        }

        builder.AppendLine("  </Folder>");
        builder.AppendLine("</Solution>");

        return builder.ToString();
    }

    /// <summary>
    /// The stable machine-readable tag-to-package map, so a generated repository can build, test,
    /// document and publish the family without rediscovering names.
    /// </summary>
    private static string CreateManifest(
        PackagePlan plan,
        IReadOnlyDictionary<string, int>? generatedFileCounts)
    {
        var builder = new StringBuilder();
        builder.AppendLine("{");
        builder.AppendLine("""  "schemaVersion": 1,""");
        builder.AppendLine(FormattableString.Invariant($"""  "basePackageId": {Quote(plan.BasePackageId)},"""));
        builder.AppendLine(FormattableString.Invariant($"""  "corePackageId": {Quote(plan.Core.PackageId)},"""));
        builder.AppendLine(FormattableString.Invariant($"""  "namespace": {Quote(plan.Namespace)},"""));
        builder.AppendLine(FormattableString.Invariant($"""  "targetFramework": {Quote(plan.TargetFramework)},"""));
        builder.AppendLine("""  "packages": [""");

        for (var index = 0; index < plan.Packages.Length; index++)
        {
            var package = plan.Packages[index];
            var comma = index == plan.Packages.Length - 1 ? string.Empty : ",";
            builder.AppendLine("    {");
            builder.AppendLine(FormattableString.Invariant($"""      "packageId": {Quote(package.PackageId)},"""));
            builder.AppendLine(FormattableString.Invariant($"""      "kind": {Quote(DescribeKind(package.Kind))},"""));
            builder.AppendLine(FormattableString.Invariant(
                $"""      "projectPath": {Quote($"{package.DirectoryName}/{package.PackageId}.csproj")},"""));
            builder.AppendLine(FormattableString.Invariant($"""      "assemblyName": {Quote(package.PackageId)},"""));
            builder.AppendLine(FormattableString.Invariant($"""      "tags": {QuoteArray(package.Tags)},"""));
            builder.AppendLine(FormattableString.Invariant($"""      "clientClassNames": {QuoteArray(package.ClientClassNames)},"""));
            builder.AppendLine(FormattableString.Invariant(
                $"""      "generatedFileCount": {(generatedFileCounts is not null && generatedFileCounts.TryGetValue(package.PackageId, out var fileCount) ? fileCount : 0)}"""));
            builder.AppendLine(FormattableString.Invariant($"    }}{comma}"));
        }

        builder.AppendLine("  ]");
        builder.AppendLine("}");

        return builder.ToString();
    }

    /// <summary>
    /// Lower-case manifest spelling of a package kind. Written out rather than lower-cased so the
    /// manifest vocabulary is fixed by this method instead of by enum member casing.
    /// </summary>
    private static string DescribeKind(PackageKind kind)
    {
        return kind switch
        {
            PackageKind.Core => "core",
            PackageKind.Tag => "tag",
            PackageKind.Facade => "facade",
            _ => "unknown",
        };
    }

    private static string QuoteArray(IEnumerable<string> values)
    {
        var quoted = values.Select(Quote).ToArray();

        return quoted.Length == 0
            ? "[]"
            : $"[{string.Join(", ", quoted)}]";
    }

    private static string Quote(string value)
    {
        var builder = new StringBuilder(value.Length + 2);
        builder.Append('"');
        foreach (var character in value)
        {
            switch (character)
            {
                case '"':
                    builder.Append("\\\"");
                    break;
                case '\\':
                    builder.Append("\\\\");
                    break;
                case '\n':
                    builder.Append("\\n");
                    break;
                case '\r':
                    builder.Append("\\r");
                    break;
                case '\t':
                    builder.Append("\\t");
                    break;
                default:
                    if (character < ' ')
                    {
                        builder.Append(FormattableString.Invariant($"\\u{(int)character:x4}"));
                    }
                    else
                    {
                        builder.Append(character);
                    }

                    break;
            }
        }

        builder.Append('"');

        return builder.ToString();
    }
}
