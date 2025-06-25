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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseMCPCallInProgressEventTypeJsonConverter))]
        public global::G.ResponseMCPCallInProgressEventType Type { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The unique identifier of the MCP tool call item being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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