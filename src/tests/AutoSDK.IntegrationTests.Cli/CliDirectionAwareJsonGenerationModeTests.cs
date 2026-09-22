using System.Diagnostics;
using System.Text;

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
        // fast-path serialization for the whole context. A single context mode covers all types.
        narrowed.Context.Should().Contain("GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,");
        narrowed.Context.Should().Contain("JsonSerializable(typeof(global::Oag.CreateItemRequest))");
        narrowed.Context.Should().Contain("JsonSerializable(typeof(global::Oag.ItemResponse))");
        narrowed.Context.Should().NotContain("JsonSerializable(typeof(global::Oag.ItemResponse), GenerationMode");
        narrowed.Context.Should().NotContain("JsonSourceGenerationMode.Serialization");
        narrowed.Context.Should().Contain("JsonSerializable(typeof(global::Oag.JsonSerializerContextTypes))");

        narrowed.Output.Should().Be(baseline.Output);
        narrowed.Output.Should().Contain("\"name\":\"abc\"");
        narrowed.Output.Should().Contain("\"id\":\"42\"");
        narrowed.Output.Should().Contain("\"value\":\"v\"");

        baseline.GenerateOutput.Should().NotContain("Direction-aware JSON generation modes:");
        narrowed.GenerateOutput.Should().Contain("Direction-aware JSON generation modes:");
        narrowed.GenerateOutput.Should().Contain("request-only");
        narrowed.GenerateOutput.Should().Contain("response-only");
        narrowed.GenerateOutput.Should().Contain("bidirectional");
    }

    [TestMethod]
    public async Task Generate_LargeDirectionalGraph_DoesNotInflateReleaseOrTrimmedAssemblies()
    {
        var spec = CreateLargeDirectionalSpec(modelsPerDirection: 80);
        var baseline = await MeasureAssemblySizesAsync(spec, directionAware: false);
        var narrowed = await MeasureAssemblySizesAsync(spec, directionAware: true);

        Console.WriteLine($"Direction-aware Release Oag.dll: {baseline.ReleaseSize:N0} -> {narrowed.ReleaseSize:N0} bytes");
        Console.WriteLine($"Direction-aware fully trimmed Oag.dll: {baseline.TrimmedSize:N0} -> {narrowed.TrimmedSize:N0} bytes");

        narrowed.ReleaseSize.Should().BeLessThanOrEqualTo(
            (long)(baseline.ReleaseSize * 1.02),
            "direction-aware mode must not materially enlarge a clean Release assembly");
        narrowed.TrimmedSize.Should().BeLessThanOrEqualTo(
            (long)(baseline.TrimmedSize * 1.02),
            "direction-aware mode must not materially enlarge a fully trimmed consumer");
        narrowed.Output.Should().Be(baseline.Output);
    }

    private static string CreateLargeDirectionalSpec(int modelsPerDirection)
    {
        var builder = new StringBuilder(Spec
            .Replace("        name:\n          type: string", "        name:\n          type: string\n        next:\n          $ref: '#/components/schemas/Request0'", StringComparison.Ordinal)
            .Replace("        id:\n          type: string", "        id:\n          type: string\n        next:\n          $ref: '#/components/schemas/Response0'", StringComparison.Ordinal)
            .Replace("        value:\n          type: string", "        value:\n          type: string\n        next:\n          $ref: '#/components/schemas/Shared0'", StringComparison.Ordinal));
        builder.AppendLine();

        foreach (var prefix in new[] { "Request", "Response", "Shared" })
        {
            for (var index = 0; index < modelsPerDirection; index++)
            {
                builder.AppendLine($"    {prefix}{index}:");
                builder.AppendLine("      type: object");
                builder.AppendLine("      properties:");
                builder.AppendLine("        value:");
                builder.AppendLine("          type: string");
                if (index + 1 < modelsPerDirection)
                {
                    builder.AppendLine("        next:");
                    builder.AppendLine($"          $ref: '#/components/schemas/{prefix}{index + 1}'");
                }
            }
        }

        return builder.ToString();
    }

    private static async Task<(long ReleaseSize, long TrimmedSize, string Output)> MeasureAssemblySizesAsync(
        string spec,
        bool directionAware)
    {
        var directory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(directory);

        try
        {
            var specPath = Path.Combine(directory, "large-directional.yaml");
            var projectDirectory = Path.Combine(directory, "sdk");
            Directory.CreateDirectory(projectDirectory);
            await File.WriteAllTextAsync(specPath, spec);

            var repositoryDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
            var arguments = new List<string>
            {
                "run", "--disable-build-servers", "--no-launch-profile", "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath, "--namespace", "Oag", "--targetFramework", "net10.0",
                "--output", projectDirectory,
            };
            if (directionAware)
            {
                arguments.Add("--direction-aware-json-generation-mode");
            }

            var generate = await RunDotnetAsync(repositoryDirectory, arguments.ToArray());
            generate.ExitCode.Should().Be(0, generate.StandardError);

            await File.WriteAllTextAsync(Path.Combine(projectDirectory, "Program.cs"), Program);
            await File.WriteAllTextAsync(Path.Combine(projectDirectory, "Oag.csproj"), """
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <LangVersion>preview</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <IsTrimmable>true</IsTrimmable>
  </PropertyGroup>
</Project>
""");

            var build = await RunDotnetAsync(projectDirectory, "build", "Oag.csproj", "-c", "Release", "--disable-build-servers");
            build.ExitCode.Should().Be(0, build.StandardError);
            var releaseSize = new FileInfo(Path.Combine(projectDirectory, "bin", "Release", "net10.0", "Oag.dll")).Length;

            var publishDirectory = Path.Combine(directory, "publish");
            var publish = await RunDotnetAsync(
                projectDirectory,
                "publish", "Oag.csproj", "-c", "Release", "--disable-build-servers",
                "-p:PublishTrimmed=true", "-p:TrimMode=full", "-p:SelfContained=true",
                "-o", publishDirectory);
            publish.ExitCode.Should().Be(0, publish.StandardError);
            var trimmedSize = new FileInfo(Path.Combine(publishDirectory, "Oag.dll")).Length;

            var run = await RunDotnetAsync(publishDirectory, "Oag.dll");
            run.ExitCode.Should().Be(0, run.StandardError);
            return (releaseSize, trimmedSize, run.StandardOutput.Replace("\r\n", "\n", StringComparison.Ordinal));
        }
        finally
        {
            TryDeleteDirectory(directory);
        }
    }

    private static async Task<(string Context, string Output, string GenerateOutput)> GenerateRunAndReadAsync(bool directionAware)
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

            return (
                context,
                runResult.StandardOutput.Replace("\r\n", "\n", StringComparison.Ordinal),
                generateResult.StandardOutput);
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
