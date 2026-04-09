//HintName: G.Models.McpListToolsCompletedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP tool list retrieved.
    /// </summary>
    public sealed partial class McpListToolsCompletedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.McpListToolsCompletedEventTypeJsonConverter))]
        public global::G.McpListToolsCompletedEventType? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="McpListToolsCompletedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        public McpListToolsCompletedEvent(
            global::G.McpListToolsCompletedEventType? type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpListToolsCompletedEvent" /> class.
        /// </summary>
        public McpListToolsCompletedEvent()
        {
        }
    }
}