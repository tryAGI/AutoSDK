//HintName: G.Models.ResponseAudioTranscriptDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a partial transcript of audio.
    /// </summary>
    public sealed partial class ResponseAudioTranscriptDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.audio.transcript.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseAudioTranscriptDeltaEventType Type { get; set; }

        /// <summary>
        /// The partial transcript of the audio response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ResponseAudioTranscriptDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.audio.transcript.delta`.
        /// </param>
        /// <param name="delta">
        /// The partial transcript of the audio response.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseAudioTranscriptDeltaEvent(
            string delta,
            int sequenceNumber,
            global::G.ResponseAudioTranscriptDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioTranscriptDeltaEvent" /> class.
        /// </summary>
        public ResponseAudioTranscriptDeltaEvent()
        {
        }
    }
}