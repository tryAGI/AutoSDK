//HintName: G.Models.TranscriptTextDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is an additional text delta. This is also the first event emitted when the transcription starts. Only emitted when you [create a transcription](/docs/api-reference/audio/create-transcription) with the `Stream` parameter set to `true`.
    /// </summary>
    public sealed partial class TranscriptTextDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `transcript.text.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TranscriptTextDeltaEventType Type { get; set; }

        /// <summary>
        /// The text delta that was additionally transcribed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// The log probabilities of the delta. Only included if you [create a transcription](/docs/api-reference/audio/create-transcription) with the `include[]` parameter set to `logprobs`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::System.Collections.Generic.IList<global::G.TranscriptTextDeltaEventLogprob>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `transcript.text.delta`.
        /// </param>
        /// <param name="delta">
        /// The text delta that was additionally transcribed.
        /// </param>
        /// <param name="logprobs">
        /// The log probabilities of the delta. Only included if you [create a transcription](/docs/api-reference/audio/create-transcription) with the `include[]` parameter set to `logprobs`.
        /// </param>
        public TranscriptTextDeltaEvent(
            string delta,
            global::G.TranscriptTextDeltaEventType type,
            global::System.Collections.Generic.IList<global::G.TranscriptTextDeltaEventLogprob>? logprobs)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDeltaEvent" /> class.
        /// </summary>
        public TranscriptTextDeltaEvent()
        {
        }
    }
}