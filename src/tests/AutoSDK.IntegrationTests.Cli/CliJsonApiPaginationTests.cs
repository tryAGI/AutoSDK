using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliJsonApiPaginationTests
{
    [TestMethod]
    public async Task Generate_JsonApiNextLinks_StreamsSafelyAndSurvivesTrimming()
    {
        var directory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var output = Path.Combine(directory, "sdk");
        Directory.CreateDirectory(output);
        try
        {
            var spec = Path.Combine(directory, "app-store-connect-style.yaml");
            await File.WriteAllTextAsync(spec, """
openapi: 3.0.3
info:
  title: App Store Connect style collections
  version: 1.0.0
servers:
  - url: https://api.example.test
paths:
  /v1/apps:
    get:
      operationId: listApps
      parameters:
        - name: filter[name]
          in: query
          schema:
            type: string
        - name: include
          in: query
          schema:
            type: string
        - name: limit
          in: query
          schema:
            type: integer
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/AppsPage'
components:
  schemas:
    AppsPage:
      type: object
      properties:
        data:
          type: array
          items:
            $ref: '#/components/schemas/App'
        links:
          $ref: '#/components/schemas/DocumentLinks'
    DocumentLinks:
      type: object
      properties:
        next:
          type: string
          format: uri
          nullable: true
    App:
      type: object
      properties:
        id:
          type: string
""");

            var repository = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
            var generate = await RunDotnetAsync(repository,
                "run", "--disable-build-servers", "--no-launch-profile", "--project", "src/libs/AutoSDK.CLI",
                "generate", spec, "--namespace", "Oag", "--clientClassName", "AppsClient",
                "--targetFramework", "net10.0", "--output", output, "--generate-pageable-helpers");
            generate.ExitCode.Should().Be(0, generate.StandardError);

            await File.WriteAllTextAsync(Path.Combine(output, "Oag.csproj"), """
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
            await File.WriteAllTextAsync(Path.Combine(output, "Program.cs"), """
using System.Net;
using Oag;

await RunCycle();
await RunCancellation();
await RunCrossOrigin();
Console.WriteLine("pagination-ok");

static async Task RunCycle()
{
    var handler = new StubHandler(Mode.Cycle);
    using var http = new HttpClient(handler) { BaseAddress = new Uri("https://api.example.test") };
    using var client = new AppsClient(http, disposeHttpClient: false);
    var options = new AutoSDKRequestOptions();
    options.Headers["X-Trace"] = "ok";
    options.QueryParameters["extra"] = "first-only";
    var ids = new List<string>();
    await foreach (var item in client.ListAppsAutoPagingAsync(
        filterName: "demo", include: "builds", limit: 1, requestOptions: options))
    {
        ids.Add(item.Id);
    }
    if (string.Join(",", ids) != "1,2,3" || handler.RequestCount != 3)
    {
        throw new Exception("Repeated next URL was fetched or items were lost.");
    }
}

static async Task RunCancellation()
{
    var handler = new StubHandler(Mode.Cycle);
    using var http = new HttpClient(handler) { BaseAddress = new Uri("https://api.example.test") };
    using var client = new AppsClient(http, disposeHttpClient: false);
    using var cancellation = new CancellationTokenSource();
    try
    {
        await foreach (var _ in client.ListAppsAutoPagingAsync(cancellationToken: cancellation.Token))
        {
            cancellation.Cancel();
        }
        throw new Exception("Cancellation was ignored.");
    }
    catch (OperationCanceledException) when (handler.RequestCount == 1)
    {
    }
}

static async Task RunCrossOrigin()
{
    var handler = new StubHandler(Mode.Foreign);
    using var http = new HttpClient(handler) { BaseAddress = new Uri("https://api.example.test") };
    using var client = new AppsClient(http, disposeHttpClient: false);
    try
    {
        await foreach (var _ in client.ListAppsAutoPagingAsync()) { }
        throw new Exception("Foreign next URL was followed.");
    }
    catch (InvalidOperationException) when (handler.RequestCount == 1)
    {
    }
}

enum Mode { Cycle, Foreign }

sealed class StubHandler(Mode mode) : HttpMessageHandler
{
    public int RequestCount { get; private set; }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        RequestCount++;
        var url = request.RequestUri ?? throw new Exception("Missing URL");
        if (url.Host != "api.example.test" || url.AbsolutePath != "/v1/apps")
        {
            throw new Exception("Unexpected URL: " + url);
        }
        if (mode == Mode.Cycle)
        {
            if (url.Query.Contains("extra=") &&
                (!request.Headers.TryGetValues("X-Trace", out var traceValues) || traceValues.FirstOrDefault() != "ok"))
            {
                throw new Exception("Request options header was dropped.");
            }
            if (RequestCount == 1 && url.Query.Contains("extra=") &&
                (!url.Query.Contains("include=builds") || !url.Query.Contains("extra=first-only")))
            {
                throw new Exception("Original filters were dropped.");
            }
            if (RequestCount > 1 && (url.Query.Contains("extra=") || url.Query.Contains("include=")))
            {
                throw new Exception("Original query parameters were appended to next URL.");
            }
        }

        var next = mode == Mode.Foreign
            ? "//evil.example.test/harvest"
            : RequestCount == 1
                ? "/v1/apps?cursor=one"
                : RequestCount == 2
                    ? "https://api.example.test/v1/apps?cursor=two"
                    : "/v1/apps?cursor=one";
        var body = "{\"data\":[{\"id\":\"" + RequestCount + "\"}],\"links\":{\"next\":\"" + next + "\"}}";
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(body, System.Text.Encoding.UTF8, "application/json"),
        });
    }
}
""");

            var build = await RunDotnetAsync(output, "build", "Oag.csproj", "-c", "Release", "--disable-build-servers");
            build.ExitCode.Should().Be(0, build.StandardError);
            var publishDirectory = Path.Combine(directory, "publish");
            var publish = await RunDotnetAsync(output,
                "publish", "Oag.csproj", "-c", "Release", "--disable-build-servers",
                "-p:PublishTrimmed=true", "-p:TrimMode=full", "-p:SelfContained=true", "-o", publishDirectory);
            publish.ExitCode.Should().Be(0, publish.StandardError);
            var run = await RunDotnetAsync(publishDirectory, "Oag.dll");
            run.ExitCode.Should().Be(0, run.StandardError);
            run.StandardOutput.Should().Contain("pagination-ok");
        }
        finally
        {
            if (Directory.Exists(directory))
            {
                Directory.Delete(directory, recursive: true);
            }
        }
    }

    private static async Task<(int ExitCode, string StandardOutput, string StandardError)> RunDotnetAsync(
        string workingDirectory, params string[] arguments)
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
        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();
        return (process.ExitCode, await stdout, await stderr);
    }
}
