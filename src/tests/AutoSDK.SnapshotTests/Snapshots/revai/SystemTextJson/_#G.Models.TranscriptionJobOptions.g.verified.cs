//HintName: G.Models.TranscriptionJobOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for transcription job submission
    /// </summary>
    public sealed partial class TranscriptionJobOptions
    {
        /// <summary>
        /// Optional metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Optional callback URL to invoke when processing is complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Language code for transcription (ISO 639-1, or cmn for Mandarin)<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionJobOptionsLanguageJsonConverter))]
        public global::G.TranscriptionJobOptionsLanguage? Language { get; set; }

        /// <summary>
        /// Skip speaker diarization<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_diarization")]
        public bool? SkipDiarization { get; set; }

        /// <summary>
        /// Skip punctuation elements<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_punctuation")]
        public bool? SkipPunctuation { get; set; }

        /// <summary>
        /// Remove ums and uhs from transcript<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_disfluencies")]
        public bool? RemoveDisfluencies { get; set; }

        /// <summary>
        /// Filter profanity from transcript<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// Number of unique speaker channels in the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_channels_count")]
        public int? SpeakerChannelsCount { get; set; }

        /// <summary>
        /// ID of a pre-completed custom vocabulary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_vocabulary_id")]
        public string? CustomVocabularyId { get; set; }

        /// <summary>
        /// Auto-delete job after this many seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_vocabularies")]
        public global::System.Collections.Generic.IList<global::G.CustomVocabulary>? CustomVocabularies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionJobOptions" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Optional metadata
        /// </param>
        /// <param name="callbackUrl">
        /// Optional callback URL to invoke when processing is complete
        /// </param>
        /// <param name="language">
        /// Language code for transcription (ISO 639-1, or cmn for Mandarin)<br/>
        /// Default Value: en
        /// </param>
        /// <param name="skipDiarization">
        /// Skip speaker diarization<br/>
        /// Default Value: false
        /// </param>
        /// <param name="skipPunctuation">
        /// Skip punctuation elements<br/>
        /// Default Value: false
        /// </param>
        /// <param name="removeDisfluencies">
        /// Remove ums and uhs from transcript<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filterProfanity">
        /// Filter profanity from transcript<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakerChannelsCount">
        /// Number of unique speaker channels in the audio
        /// </param>
        /// <param name="customVocabularyId">
        /// ID of a pre-completed custom vocabulary
        /// </param>
        /// <param name="deleteAfterSeconds">
        /// Auto-delete job after this many seconds
        /// </param>
        /// <param name="customVocabularies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionJobOptions(
            string? metadata,
            string? callbackUrl,
            global::G.TranscriptionJobOptionsLanguage? language,
            bool? skipDiarization,
            bool? skipPunctuation,
            bool? removeDisfluencies,
            bool? filterProfanity,
            int? speakerChannelsCount,
            string? customVocabularyId,
            int? deleteAfterSeconds,
            global::System.Collections.Generic.IList<global::G.CustomVocabulary>? customVocabularies)
        {
            this.Metadata = metadata;
            this.CallbackUrl = callbackUrl;
            this.Language = language;
            this.SkipDiarization = skipDiarization;
            this.SkipPunctuation = skipPunctuation;
            this.RemoveDisfluencies = removeDisfluencies;
            this.FilterProfanity = filterProfanity;
            this.SpeakerChannelsCount = speakerChannelsCount;
            this.CustomVocabularyId = customVocabularyId;
            this.DeleteAfterSeconds = deleteAfterSeconds;
            this.CustomVocabularies = customVocabularies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionJobOptions" /> class.
        /// </summary>
        public TranscriptionJobOptions()
        {
        }
    }
}