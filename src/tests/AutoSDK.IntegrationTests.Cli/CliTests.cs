using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliTests
{
    [TestMethod]
    public async Task Generate_ElevenLabsStreamingSdk()
    {
        await GenerateAsync("elevenlabs.json", expectResponseStream: true);
    }

    [TestMethod]
    public async Task Generate_WeaviateSdk()
    {
        await GenerateAsync("weaviate.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_CohereSdk()
    {
        await GenerateAsync("cohere.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_MistralSdk()
    {
        await GenerateAsync("mistral.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_DeepgramMultichannelSdk()
    {
        await GenerateAsync("deepgram-multichannel.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_LangsmithSdk()
    {
        await GenerateAsync("langsmith.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_TogetherSdk()
    {
        await GenerateAsync("together.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WithInjectedApiKeyHeaderSecurityScheme_UsesFriendlyConstructorFileName()
    {
        await GenerateAsync(
            "petstore.yaml",
            targetFramework: "net10.0",
            namespaceValue: "Qdrant",
            clientClassName: "QdrantClient",
            expectedGeneratedFile: "Qdrant.QdrantClient.Constructors.ApiKeyInHeader.g.cs",
            additionalArguments: ["--security-scheme", "ApiKey:Header:api-key"]);
    }

    private static async Task GenerateAsync(
        string spec,
        string targetFramework = "net8.0",
        bool expectResponseStream = false,
        string namespaceValue = "Oag",
        string clientClassName = "",
        string? expectedGeneratedFile = null,
        params string[] additionalArguments)
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var generateArguments = new List<string>
            {
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", spec.StartsWith("http") ? spec : $"specs/{spec}",
                "--namespace", namespaceValue,
                "--targetFramework", targetFramework,
                "--output", tempDirectory,
            };
            if (!string.IsNullOrWhiteSpace(clientClassName))
            {
                generateArguments.Add("--clientClassName");
                generateArguments.Add(clientClassName);
            }
            generateArguments.AddRange(additionalArguments);

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                generateArguments.ToArray());
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            Directory.EnumerateFiles(tempDirectory, "*", SearchOption.AllDirectories)
                .Should()
                .NotBeEmpty();

            if (expectResponseStream)
            {
                Directory.EnumerateFiles(tempDirectory, "*.ResponseStream.g.cs", SearchOption.AllDirectories)
                    .Should()
                    .ContainSingle();
            }

            if (!string.IsNullOrWhiteSpace(expectedGeneratedFile))
            {
                File.Exists(Path.Combine(tempDirectory, expectedGeneratedFile))
                    .Should()
                    .BeTrue();
            }

            await File.WriteAllTextAsync(Path.Combine(tempDirectory, "Oag.csproj"), $@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>{targetFramework}</TargetFramework>
    <LangVersion>preview</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>

  <PropertyGroup Label=""Analyzers"">
    <EnableNETAnalyzers>true</EnableNETAnalyzers>
    <AnalysisLevel>latest</AnalysisLevel>
    <AnalysisMode>All</AnalysisMode>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>

</Project>");

            var buildResult = await RunDotnetAsync(
                tempDirectory,
                "build",
                "--disable-build-servers",
                Path.Combine(tempDirectory, "Oag.csproj"));
            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
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
            var initResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "init",
                "TestAPI",
                "TestApi",
                "http://localhost/testspec.yaml",
                "TestCompany",
                "--output", tempDirectory);
            Console.WriteLine(initResult.StandardOutput);
            Console.WriteLine(initResult.StandardError);
            initResult.ExitCode.Should().Be(0);

            Directory.EnumerateFiles(tempDirectory, "*", SearchOption.AllDirectories)
                .Should()
                .NotBeEmpty();
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    private static async Task<(int ExitCode, string StandardOutput, string StandardError)> RunDotnetAsync(
        string workingDirectory,
        params string[] arguments)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            },
        };

        process.StartInfo.Environment["DOTNET_CLI_USE_MSBUILD_SERVER"] = "0";
        process.StartInfo.Environment["UseSharedCompilation"] = "false";

        foreach (var argument in arguments)
        {
            process.StartInfo.ArgumentList.Add(argument);
        }

        process.Start();

        var standardOutputTask = process.StandardOutput.ReadToEndAsync();
        var standardErrorTask = process.StandardError.ReadToEndAsync();

        await process.WaitForExitAsync();

        return (
            ExitCode: process.ExitCode,
            StandardOutput: await standardOutputTask,
            StandardError: await standardErrorTask);
    }

    private static void TryDeleteDirectory(string path)
    {
        try
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, recursive: true);
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Failed to delete temporary test output at '{path}': {exception.Message}");
        }
    }
}
