//HintName: G.Models.ResponseAudioTranscriptDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the full audio transcript is completed.
    /// </summary>
    public sealed partial class ResponseAudioTranscriptDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.audio.transcript.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseAudioTranscriptDoneEventType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseAudioTranscriptDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.audio.transcript.done`.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseAudioTranscriptDoneEvent(
            int sequenceNumber,
            global::G.ResponseAudioTranscriptDoneEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioTranscriptDoneEvent" /> class.
        /// </summary>
        public ResponseAudioTranscriptDoneEvent()
        {
        }
    }
}