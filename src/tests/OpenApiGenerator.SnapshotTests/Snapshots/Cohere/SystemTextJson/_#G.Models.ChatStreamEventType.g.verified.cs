//HintName: G.Models.ChatStreamEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The streamed event types
    /// </summary>
    public sealed partial class ChatStreamEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ChatStreamEventTypeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatStreamEventTypeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}