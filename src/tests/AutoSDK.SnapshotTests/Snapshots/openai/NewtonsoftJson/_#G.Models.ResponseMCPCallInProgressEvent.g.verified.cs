//HintName: G.Models.ResponseMCPCallInProgressEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an MCP  tool call is in progress.
    /// </summary>
    public sealed partial class ResponseMCPCallInProgressEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.mcp_call.in_progress'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseMCPCallInProgressEventType Type { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the MCP tool call item being processed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPCallInProgressEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_call.in_progress'.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the MCP tool call item being processed.
        /// </param>
        public ResponseMCPCallInProgressEvent(
            int sequenceNumber,
            int outputIndex,
            string itemId,
            global::G.ResponseMCPCallInProgressEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPCallInProgressEvent" /> class.
        /// </summary>
        public ResponseMCPCallInProgressEvent()
        {
        }
    }
}