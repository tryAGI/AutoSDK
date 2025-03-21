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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter))]
        public global::G.ResponseAudioTranscriptDeltaEventType Type { get; set; }

        /// <summary>
        /// The partial transcript of the audio response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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