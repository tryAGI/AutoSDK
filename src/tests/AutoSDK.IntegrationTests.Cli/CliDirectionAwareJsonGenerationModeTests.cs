using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliDirectionAwareJsonGenerationModeTests
{
    private const string Spec = """
openapi: 3.0.3
info:
  title: DirectionAware
  version: 1.0.0
paths:
  /items:
    post:
      operationId: createItem
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/CreateItemRequest'
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/ItemResponse'
  /echo:
    post:
      operationId: echoItem
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/SharedModel'
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SharedModel'
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Status'
components:
  schemas:
    CreateItemRequest:
      type: object
      properties:
        payload:
          $ref: '#/components/schemas/RequestPayload'
    RequestPayload:
      type: object
      properties:
        name:
          type: string
    ItemResponse:
      type: object
      properties:
        items:
          type: array
          items:
            $ref: '#/components/schemas/ResponseItem'
    ResponseItem:
      type: object
      properties:
        id:
          type: string
    SharedModel:
      type: object
      properties:
        value:
          type: string
    Status:
      type: string
      enum: [ok, degraded]
""";

    private const string Program = """
using System;

var request = new Oag.CreateItemRequest
{
    Payload = new Oag.RequestPayload { Name = "abc" },
};
Console.WriteLine(request.ToJson());
Console.WriteLine(Oag.CreateItemRequest.FromJson(request.ToJson())!.ToJson());

var response = Oag.ItemResponse.FromJson("{\"items\":[{\"id\":\"42\"}]}")!;
Console.WriteLine(response.ToJson());

var shared = Oag.SharedModel.FromJson("{\"value\":\"v\"}")!;
Console.WriteLine(shared.ToJson());
""";

    [TestMethod]
    public async Task Generate_WithDirectionAwareJsonGenerationMode_NarrowsModesAndStaysWireCompatible()
    {
        var baseline = await GenerateRunAndReadAsync(directionAware: false);
        var narrowed = await GenerateRunAndReadAsync(directionAware: true);

        baseline.Context.Should().NotContain("GenerationMode");

        // Every generated SDK registers at least the unix timestamp converter, which turns off
        // fast-path serialization for the whole context, so single-direction types narrow to
        // Metadata rather than Serialization.
        narrowed.Context.Should().Contain(
            "JsonSerializable(typeof(global::Oag.CreateItemRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)");
        narrowed.Context.Should().Contain(
            "JsonSerializable(typeof(global::Oag.ItemResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)");
        narrowed.Context.Should().NotContain("JsonSourceGenerationMode.Serialization");
        narrowed.Context.Should().Contain("JsonSerializable(typeof(global::Oag.JsonSerializerContextTypes))");

        narrowed.Output.Should().Be(baseline.Output);
        narrowed.Output.Should().Contain("\"name\":\"abc\"");
        narrowed.Output.Should().Contain("\"id\":\"42\"");
        narrowed.Output.Should().Contain("\"value\":\"v\"");
    }

    private static async Task<(string Context, string Output)> GenerateRunAndReadAsync(bool directionAware)
    {
        var tempSpecDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(tempSpecDirectory);
        Directory.CreateDirectory(tempDirectory);

        var specPath = Path.Combine(tempSpecDirectory, "direction-aware.yaml");

        try
        {
            await File.WriteAllTextAsync(specPath, Spec);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var arguments = new List<string>
            {
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Oag",
                "--targetFramework", "net10.0",
                "--output", tempDirectory,
            };
            if (directionAware)
            {
                arguments.Add("--direction-aware-json-generation-mode");
            }

            var generateResult = await RunDotnetAsync(repositoryDirectory, arguments.ToArray());
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var contextPath = Directory
                .EnumerateFiles(tempDirectory, "*.JsonSerializerContext.g.cs", SearchOption.AllDirectories)
                .Single();
            var context = await File.ReadAllTextAsync(contextPath);

            await File.WriteAllTextAsync(Path.Combine(tempDirectory, "Program.cs"), Program);
            await File.WriteAllTextAsync(Path.Combine(tempDirectory, "Oag.csproj"), """
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <LangVersion>preview</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

</Project>
""");

            var runResult = await RunDotnetAsync(
                tempDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", Path.Combine(tempDirectory, "Oag.csproj"));

            Console.WriteLine(runResult.StandardOutput);
            Console.WriteLine(runResult.StandardError);
            runResult.ExitCode.Should().Be(0);

            return (context, runResult.StandardOutput.Replace("\r\n", "\n", StringComparison.Ordinal));
        }
        finally
        {
            TryDeleteDirectory(tempSpecDirectory);
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
            // Best effort cleanup.
        }
        catch (UnauthorizedAccessException)
        {
            // Best effort cleanup.
        }
    }
}
