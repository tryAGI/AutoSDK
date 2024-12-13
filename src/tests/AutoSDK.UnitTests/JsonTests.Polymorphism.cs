using System.Text.Json.Serialization;
using G;

namespace AutoSDK.UnitTests;

/// <summary>
/// https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism
/// </summary>
public partial class JsonTests
{
    [TestMethod]
    public void Polymorphism_Cohere_ChatStreamEvent()
    {
        var @event = new ChatStreamStartEvent
        {
            //EventType = ChatStreamEventEventType.StreamStart,
            GenerationId = Guid.Parse("ab1019d4-de22-471d-b31c-3066cae7d01c"),
        };
        var json = @event.ToJson(PolymorphismCohereChatStreamEventContext.Default);
        
        Console.WriteLine(json);

        json.Should().Be("""
                         {
                           "event_type": "stream-start",
                           "generation_id": "ab1019d4-de22-471d-b31c-3066cae7d01c"
                         }
                         """);
        
        var newEvent = ChatStreamEvent.FromJson<ChatStreamStartEvent>(json, PolymorphismCohereChatStreamEventContext.Default);

        newEvent.Should().NotBeNull();
        newEvent!.GenerationId.Should().Be(@event.GenerationId);
        
        var newJson = newEvent!.ToJson(PolymorphismCohereChatStreamEventContext.Default);
        
        newJson.Should().Be(json);
    }
    
    [TestMethod]
    public void Polymorphism_Cohere_ChatStreamEvent_IncorrectOrder()
    {
        const string json = 
            """
            {
              "generation_id": "ab1019d4-de22-471d-b31c-3066cae7d01c",
              "event_type": "stream-start"
            }
            """;
        
        var newEvent = ChatStreamEvent.FromJson<ChatStreamStartEvent>(json, PolymorphismCohereChatStreamEventContext.Default);

        newEvent.Should().NotBeNull();
        newEvent!.GenerationId.Should().Be(Guid.Parse("ab1019d4-de22-471d-b31c-3066cae7d01c"));
    }
}

[JsonSourceGenerationOptions(WriteIndented = true, AllowOutOfOrderMetadataProperties = true)]
[JsonSerializable(typeof(G.ChatStreamEvent))]
[JsonSerializable(typeof(G.ChatStreamStartEvent))]
internal partial class PolymorphismCohereChatStreamEventContext : JsonSerializerContext;