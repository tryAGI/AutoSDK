using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliServerRoutingTests
{
    [TestMethod]
    public async Task Generate_MixedServers_RoutesInheritedAndScopedTagClientsWithoutSharedBaseAddressMutation()
    {
        var directory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(directory);
        try
        {
            var repository = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
            var spec = Path.Combine(directory, "routing.yaml");
            await File.WriteAllTextAsync(spec, """
openapi: 3.0.3
info:
  title: Mixed Server Routing
  version: 1.0.0
servers:
  - url: https://api.example.com/v1
paths:
  /search:
    get:
      operationId: search
      responses:
        '204':
          description: OK
  /agent/runs:
    get:
      operationId: listRuns
      tags: [agent]
      responses:
        '204':
          description: OK
  /v0/websets:
    servers:
      - url: https://api.example.com/websets
    get:
      operationId: listWebsets
      tags: [websets]
      responses:
        '204':
          description: OK
  /reports:
    get:
      operationId: listReports
      tags: [reports]
      servers:
        - url: https://admin.example.com/v2
      responses:
        '204':
          description: OK
  /status:
    servers:
      - url: https://api.example.com/websets
    get:
      operationId: getStatus
      tags: [status]
      servers:
        - url: https://status.example.com/v3
      responses:
        '204':
          description: OK
""");
            var generation = await RunDotnetAsync(repository,
                "run", "--disable-build-servers", "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI", "--",
                "generate", spec, "--namespace", "Routing", "--clientClassName", "ApiClient",
                "--targetFramework", "net10.0", "--output", Path.Combine(directory, "Generated"));
            generation.ExitCode.Should().Be(0, generation.Output);

            await File.WriteAllTextAsync(Path.Combine(directory, "Consumer.csproj"), """
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
  </PropertyGroup>
</Project>
""");
            await File.WriteAllTextAsync(Path.Combine(directory, "Program.cs"), """
using System.Net;
using Routing;

// Alternate inherited defaults and scoped servers on the same HttpClient.
using (var handler = new RecordingHandler())
using (var http = new HttpClient(handler))
using (var client = new ApiClient(httpClient: http))
{
    await client.Agent.ListRunsAsync();
    await client.Websets.ListWebsetsAsync();
    await client.SearchAsync();
    await client.Reports.ListReportsAsync();
    await client.Status.GetStatusAsync();
    await client.Agent.ListRunsAsync();
    handler.AssertUrls(
        "https://api.example.com/v1/agent/runs",
        "https://api.example.com/websets/v0/websets",
        "https://api.example.com/v1/search",
        "https://admin.example.com/v2/reports",
        "https://status.example.com/v3/status",
        "https://api.example.com/v1/agent/runs");
    if (http.BaseAddress is not null)
        throw new InvalidOperationException("Generated defaults must not mutate shared HttpClient.BaseAddress.");

    // Choosing another root server must not reroute an operation that does not support it.
    var websets = client.AvailableServers.Single(server => server.Url == "https://api.example.com/websets");
    if (!client.TrySelectServer(websets.Id))
        throw new InvalidOperationException("Could not select the Websets server.");
    await client.Agent.ListRunsAsync();
    await client.Websets.ListWebsetsAsync();
    handler.AssertUrls("https://api.example.com/v1/agent/runs", "https://api.example.com/websets/v0/websets");
}

// Standalone tag clients must also inherit the document server.
using (var handler = new RecordingHandler())
using (var http = new HttpClient(handler))
using (var client = new AgentClient(httpClient: http))
{
    await client.ListRunsAsync();
    handler.AssertUrls("https://api.example.com/v1/agent/runs");
    if (http.BaseAddress is not null)
        throw new InvalidOperationException("Standalone tag client changed the shared base address.");
}

foreach (var useHttpClientBaseAddress in new[] { false, true })
{
    using var handler = new RecordingHandler();
    using var http = new HttpClient(handler);
    var proxy = new Uri("https://proxy.example/gateway/");
    if (useHttpClientBaseAddress) http.BaseAddress = proxy;
    using var client = new ApiClient(httpClient: http, baseUri: useHttpClientBaseAddress ? null : proxy);
    await client.Agent.ListRunsAsync();
    await client.Websets.ListWebsetsAsync();
    await client.Reports.ListReportsAsync();
    await client.Status.GetStatusAsync();
    handler.AssertUrls(
        "https://proxy.example/gateway/agent/runs",
        "https://proxy.example/gateway/v0/websets",
        "https://proxy.example/gateway/reports",
        "https://proxy.example/gateway/status");
}
Console.WriteLine("Mixed-server routing passed.");

sealed class RecordingHandler : HttpMessageHandler
{
    private readonly List<string> urls = [];

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        urls.Add(request.RequestUri!.AbsoluteUri);
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NoContent));
    }

    public void AssertUrls(params string[] expected)
    {
        if (!urls.SequenceEqual(expected))
            throw new InvalidOperationException($"Expected {string.Join(", ", expected)}; got {string.Join(", ", urls)}");
        urls.Clear();
    }
}
""");
            var consumer = await RunDotnetAsync(directory,
                "run", "--disable-build-servers", "--project", "Consumer.csproj");
            consumer.ExitCode.Should().Be(0, consumer.Output);
            consumer.Output.Should().Contain("Mixed-server routing passed.");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    private static async Task<(int ExitCode, string Output)> RunDotnetAsync(string directory, params string[] arguments)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = directory,
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
        return (process.ExitCode, await stdout + await stderr);
    }
}
