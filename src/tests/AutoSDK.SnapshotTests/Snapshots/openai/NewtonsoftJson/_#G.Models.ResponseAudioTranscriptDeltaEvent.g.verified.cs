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
        public ResponseAudioTranscriptDeltaEvent(
            string delta,
            global::G.ResponseAudioTranscriptDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
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