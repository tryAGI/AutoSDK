using System.Diagnostics;
using System.Text;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliOperationSelectionTests
{
    [TestMethod]
    public async Task Generate_SelectedLargeProfile_BuildsTrimsAndRunsWithoutUnrelatedModels()
    {
        var directory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var outputDirectory = Path.Combine(directory, "sdk");
        Directory.CreateDirectory(outputDirectory);

        try
        {
            var specPath = Path.Combine(directory, "multi-tag.yaml");
            await File.WriteAllTextAsync(specPath, CreateLargeSpec());
            var repositoryDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));

            var generate = await RunDotnetAsync(
                repositoryDirectory,
                "run", "--disable-build-servers", "--no-launch-profile", "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath, "--namespace", "Oag", "--clientClassName", "SelectedClient",
                "--targetFramework", "net10.0", "--output", outputDirectory,
                "--include-path", "/selected", "--include-operation-id", "getSelected",
                "--include-tag", "selected", "--exclude-tag", "noise");
            generate.ExitCode.Should().Be(0, generate.StandardError);

            var files = Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                .Select(Path.GetFileName)
                .ToArray();
            files.Should().Contain(name => name!.Contains("SelectedResponse", StringComparison.Ordinal));
            files.Should().Contain(name => name!.Contains("SharedModel", StringComparison.Ordinal));
            files.Should().NotContain(name => name!.Contains("Noise", StringComparison.Ordinal));
            files.Should().NotContain(name => name!.Contains("Archive", StringComparison.Ordinal));

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "Program.cs"), """
using System.Net;
using System.Text;
using Oag;

using var http = new HttpClient(new StubHandler());
using var client = new SelectedClient(http, disposeHttpClient: false);
var response = await client.GetSelectedAsync();
Console.WriteLine(response.Shared?.Value);
Console.WriteLine(SelectedResponse.FromJson("{\"shared\":{\"value\":\"ok\"}}")?.ToJson());

sealed class StubHandler : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Method != HttpMethod.Get || request.RequestUri?.AbsolutePath != "/selected")
        {
            throw new InvalidOperationException("Unexpected request: " + request.RequestUri);
        }

        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("{\"shared\":{\"value\":\"ok\"}}", Encoding.UTF8, "application/json"),
        });
    }
}
""");
            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "Oag.csproj"), """
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

            var build = await RunDotnetAsync(outputDirectory, "build", "Oag.csproj", "-c", "Release", "--disable-build-servers");
            build.ExitCode.Should().Be(0, build.StandardError);

            var publishDirectory = Path.Combine(directory, "publish");
            var publish = await RunDotnetAsync(
                outputDirectory, "publish", "Oag.csproj", "-c", "Release", "--disable-build-servers",
                "-p:PublishTrimmed=true", "-p:TrimMode=full", "-p:SelfContained=true", "-o", publishDirectory);
            publish.ExitCode.Should().Be(0, publish.StandardError);

            var run = await RunDotnetAsync(publishDirectory, "Oag.dll");
            run.ExitCode.Should().Be(0, run.StandardError);
            run.StandardOutput.Should().Contain("ok");
            run.StandardOutput.Should().Contain("\"shared\":{\"value\":\"ok\"}");
        }
        finally
        {
            if (Directory.Exists(directory))
            {
                Directory.Delete(directory, recursive: true);
            }
        }
    }

    private static string CreateLargeSpec()
    {
        var builder = new StringBuilder("""
openapi: 3.0.3
info:
  title: Multi-tag profile
  version: 1.0.0
servers:
  - url: https://example.test
paths:
  /selected:
    get:
      operationId: getSelected
      tags: [selected]
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/SelectedResponse'
""");
        builder.AppendLine();
        foreach (var prefix in new[] { "noise", "archive" })
        {
            for (var index = 0; index < 40; index++)
            {
                builder.AppendLine($"  /{prefix}/{index}:");
                builder.AppendLine("    get:");
                builder.AppendLine($"      operationId: get{prefix}{index}");
                builder.AppendLine($"      tags: [{prefix}]");
                builder.AppendLine("      responses:");
                builder.AppendLine("        '200':");
                builder.AppendLine("          description: OK");
                builder.AppendLine("          content:");
                builder.AppendLine("            application/json:");
                builder.AppendLine("              schema:");
                builder.AppendLine($"                $ref: '#/components/schemas/{prefix}{index}'");
            }
        }

        builder.AppendLine("components:");
        builder.AppendLine("  schemas:");
        builder.AppendLine("    SelectedResponse:");
        builder.AppendLine("      type: object");
        builder.AppendLine("      properties:");
        builder.AppendLine("        shared:");
        builder.AppendLine("          $ref: '#/components/schemas/SharedModel'");
        builder.AppendLine("    SharedModel:");
        builder.AppendLine("      type: object");
        builder.AppendLine("      properties:");
        builder.AppendLine("        value:");
        builder.AppendLine("          type: string");
        foreach (var prefix in new[] { "noise", "archive" })
        {
            for (var index = 0; index < 40; index++)
            {
                builder.AppendLine($"    {prefix}{index}:");
                builder.AppendLine("      type: object");
                builder.AppendLine("      properties:");
                builder.AppendLine("        shared:");
                builder.AppendLine("          $ref: '#/components/schemas/SharedModel'");
            }
        }

        return builder.ToString();
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
        var standardOutput = process.StandardOutput.ReadToEndAsync();
        var standardError = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();
        return (process.ExitCode, await standardOutput, await standardError);
    }
}
