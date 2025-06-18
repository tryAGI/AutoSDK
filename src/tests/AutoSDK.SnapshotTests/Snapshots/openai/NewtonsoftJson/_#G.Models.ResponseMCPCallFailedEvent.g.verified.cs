//HintName: G.Models.ResponseMCPCallFailedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an MCP  tool call has failed.
    /// </summary>
    public sealed partial class ResponseMCPCallFailedEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.mcp_call.failed'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseMCPCallFailedEventType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseMCPCallFailedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_call.failed'.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseMCPCallFailedEvent(
            int sequenceNumber,
            global::G.ResponseMCPCallFailedEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPCallFailedEvent" /> class.
        /// </summary>
        public ResponseMCPCallFailedEvent()
        {
        }
    }
}