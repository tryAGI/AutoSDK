using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliTagGroupNamingTests
{
    [TestMethod]
    public async Task Generate_WithFernGroupNameMatchingTagPascalCase_UsesUnsuffixedClientName_AndBuilds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: TagGroupCollision
  version: 1.0.0
tags:
  - name: Corpora
paths:
  /corpora:
    get:
      operationId: listCorpora
      tags:
        - Corpora
      x-fern-sdk-group-name: corpora
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/CorporaResponse'
components:
  schemas:
    CorporaResponse:
      type: object
      properties:
        id:
          type: string
""";

        await GenerateFromContentAsync(
            fileName: "tag-group-collision.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("public partial class CorporaClient");
                content.Should().NotContain("public partial class Corpora2Client");
                content.Should().NotContain("Corpora2Command");
            });
    }

    private static async Task GenerateFromContentAsync(
        string fileName,
        string specContent,
        string targetFramework = "net8.0",
        Func<string, Task>? assertGeneratedOutput = null)
    {
        var tempSpecDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(tempSpecDirectory);

        var specPath = Path.Combine(tempSpecDirectory, fileName);

        try
        {
            await File.WriteAllTextAsync(specPath, specContent);
            await GenerateAsync(specPath, targetFramework, assertGeneratedOutput);
        }
        finally
        {
            TryDeleteDirectory(tempSpecDirectory);
        }
    }

    private static async Task GenerateAsync(
        string specPath,
        string targetFramework,
        Func<string, Task>? assertGeneratedOutput)
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(tempDirectory);

        try
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Oag",
                "--targetFramework", targetFramework,
                "--output", tempDirectory);

            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            if (assertGeneratedOutput != null)
            {
                await assertGeneratedOutput(tempDirectory);
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

        foreach (var argument in arguments)
        {
            process.StartInfo.ArgumentList.Add(argument);
        }

        process.Start();

        var standardOutputTask = process.StandardOutput.ReadToEndAsync();
        var standardErrorTask = process.StandardError.ReadToEndAsync();

        await process.WaitForExitAsync();

        return
        (
            process.ExitCode,
            await standardOutputTask,
            await standardErrorTask
        );
    }

    private static void TryDeleteDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            return;
        }

        try
        {
            Directory.Delete(path, recursive: true);
        }
        catch (IOException)
        {
        }
        catch (UnauthorizedAccessException)
        {
        }
    }
}
