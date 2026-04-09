//HintName: G.Models.SubmitTranscriptionJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitTranscriptionJobRequest
    {
        /// <summary>
        /// Direct download URL for the media file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MediaUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SubmitTranscriptionJobRequestLanguageJsonConverter))]
        public global::G.SubmitTranscriptionJobRequestLanguage? Language { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip_diarization")]
        public bool? SkipDiarization { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip_punctuation")]
        public bool? SkipPunctuation { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_disfluencies")]
        public bool? RemoveDisfluencies { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_channels_count")]
        public int? SpeakerChannelsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_vocabulary_id")]
        public string? CustomVocabularyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_vocabularies")]
        public global::System.Collections.Generic.IList<global::G.CustomVocabulary>? CustomVocabularies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitTranscriptionJobRequest" /> class.
        /// </summary>
        /// <param name="mediaUrl">
        /// Direct download URL for the media file
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="skipDiarization">
        /// Default Value: false
        /// </param>
        /// <param name="skipPunctuation">
        /// Default Value: false
        /// </param>
        /// <param name="removeDisfluencies">
        /// Default Value: false
        /// </param>
        /// <param name="filterProfanity">
        /// Default Value: false
        /// </param>
        /// <param name="speakerChannelsCount"></param>
        /// <param name="customVocabularyId"></param>
        /// <param name="deleteAfterSeconds"></param>
        /// <param name="customVocabularies"></param>
        public SubmitTranscriptionJobRequest(
            string mediaUrl,
            string? metadata,
            string? callbackUrl,
            global::G.SubmitTranscriptionJobRequestLanguage? language,
            bool? skipDiarization,
            bool? skipPunctuation,
            bool? removeDisfluencies,
            bool? filterProfanity,
            int? speakerChannelsCount,
            string? customVocabularyId,
            int? deleteAfterSeconds,
            global::System.Collections.Generic.IList<global::G.CustomVocabulary>? customVocabularies)
        {
            this.MediaUrl = mediaUrl ?? throw new global::System.ArgumentNullException(nameof(mediaUrl));
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
        /// Initializes a new instance of the <see cref="SubmitTranscriptionJobRequest" /> class.
        /// </summary>
        public SubmitTranscriptionJobRequest()
        {
        }
    }
}