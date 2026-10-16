using System.Diagnostics;
using System.Text.Json;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliTaggedContextIdentityTests
{
    [TestMethod]
    public async Task Generate_OverlappingTagsWithDistinctRootContexts_BuildsAndRunsWithoutReflection()
    {
        var directory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(directory);
        try
        {
            var repository = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
            var spec = Path.Combine(directory, "spec.json");
            // Each tag reaches a small independent graph, so leaf contexts are actually emitted.
            await File.WriteAllTextAsync(spec, JsonSerializer.Serialize(new
            {
                openapi = "3.0.3",
                info = new { title = "Overlapping tags", version = "1.0.0" },
                paths = Enumerable.Range(0, 8).ToDictionary(i => $"/items{i}", i => new
                {
                    get = new
                    {
                        operationId = $"getItem{i}",
                        tags = new[] { $"items{i}" },
                        responses = new Dictionary<string, object>
                        {
                            ["200"] = new
                            {
                                description = "OK",
                                content = new Dictionary<string, object>
                                {
                                    ["application/json"] = new
                                    {
                                        schema = new Dictionary<string, string>
                                        {
                                            ["$ref"] = $"#/components/schemas/Item{i}",
                                        },
                                    },
                                },
                            },
                        },
                    },
                }),
                components = new
                {
                    schemas = Enumerable.Range(0, 8).ToDictionary(i => $"Item{i}", _ => new
                    {
                        type = "object",
                        properties = new { id = new { type = "string" } },
                    }),
                },
            }));

            foreach (var (ns, context) in new[]
                     {
                         ("Fixture", "SourceGenerationContext"),
                         ("Fixture.V2", "V2SourceGenerationContext"),
                     })
            {
                var generation = await RunDotnetAsync(repository,
                    "run", "--disable-build-servers", "--no-launch-profile",
                    "--project", "src/libs/AutoSDK.CLI", "--",
                    "generate", spec, "--namespace", ns, "--clientClassName", "ApiClient",
                    "--json-serializer-context", context, "--targetFramework", "net10.0",
                    "--output", Path.Combine(directory, ns));
                generation.ExitCode.Should().Be(0, generation.StandardOutput + generation.StandardError);
            }

            await File.WriteAllTextAsync(Path.Combine(directory, "Consumer.csproj"), """
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>
</Project>
""");
            await File.WriteAllTextAsync(Path.Combine(directory, "Program.cs"), """
using System.Text.Json;
using Fixture;
using Fixture.V2;

Check(Fixture.Items0SourceGenerationContext.Default, typeof(Fixture.Item0));
Check(Fixture.V2.V2SourceGenerationContext_Items0.Default, typeof(Fixture.V2.Item0));
Check(Fixture.SourceGenerationContext.Default, typeof(Fixture.Item0));
Check(Fixture.V2.V2SourceGenerationContext.Default, typeof(Fixture.V2.Item0));
if (Fixture.Item0.FromJson(new Fixture.Item0 { Id = "v1" }.ToJson())?.Id != "v1" ||
    Fixture.V2.Item0.FromJson(new Fixture.V2.Item0 { Id = "v2" }.ToJson())?.Id != "v2")
{
    throw new InvalidOperationException("Model JSON helper round trip failed.");
}
using var v1 = new Fixture.Items0Client(baseUri: new Uri("http://localhost"));
using var v2 = new Fixture.V2.Items0Client(baseUri: new Uri("http://localhost"));
if (v1.JsonSerializerContext is not Fixture.Items0SourceGenerationContext ||
    v2.JsonSerializerContext is not Fixture.V2.V2SourceGenerationContext_Items0)
{
    throw new InvalidOperationException("Leaf clients did not use their own contexts.");
}
Console.WriteLine("Both tagged API generations work without reflection.");

static void Check(System.Text.Json.Serialization.JsonSerializerContext context, Type type)
{
    var info = context.GetTypeInfo(type) ?? throw new InvalidOperationException(type.FullName);
    var value = JsonSerializer.Deserialize("{\"id\":\"ok\"}", info);
    if (JsonSerializer.Serialize(value, info) != "{\"id\":\"ok\"}")
    {
        throw new InvalidOperationException("Context round trip failed.");
    }
}
""");
            var run = await RunDotnetAsync(directory, "run", "--disable-build-servers", "--project", "Consumer.csproj");
            run.ExitCode.Should().Be(0, run.StandardOutput + run.StandardError);
            run.StandardOutput.Should().Contain("Both tagged API generations work without reflection.");

            var publishDirectory = Path.Combine(directory, "native");
            var publish = await RunDotnetAsync(directory,
                "publish", "Consumer.csproj", "--disable-build-servers", "-c", "Release",
                "-p:PublishAot=true", "-p:ILLinkTreatWarningsAsErrors=true", "-o", publishDirectory);
            publish.ExitCode.Should().Be(0, publish.StandardOutput + publish.StandardError);
            var executable = Path.Combine(publishDirectory, OperatingSystem.IsWindows() ? "Consumer.exe" : "Consumer");
            var nativeRun = await RunProcessAsync(executable, directory);
            nativeRun.ExitCode.Should().Be(0, nativeRun.StandardOutput + nativeRun.StandardError);
            nativeRun.StandardOutput.Should().Contain("Both tagged API generations work without reflection.");
        }
        finally
        {
            TryDeleteDirectory(directory);
        }
    }

    private static async Task<(int ExitCode, string StandardOutput, string StandardError)> RunDotnetAsync(
        string workingDirectory,
        params string[] arguments)
    {
        return await RunProcessAsync("dotnet", workingDirectory, arguments);
    }

    private static async Task<(int ExitCode, string StandardOutput, string StandardError)> RunProcessAsync(
        string executable,
        string workingDirectory,
        params string[] arguments)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo(executable)
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
