using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliCompositeObjectConverterTests
{
    [TestMethod]
    public async Task Generate_WithObjectAnyOfAndAllOf_UsesNullableTypeInfo_AndBuilds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: composite
  version: 1.0.0
paths:
  /payload:
    post:
      operationId: createPayload
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/Payload'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Payload'
components:
  schemas:
    ObjectA:
      type: object
      properties:
        a:
          type: string
    ObjectB:
      type: object
      properties:
        b:
          type: string
    AllOfA:
      type: object
      properties:
        id:
          type: string
    AllOfB:
      type: object
      properties:
        meta:
          type: string
    Payload:
      type: object
      properties:
        choice:
          anyOf:
            - $ref: '#/components/schemas/ObjectA'
            - $ref: '#/components/schemas/ObjectB'
        merged:
          allOf:
            - $ref: '#/components/schemas/AllOfA'
            - $ref: '#/components/schemas/AllOfB'
""";

        await GenerateFromContentAsync(
            fileName: "composite-object-converters.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var anyOfConverter = await File.ReadAllTextAsync(Path.Combine(outputDirectory, "Oag.JsonConverters.AnyOf2.g.cs"));
                var allOfConverter = await File.ReadAllTextAsync(Path.Combine(outputDirectory, "Oag.JsonConverters.AllOf2.g.cs"));

                anyOfConverter.Should().Contain("JsonTypeInfo<T1?>");
                anyOfConverter.Should().Contain("JsonTypeInfo<T2?>");
                allOfConverter.Should().Contain("JsonTypeInfo<T1?>");
                allOfConverter.Should().Contain("JsonTypeInfo<T2?>");
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
