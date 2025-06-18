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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseMCPListToolsCompletedEventTypeJsonConverter))]
        public global::G.ResponseMCPListToolsCompletedEventType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseMCPListToolsCompletedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.mcp_list_tools.completed'.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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