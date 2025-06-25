//HintName: G.Models.ResponseAudioDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the audio response is complete.
    /// </summary>
    public sealed partial class ResponseAudioDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.audio.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseAudioDoneEventTypeJsonConverter))]
        public global::G.ResponseAudioDoneEventType Type { get; set; }

        /// <summary>
        /// The sequence number of the delta.
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
        /// Initializes a new instance of the <see cref="ResponseAudioDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.audio.done`.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of the delta.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAudioDoneEvent(
            int sequenceNumber,
            global::G.ResponseAudioDoneEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDoneEvent" /> class.
        /// </summary>
        public ResponseAudioDoneEvent()
        {
        }
    }
}