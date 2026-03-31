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
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// The transcribed text. May be partial or final depending on is_final.<br/>
        /// **Note**: Text may be empty in initial responses while the system accumulates sufficient audio for transcription. This is normal behavior - wait for responses with non-empty text or monitor is_final for completion status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Whether this is a final transcription result or an interim result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinal { get; set; }

        /// <summary>
        /// The duration of the audio transcribed so far, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The specified language of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Word-level timestamps showing the start and end time of each word in seconds. Always included in streaming responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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