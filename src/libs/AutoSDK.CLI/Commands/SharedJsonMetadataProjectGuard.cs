using System.Xml.Linq;

namespace AutoSDK.CLI.Commands;

internal static class SharedJsonMetadataProjectGuard
{
    internal static void Validate(string output, string project)
    {
        var outputPath = Path.GetFullPath(output);
        var parent = Path.GetDirectoryName(outputPath)!;
        var outputProjects = Directory.Exists(outputPath) ? Directory.GetFiles(outputPath, "*.csproj") : [];
        var projects = string.IsNullOrWhiteSpace(project)
            ? outputProjects.Length > 0 ? outputProjects : Directory.Exists(parent) ? Directory.GetFiles(parent, "*.csproj") : []
            : [Path.GetFullPath(project)];
        if (projects.Length > 1)
        {
            throw new ArgumentException("Multiple consuming projects found; specify --shared-json-metadata-project.");
        }
        if (projects.Length == 0)
        {
            Console.WriteLine("Shared JSON metadata requires a consuming net10.0 project: import the emitted " +
                "AutoSDK.SharedJsonMetadata.props and reference AutoSDK.JsonMetadata with " +
                "Version=\"$(AutoSDKJsonMetadataVersion)\" PrivateAssets=\"all\". " +
                "Pass --shared-json-metadata-project on subsequent regeneration to validate that setup.");
            return;
        }

        var path = projects[0];
        var root = XDocument.Load(path);
        var reference = root.Descendants().Where(node => node.Name.LocalName == "PackageReference" &&
            (string?)node.Attribute("Include") == "AutoSDK.JsonMetadata").ToArray();
        var binding = Path.Combine(outputPath, "AutoSDK.SharedJsonMetadata.props");
        var imports = root.Descendants().Where(node => node.Name.LocalName == "Import")
            .Select(node => (string?)node.Attribute("Project"))
            .Where(value => !string.IsNullOrWhiteSpace(value) && !value!.Contains('$', StringComparison.Ordinal))
            .Select(value => Path.GetFullPath(Path.Combine(Path.GetDirectoryName(path)!, value!.Replace('\\', Path.DirectorySeparatorChar))))
            .Count(value => string.Equals(value, binding, OperatingSystem.IsWindows() ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal));
        var frameworks = root.Descendants().Where(node => node.Name.LocalName is "TargetFramework" or "TargetFrameworks")
            .Select(node => node.Value).ToArray();
        if (reference.Length != 1 ||
            (string?)reference[0].Attribute("Version") != "$(AutoSDKJsonMetadataVersion)" ||
            !string.Equals((string?)reference[0].Attribute("PrivateAssets"), "all", StringComparison.OrdinalIgnoreCase) ||
            imports != 1 || frameworks.Length != 1 || frameworks[0] != "net10.0")
        {
            throw new ArgumentException($"{path}: shared metadata requires net10.0, an import of {binding}, and " +
                "AutoSDK.JsonMetadata Version=\"$(AutoSDKJsonMetadataVersion)\" PrivateAssets=\"all\". " +
                "Update the consuming project before regeneration; no generated files were changed.");
        }
    }
}
