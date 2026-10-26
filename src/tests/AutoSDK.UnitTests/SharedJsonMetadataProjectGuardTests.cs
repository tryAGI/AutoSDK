extern alias AutoSdkCli;
using Guard = AutoSdkCli::AutoSDK.CLI.Commands.SharedJsonMetadataProjectGuard;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class SharedJsonMetadataProjectGuardTests
{
    [TestMethod]
    public void Regeneration_RejectsMissingOrLeakingAnalyzerBeforeWriting()
    {
        var directory = Path.Combine(Path.GetTempPath(), "autosdk-guard-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);
        try
        {
            var project = Path.Combine(directory, "Fixture.csproj");
            var output = Path.Combine(directory, "Generated");
            const string valid = """
                <Project><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup>
                <Import Project="Generated/AutoSDK.SharedJsonMetadata.props" />
                <ItemGroup><PackageReference Include="AutoSDK.JsonMetadata"
                Version="$(AutoSDKJsonMetadataVersion)" PrivateAssets="all" /></ItemGroup></Project>
                """;
            foreach (var invalid in new[] { "<Project />", valid.Replace("PrivateAssets=\"all\"", "PrivateAssets=\"none\"", StringComparison.Ordinal),
                         valid.Replace("net10.0", "netstandard2.0", StringComparison.Ordinal),
                         valid.Replace("$(AutoSDKJsonMetadataVersion)", "1.0.0", StringComparison.Ordinal) })
            {
                File.WriteAllText(project, invalid);
                Action action = () => Guard.Validate(output, string.Empty);
                action.Should().Throw<ArgumentException>();
                Directory.Exists(output).Should().BeFalse();
            }
            File.WriteAllText(project, valid);
            Guard.Validate(output, project); // First generation does not require an existing manifest.
            Guard.Validate(output, string.Empty); // Normal regeneration discovers the consuming project.
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }
}
