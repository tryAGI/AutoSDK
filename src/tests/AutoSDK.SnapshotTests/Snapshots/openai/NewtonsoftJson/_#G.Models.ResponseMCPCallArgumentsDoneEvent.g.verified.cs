//HintName: G.Models.ResponseMCPCallArgumentsDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the arguments for an MCP tool call are finalized.
    /// </summary>
    public sealed partial class ResponseMCPCallArgumentsDoneEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.mcp_call.arguments_done'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseMCPCallArgumentsDoneEventType Type { get; set; }

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
        /// The finalized arguments for the MCP tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public object Arguments { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ResponseMCPCallArgumentsDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_call.arguments_done'.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the MCP tool call item being processed.
        /// </param>
        /// <param name="arguments">
        /// The finalized arguments for the MCP tool call.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseMCPCallArgumentsDoneEvent(
            int outputIndex,
            string itemId,
            object arguments,
            int sequenceNumber,
            global::G.ResponseMCPCallArgumentsDoneEventType type)
        {
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMCPCallArgumentsDoneEvent" /> class.
        /// </summary>
        public ResponseMCPCallArgumentsDoneEvent()
        {
        }
    }
}