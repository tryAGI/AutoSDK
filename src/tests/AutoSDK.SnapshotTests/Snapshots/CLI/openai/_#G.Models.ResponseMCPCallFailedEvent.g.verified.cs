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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseMCPCallFailedEventTypeJsonConverter))]
        public global::G.ResponseMCPCallFailedEventType Type { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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