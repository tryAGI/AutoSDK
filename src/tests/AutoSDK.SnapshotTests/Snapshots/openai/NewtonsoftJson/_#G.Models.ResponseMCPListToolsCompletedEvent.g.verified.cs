//HintName: G.Models.ResponseMCPListToolsCompletedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the list of available MCP tools has been successfully retrieved.
    /// </summary>
    public sealed partial class ResponseMCPListToolsCompletedEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.mcp_list_tools.completed'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseMCPListToolsCompletedEventType Type { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPListToolsCompletedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_list_tools.completed'.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseMCPListToolsCompletedEvent(
            int sequenceNumber,
            global::G.ResponseMCPListToolsCompletedEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPListToolsCompletedEvent" /> class.
        /// </summary>
        public ResponseMCPListToolsCompletedEvent()
        {
        }
    }
}