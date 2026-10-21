using System.Runtime.InteropServices;

namespace AutoSDK.IntegrationTests;

public partial class CliTests
{
    private const string ScopedWebSocketSpec = """
asyncapi: 3.0.0
info:
  title: Scoped events
  version: 1.0.0
servers:
  production:
    host: example.com
    protocol: wss
channels:
  realtime:
    address: /realtime
    messages:
      Ping:
        payload:
          $ref: '#/components/schemas/Ping'
      Delta:
        payload:
          $ref: '#/components/schemas/Delta'
      Done:
        payload:
          $ref: '#/components/schemas/Done'
operations:
  sendPing:
    action: send
    channel:
      $ref: '#/channels/realtime'
    messages:
      - $ref: '#/channels/realtime/messages/Ping'
  receiveDelta:
    action: receive
    channel:
      $ref: '#/channels/realtime'
    messages:
      - $ref: '#/channels/realtime/messages/Delta'
  receiveDone:
    action: receive
    channel:
      $ref: '#/channels/realtime'
    messages:
      - $ref: '#/channels/realtime/messages/Done'
components:
  schemas:
    Ping:
      type: object
      properties:
        type:
          type: string
          const: ping
        text:
          type: string
    Delta:
      type: object
      properties:
        type:
          type: string
          const: delta
        text:
          type: string
    Done:
      type: object
      properties:
        type:
          type: string
          const: done
        count:
          type: integer
""";

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task Generate_SharedWebSocketScopes_TrimAndNativeAotPreserveOfflineContracts(bool nativeAot)
    {
        await GenerateFromContentAsync("scoped-asyncapi.yaml", ScopedWebSocketSpec,
            targetFramework: "net10.0", additionalArguments: ["--shared-json-metadata", "--websocket-class-name", "RealtimeClient"],
            assertBuiltOutput: async directory =>
            {
                var projectPath = Path.Combine(directory, "Oag.csproj");
                var project = (await File.ReadAllTextAsync(projectPath)).Replace("</Project>",
                    "<PropertyGroup><IsTrimmable>true</IsTrimmable></PropertyGroup><ItemGroup><Compile Remove=\"Consumers/**/*.cs\" /></ItemGroup></Project>",
                    StringComparison.Ordinal);
                await File.WriteAllTextAsync(projectPath, project);
                await File.WriteAllTextAsync(Path.Combine(directory, "ConfiguredContext.cs"), """
namespace Oag;
public sealed partial class SourceGenerationContext
{
    /// <summary>Creates a configured context for this test.</summary>
    public static SourceGenerationContext ConfiguredForTests()
    {
        var options = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true, TypeInfoResolver = TypeInfoResolver };
        AddConverters(options);
        return new(options);
    }
}
""");
                foreach (var mode in new[] { "typed", "send", "union", "custom" })
                {
                    var consumer = Path.Combine(directory, "Consumers", mode);
                    Directory.CreateDirectory(consumer);
                    await File.WriteAllTextAsync(Path.Combine(consumer, "Probe.csproj"), $$"""
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup>
<TargetFramework>net10.0</TargetFramework><OutputType>Exe</OutputType><ImplicitUsings>enable</ImplicitUsings>
<Nullable>enable</Nullable><TreatWarningsAsErrors>true</TreatWarningsAsErrors>
<PublishTrimmed>true</PublishTrimmed><TrimMode>full</TrimMode><SelfContained>true</SelfContained>
<PublishAot>{{nativeAot.ToString().ToLowerInvariant()}}</PublishAot><DefineConstants>{{mode.ToUpperInvariant()}}</DefineConstants>
<PublishReadyToRun>false</PublishReadyToRun><TrimmerSingleWarn>false</TrimmerSingleWarn>
<JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
</PropertyGroup>
<ItemGroup><ProjectReference Include="../../Oag.csproj" /></ItemGroup>
</Project>
""");
                    await File.WriteAllTextAsync(Path.Combine(consumer, "Program.cs"),
                        ScopedWebSocketProgram.Replace("__MODE__", mode, StringComparison.Ordinal));
                    var publish = Path.Combine(consumer, "publish");
                    var result = await RunDotnetAsync(consumer, "publish", "Probe.csproj", "-c", "Release",
                        "-r", RuntimeInformation.RuntimeIdentifier, "-o", publish);
                    result.ExitCode.Should().Be(0, result.StandardOutput + result.StandardError);
                    var run = await RunProcessAsync(Path.Combine(publish, OperatingSystem.IsWindows() ? "Probe.exe" : "Probe"), publish);
                    run.ExitCode.Should().Be(0, run.StandardOutput + run.StandardError);
                    run.StandardOutput.Should().Contain("scoped-websocket-contract-passed");
                    if (!nativeAot && mode is "typed" or "send")
                    {
                        using var stream = File.OpenRead(Path.Combine(publish, "Oag.dll"));
                        using var image = new System.Reflection.PortableExecutable.PEReader(stream);
                        var metadata = System.Reflection.Metadata.PEReaderExtensions.GetMetadataReader(image);
                        var methods = metadata.MethodDefinitions.Select(handle =>
                            metadata.GetString(metadata.GetMethodDefinition(handle).Name)).ToArray();
                        methods.Should().NotContain(static name => name == "Create_Done");
                        if (mode == "typed") methods.Should().NotContain(static name => name == "Create_Ping");
                        else methods.Should().NotContain(static name => name == "Create_Delta");
                    }
                }
            });
    }

    private const string ScopedWebSocketProgram = """
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using Oag;

const string mode = "__MODE__";
using var deadline = new CancellationTokenSource(TimeSpan.FromSeconds(20));
using var client = new RealtimeClient();
#if UNION
var unknown = 0;
client.UnknownMessage += (_, _) => unknown++;
#endif
#if TYPED || CUSTOM
{
#if CUSTOM
    client.JsonSerializerContext = SourceGenerationContext.ConfiguredForTests();
#endif
    var json = mode == "custom" ? "{\"type\":\"delta\",\"TEXT\":\"custom\"}" : "{\"type\":\"delta\",\"text\":\"typed\"}";
    var model = client.DeserializeDeltaMessage(json);
    if (model.Text != mode) throw new InvalidOperationException("Typed or caller-provided context failed.");
}
#else
{
    var reservation = new TcpListener(IPAddress.Loopback, 0);
    reservation.Start();
    var port = ((IPEndPoint)reservation.LocalEndpoint).Port;
    reservation.Stop();
    using var listener = new HttpListener();
    listener.Prefixes.Add($"http://127.0.0.1:{port}/");
    listener.Start();
    var server = Task.Run(async () =>
    {
        var context = await listener.GetContextAsync().WaitAsync(deadline.Token);
        using var socket = (await context.AcceptWebSocketAsync(null)).WebSocket;
#if SEND
        {
            var buffer = new byte[1024];
            var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), deadline.Token);
            using var document = JsonDocument.Parse(buffer.AsMemory(0, result.Count));
            if (document.RootElement.GetProperty("text").GetString() != "outbound")
                throw new InvalidOperationException("Outbound message serialization failed.");
            return;
        }
#else
        foreach (var json in new[] { "{\"type\":\"delta\",\"text\":\"inbound\"}", "{\"type\":\"done\",\"count\":2}" })
            await socket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(json)), WebSocketMessageType.Text, true, deadline.Token);
        foreach (var json in new[] { "{\"type\":\"future\"}", "not-json" })
            await socket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(json)), WebSocketMessageType.Text, true, deadline.Token);
        await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "done", deadline.Token);
#endif
    }, deadline.Token);
    await client.ConnectAsync(uri: new Uri($"ws://127.0.0.1:{port}/"), cancellationToken: deadline.Token);
#if SEND
    await client.SendPingAsync(new Ping { Text = "outbound" }, deadline.Token);
#else
    {
        var messages = new List<string>();
        await foreach (var value in client.ReceiveUpdatesAsync(deadline.Token)) messages.Add(value.ToJson());
        if (unknown != 2 || messages.Count != 2 || !messages[0].Contains("inbound", StringComparison.Ordinal) ||
            !messages[1].Contains("done", StringComparison.Ordinal))
            throw new InvalidOperationException("Any-event union lost a variant.");
    }
#endif
    await server;
}
#endif
Console.WriteLine(mode + " scoped-websocket-contract-passed");
""";
}
