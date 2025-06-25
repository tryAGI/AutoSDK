//HintName: G.Models.ResponseQueuedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a response is queued and waiting to be processed.
    /// </summary>
    public sealed partial class ResponseQueuedEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.queued'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseQueuedEventTypeJsonConverter))]
        public global::G.ResponseQueuedEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Response Response { get; set; }

        /// <summary>
        /// The sequence number for this event.
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
        /// Initializes a new instance of the <see cref="ResponseQueuedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.queued'.
        /// </param>
        /// <param name="response"></param>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseQueuedEvent(
            global::G.Response response,
            int sequenceNumber,
            global::G.ResponseQueuedEventType type)
        {
            this.Response = response;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQueuedEvent" /> class.
        /// </summary>
        public ResponseQueuedEvent()
        {
        }
    }
}