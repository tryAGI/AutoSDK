using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliPrimitiveResponseDeserializationTests
{
    [TestMethod]
    public async Task Generate_WithEnumAndPrimitiveResponses_UsesSerializerDeserialization_AndBuilds()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: PrimitiveResponses
  version: 1.0.0
paths:
  /status-inline:
    get:
      operationId: getInlineStatus
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: string
                enum: [queued, running, done]
  /status-ref:
    get:
      operationId: getReferencedStatus
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/JobStatus'
  /status-vendor:
    get:
      operationId: getVendorStatus
      responses:
        '200':
          description: ok
          content:
            application/vnd.cvat+json:
              schema:
                type: string
                enum: [queued, running, done]
  /flag:
    get:
      operationId: getFlag
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                type: boolean
  /payload:
    get:
      operationId: getPayload
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Payload'
components:
  schemas:
    JobStatus:
      type: string
      enum: [queued, running, done]
    Payload:
      type: object
      properties:
        ok:
          type: boolean
""";

        await GenerateFromContentAsync(
            fileName: "primitive-responses.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().NotContain("GetInlineStatusResponse.FromJson(");
                content.Should().NotContain("JobStatus.FromJson(");
                content.Should().NotContain("GetVendorStatusResponse.FromJson(");
                content.Should().NotContain("GetInlineStatusResponse.FromJsonStreamAsync(");
                content.Should().NotContain("JobStatus.FromJsonStreamAsync(");
                content.Should().NotContain("GetVendorStatusResponse.FromJsonStreamAsync(");
                content.Should().Contain("global::System.Text.Json.JsonSerializer.Deserialize(");
                content.Should().Contain("global::Oag.Payload.FromJson(");
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
