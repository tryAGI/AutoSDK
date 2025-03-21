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
        public ResponseAudioTranscriptDoneEvent(
            global::G.ResponseAudioTranscriptDoneEventType type)
        {
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