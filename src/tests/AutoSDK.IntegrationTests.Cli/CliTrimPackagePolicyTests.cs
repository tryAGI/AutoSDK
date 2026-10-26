using System.Text.Json;

namespace AutoSDK.IntegrationTests;

public partial class CliTests
{
    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task Trim_ReleasePackageGenerationDoesNotLeakIntoAnalysis(bool nativeAot)
    {
        const string spec = """
        openapi: 3.0.3
        info:
          title: Trim packaging policy
          version: 1.0.0
        paths: {}
        components:
          schemas:
            Payload:
              type: object
              properties:
                text:
                  type: string
        """;
        await GenerateFromContentAsync("trim-package-policy.yaml", spec, targetFramework: "net10.0",
            assertBuiltOutput: async directory =>
            {
                await File.WriteAllTextAsync(Path.Combine(directory, "Directory.Build.props"), """
                <Project><PropertyGroup Condition="'$(Configuration)' == 'Release'">
                <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
                </PropertyGroup></Project>
                """);
                var report = Path.Combine(directory, "trim-report.json");
                var repository = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
                var arguments = new List<string>
                {
                    "run", "--disable-build-servers", "--no-launch-profile", "--project", "src/libs/AutoSDK.CLI",
                    "trim", Path.Combine(directory, "Oag.csproj"), "--report-json", report,
                };
                if (nativeAot) arguments.Add("--aot");
                var result = await RunDotnetAsync(repository, arguments.ToArray());
                result.ExitCode.Should().Be(0, result.StandardOutput + result.StandardError);
                result.StandardOutput.Should().Contain("No trimming warnings found");
                using var json = JsonDocument.Parse(await File.ReadAllTextAsync(report));
                json.RootElement.GetProperty("schemaVersion").GetInt32().Should().Be(1);
                json.RootElement.GetProperty("appExecutableBytes").GetInt64().Should().BeGreaterThan(0);
            });
    }
}
