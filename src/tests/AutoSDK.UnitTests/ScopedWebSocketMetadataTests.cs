using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Packaging;

namespace AutoSDK.UnitTests;

[TestClass]
public class ScopedWebSocketMetadataTests
{
    private const string Spec = """
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
    public void Pipeline_UsesPerMessageAndAnyEventScopesWithoutEagerAggregateInitialization()
    {
        var settings = Settings.Default with
        {
            Namespace = "ScopedEvents",
            FromCli = true,
            UseSharedJsonMetadata = true,
            JsonSerializerContext = "ScopedEvents.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
        };
        var data = AsyncApiData.Prepare(((Spec, settings), settings));
        var plan = SerializerContextPlan.Create(data);
        var files = CSharpPipeline.GenerateFiles(data);
        var client = data.WebSocketClients.Single();
        var send = data.WebSocketOperations.Single(static operation => operation.Direction == WebSocketDirection.Send);
        files.Single(file => file.Name == send.FileNameWithoutExtension + ".g.cs").Text.Should()
            .Contain("JsonSerializerContextProvider?.Value ?? global::" +
                plan.ModelContexts[send.MessageType.CSharpTypeWithoutNullability] + ".Default");
        var receive = files.Single(static file => file.Name.EndsWith(".ReceiveUpdates.g.cs", StringComparison.Ordinal));
        receive.Text.Should().Contain("JsonSerializerContextProvider?.Value ?? global::" +
            plan.ModelContexts[client.BaseReceiveEventType.CSharpTypeWithoutNullability] + ".Default");
        foreach (var operation in client.ReceiveOperations)
        {
            files.Single(file => file.Name.EndsWith(".Deserialize" + operation.MessageName + "Message.g.cs", StringComparison.Ordinal))
                .Text.Should().Contain("JsonSerializerContextProvider?.Value ?? global::" +
                    plan.ModelContexts[operation.MessageType.CSharpTypeWithoutNullability] + ".Default");
        }
        var constructor = files.Single(file => file.Name == client.FileNameWithoutExtension + ".g.cs");
        constructor.Text.Should().Contain("get => JsonSerializerContextProvider?.Value ??")
            .And.NotContain("JsonSerializerContext { get; set; } =");
    }

    [TestMethod]
    public void Pipeline_TypedParserNamesDisambiguateNormalizedMessageCollisions()
    {
        var settings = Settings.Default with
        {
            Namespace = "ScopedEvents", FromCli = true, UseSharedJsonMetadata = true,
            JsonSerializerContext = "ScopedEvents.SourceGenerationContext", GenerateJsonSerializerContextTypes = true,
        };
        var spec = Spec.Replace("      Done:\n", "      delta:\n", StringComparison.Ordinal)
            .Replace("#/channels/realtime/messages/Done", "#/channels/realtime/messages/delta", StringComparison.Ordinal);
        var data = AsyncApiData.Prepare(((spec, settings), settings));
        var files = CSharpPipeline.GenerateFiles(data).Where(static file =>
            file.Name.Contains(".DeserializeDeltaMessage_", StringComparison.Ordinal)).ToArray();
        files.Should().HaveCount(2);
        files.Select(static file => file.Name).Should().OnlyHaveUniqueItems();
        string.Join("\n", files.Select(static file => file.Text)).Should()
            .Contain("typeof(global::ScopedEvents.Delta)").And.Contain("typeof(global::ScopedEvents.Done)");
    }

    [TestMethod]
    public void Pipeline_OrdinaryAsyncApiKeepsItsExistingContextSurface()
    {
        var settings = Settings.Default with { Namespace = "ScopedEvents", FromCli = true };
        var data = AsyncApiData.Prepare(((Spec, settings), settings));
        CSharpPipeline.GenerateFiles(data).Should().NotContain(static file =>
            file.Name.EndsWith("Message.g.cs", StringComparison.Ordinal) &&
            file.Name.Contains(".Deserialize", StringComparison.Ordinal));
    }
}
