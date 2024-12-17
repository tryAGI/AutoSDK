//HintName: G.Models.ChatStreamEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "event_type",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(G.ChatStreamStartEvent), typeDiscriminator: "stream-start")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(G.ChatSearchQueriesGenerationEvent), typeDiscriminator: "search-queries-generation")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(G.ChatSearchResultsEvent), typeDiscriminator: "search-results")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(G.ChatTextGenerationEvent), typeDiscriminator: "text-generation")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(G.ChatCitationGenerationEvent), typeDiscriminator: "citation-generation")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(G.ChatStreamEndEvent), typeDiscriminator: "stream-end")]
    public partial class ChatStreamEvent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}