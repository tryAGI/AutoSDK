//HintName: G.Models.ResponseMcpCallFailedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP tool call failed.
    /// </summary>
    public sealed partial class ResponseMcpCallFailedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseMcpCallFailedEventTypeJsonConverter))]
        public global::G.ResponseMcpCallFailedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMcpCallFailedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseMcpCallFailedEvent(
            global::G.ResponseMcpCallFailedEventType? type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMcpCallFailedEvent" /> class.
        /// </summary>
        public ResponseMcpCallFailedEvent()
        {
        }
    }
}