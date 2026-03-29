//HintName: G.Models.TranscribeOrTranslateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscribeOrTranslateResponse
    {
        /// <summary>
        /// Transcribed text in the original language.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// Translated text in the target language. Only present when target_language is specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translation")]
        public string? Translation { get; set; }

        /// <summary>
        /// Array of word-level timing data with transcription segments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_translation_with_timestamp")]
        public global::System.Collections.Generic.IList<global::G.TimestampSegment>? TranscriptTranslationWithTimestamp { get; set; }

        /// <summary>
        /// Base64-encoded WAV audio of the translated speech. Only present when return_translation_audio is true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_base64")]
        public string? AudioBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeOrTranslateResponse" /> class.
        /// </summary>
        /// <param name="transcript">
        /// Transcribed text in the original language.
        /// </param>
        /// <param name="translation">
        /// Translated text in the target language. Only present when target_language is specified.
        /// </param>
        /// <param name="transcriptTranslationWithTimestamp">
        /// Array of word-level timing data with transcription segments.
        /// </param>
        /// <param name="audioBase64">
        /// Base64-encoded WAV audio of the translated speech. Only present when return_translation_audio is true.
        /// </param>
        public TranscribeOrTranslateResponse(
            string transcript,
            string? translation,
            global::System.Collections.Generic.IList<global::G.TimestampSegment>? transcriptTranslationWithTimestamp,
            string? audioBase64)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Translation = translation;
            this.TranscriptTranslationWithTimestamp = transcriptTranslationWithTimestamp;
            this.AudioBase64 = audioBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeOrTranslateResponse" /> class.
        /// </summary>
        public TranscribeOrTranslateResponse()
        {
        }
    }
}