//HintName: G.Models.TranscriptTextDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the transcription is complete. Contains the complete transcription text. Only emitted when you [create a transcription](/docs/api-reference/audio/create-transcription) with the `Stream` parameter set to `true`.
    /// </summary>
    public sealed partial class TranscriptTextDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `transcript.text.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptTextDoneEventTypeJsonConverter))]
        public global::G.TranscriptTextDoneEventType Type { get; set; }

        /// <summary>
        /// The text that was transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The log probabilities of the individual tokens in the transcription. Only included if you [create a transcription](/docs/api-reference/audio/create-transcription) with the `include[]` parameter set to `logprobs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<global::G.TranscriptTextDoneEventLogprob>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `transcript.text.done`.
        /// </param>
        /// <param name="text">
        /// The text that was transcribed.
        /// </param>
        /// <param name="logprobs">
        /// The log probabilities of the individual tokens in the transcription. Only included if you [create a transcription](/docs/api-reference/audio/create-transcription) with the `include[]` parameter set to `logprobs`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTextDoneEvent(
            string text,
            global::G.TranscriptTextDoneEventType type,
            global::System.Collections.Generic.IList<global::G.TranscriptTextDoneEventLogprob>? logprobs)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDoneEvent" /> class.
        /// </summary>
        public TranscriptTextDoneEvent()
        {
        }
    }
}