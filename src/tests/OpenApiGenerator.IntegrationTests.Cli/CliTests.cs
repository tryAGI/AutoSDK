using CliWrap.Buffered;

namespace OpenApiGenerator.IntegrationTests;

[TestClass]
public class CliTests
{
    //[DataTestMethod]
    //[DataRow("github.yaml")]
    [DataRow("ipinfo.yaml")]
    [DataRow("langsmith.yaml")]
    [DataRow("ollama.yaml")]
    [DataRow("openai.yaml")]
    [DataRow("petstore.yaml")]
    [DataRow("replicate.json")]
    //[DataRow("special-cases.yaml")]
    [DataRow("twitch.json")]
    [DataRow("https://dedoose-rest-api.onrender.com/swagger/v1/swagger.json")]
    public async Task Run(string spec)
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            _ = await CliWrap.Cli.Wrap("dotnet")
                .WithArguments([
                    "run",
                    "--project", "src/libs/OpenApiGenerator.Cli",
                    "generate", spec.StartsWith("http") ? spec : $"specs/{spec}",
                    "--output", tempDirectory,
                    "--namespace", "Oag",
                    // --json-serializer-type SystemTextJson --target-framework netstandard2.0 --generate-sdk
                ])
                .WithWorkingDirectory(repositoryDirectory)
                .ExecuteBufferedAsync();

            Directory.EnumerateFiles(tempDirectory, "*", SearchOption.AllDirectories)
                .Should()
                .NotBeEmpty();

            await File.WriteAllTextAsync(Path.Combine(tempDirectory, "Oag.csproj"), @"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <LangVersion>preview</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <PropertyGroup Label=""Analyzers"">
    <EnableNETAnalyzers>true</EnableNETAnalyzers>
    <AnalysisLevel>latest</AnalysisLevel>
    <AnalysisMode>All</AnalysisMode>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>

</Project>");
            
            var response = await DotnetCliWrapper.Dotnet.BuildAsync(tempDirectory + "/");
            Console.WriteLine(response.StandardOutput);
            Console.WriteLine(response.StandardError);
            response.Diagnostics.Should().BeEmpty();
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }
}