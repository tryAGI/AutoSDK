//HintName: G.Models.TranscriptMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptMessage
    {
        /// <summary>
        /// Unique identifier for this transcription session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// The transcribed text. May be partial or final depending on is_final.<br/>
        /// **Note**: Text may be empty in initial responses while the system accumulates sufficient audio for transcription. This is normal behavior - wait for responses with non-empty text or monitor is_final for completion status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Whether this is a final transcription result or an interim result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_final", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFinal { get; set; } = default!;

        /// <summary>
        /// The duration of the audio transcribed so far, in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The specified language of the input audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Word-level timestamps showing the start and end time of each word in seconds. Always included in streaming responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMessage" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this transcription session.
        /// </param>
        /// <param name="text">
        /// The transcribed text. May be partial or final depending on is_final.<br/>
        /// **Note**: Text may be empty in initial responses while the system accumulates sufficient audio for transcription. This is normal behavior - wait for responses with non-empty text or monitor is_final for completion status.
        /// </param>
        /// <param name="isFinal">
        /// Whether this is a final transcription result or an interim result.
        /// </param>
        /// <param name="duration">
        /// The duration of the audio transcribed so far, in seconds.
        /// </param>
        /// <param name="language">
        /// The specified language of the input audio.
        /// </param>
        /// <param name="words">
        /// Word-level timestamps showing the start and end time of each word in seconds. Always included in streaming responses.
        /// </param>
        public TranscriptMessage(
            string requestId,
            string text,
            bool isFinal,
            double? duration,
            string? language,
            global::System.Collections.Generic.IList<global::G.TranscriptionWord>? words)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.IsFinal = isFinal;
            this.Duration = duration;
            this.Language = language;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMessage" /> class.
        /// </summary>
        public TranscriptMessage()
        {
        }
    }
}