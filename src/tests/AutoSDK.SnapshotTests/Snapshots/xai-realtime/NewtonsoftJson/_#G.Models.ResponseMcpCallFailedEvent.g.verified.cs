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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseMcpCallFailedEventTypeJsonConverter))]
        public global::G.ResponseMcpCallFailedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMcpCallFailedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
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