//HintName: G.Models.SpeechToTextResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechToTextResponse
    {
        /// <summary>
        /// Unique request identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Transcribed text from audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Word-level timing data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamps")]
        public object? Timestamps { get; set; }

        /// <summary>
        /// Speaker-identified transcript segments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarized_transcript")]
        public object? DiarizedTranscript { get; set; }

        /// <summary>
        /// Detected language code (BCP-47)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Confidence score (0.0-1.0) for detected language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_probability")]
        public double? LanguageProbability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier
        /// </param>
        /// <param name="transcript">
        /// Transcribed text from audio
        /// </param>
        /// <param name="timestamps">
        /// Word-level timing data
        /// </param>
        /// <param name="diarizedTranscript">
        /// Speaker-identified transcript segments
        /// </param>
        /// <param name="languageCode">
        /// Detected language code (BCP-47)
        /// </param>
        /// <param name="languageProbability">
        /// Confidence score (0.0-1.0) for detected language
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextResponse(
            string? requestId,
            string? transcript,
            object? timestamps,
            object? diarizedTranscript,
            string? languageCode,
            double? languageProbability)
        {
            this.RequestId = requestId;
            this.Transcript = transcript;
            this.Timestamps = timestamps;
            this.DiarizedTranscript = diarizedTranscript;
            this.LanguageCode = languageCode;
            this.LanguageProbability = languageProbability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextResponse" /> class.
        /// </summary>
        public SpeechToTextResponse()
        {
        }
    }
}