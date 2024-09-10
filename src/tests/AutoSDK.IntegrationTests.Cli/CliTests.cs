using CliWrap.Buffered;

namespace AutoSDK.IntegrationTests;

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
    [DataRow("replicate.yaml")]
    [DataRow("huggingface.yaml")]
    [DataRow("ai21.yaml")]
    [DataRow("cohere.yaml")]
    [DataRow("special-cases.yaml")]
    [DataRow("twitch.json")]
    [DataRow("https://dedoose-rest-api.onrender.com/swagger/v1/swagger.json")]
    [DataRow("together.yaml")]
    [DataRow("mystic.yaml")]
    public async Task Generate(string spec)
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
                    "--project", "src/libs/AutoSDK.CLI",
                    "generate", spec.StartsWith("http") ? spec : $"specs/{spec}",
                    "--namespace", "Oag",
                    "--targetFramework", "net8.0",
                    "--output", tempDirectory,
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
    
    //[TestMethod]
    public async Task Initialize()
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
                    "--project", "src/libs/AutoSDK.CLI",
                    "init",
                    "TestAPI",
                    "TestApi",
                    "http://localhost/testspec.yaml",
                    "TestCompany",
                    "--output", tempDirectory,
                ])
                .WithWorkingDirectory(repositoryDirectory)
                .ExecuteBufferedAsync();

            Directory.EnumerateFiles(tempDirectory, "*", SearchOption.AllDirectories)
                .Should()
                .NotBeEmpty();
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }
}