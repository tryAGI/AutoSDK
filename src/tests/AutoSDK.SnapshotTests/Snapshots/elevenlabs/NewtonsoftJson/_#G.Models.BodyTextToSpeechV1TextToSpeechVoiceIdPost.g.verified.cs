//HintName: G.Models.BodyTextToSpeechV1TextToSpeechVoiceIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTextToSpeechV1TextToSpeechVoiceIdPost
    {
        /// <summary>
        /// The text that will get converted into speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_multilingual_v2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 and Flash v2.5 support language enforcement. For other models, an error will be returned if language code is provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Voice settings overriding stored settings for the given voice. They are applied only on the given request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_settings")]
        public global::G.VoiceSettingsResponseModel? VoiceSettings { get; set; }

        /// <summary>
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The text that came before the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_text")]
        public string? PreviousText { get; set; }

        /// <summary>
        /// The text that comes after the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_text")]
        public string? NextText { get; set; }

        /// <summary>
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the speech's continuity when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_request_ids")]
        public global::System.Collections.Generic.IList<string>? PreviousRequestIds { get; set; }

        /// <summary>
        /// A list of request_id of the samples that come after this generation. next_request_ids is especially useful for maintaining the speech's continuity when regenerating a sample that has had some audio quality issues. For example, if you have generated 3 speech clips, and you want to improve clip 2, passing the request id of clip 3 as a next_request_id (and that of clip 1 as a previous_request_id) will help maintain natural flow in the combined speech. The results will be best when the same model is used across the generations. In case both next_text and next_request_ids is send, next_text will be ignored. A maximum of 3 request_ids can be send.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_request_ids")]
        public global::System.Collections.Generic.IList<string>? NextRequestIds { get; set; }

        /// <summary>
        /// If true, we won't use PVC version of the voice for the generation but the IVC version. This is a temporary workaround for higher latency in PVC versions.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_pvc_as_ivc")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UsePvcAsIvc { get; set; }

        /// <summary>
        /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' or 'eleven_flash_v2_5' models.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_text_normalization")]
        public global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization? ApplyTextNormalization { get; set; }

        /// <summary>
        /// This parameter controls language text normalization. This helps with proper pronunciation of text in some supported languages. WARNING: This parameter can heavily increase the latency of the request. Currently only supported for Japanese.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_language_text_normalization")]
        public bool? ApplyLanguageTextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTextToSpeechV1TextToSpeechVoiceIdPost" /> class.
        /// </summary>
        /// <param name="text">
        /// The text that will get converted into speech.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_multilingual_v2
        /// </param>
        /// <param name="languageCode">
        /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 and Flash v2.5 support language enforcement. For other models, an error will be returned if language code is provided.
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings overriding stored settings for the given voice. They are applied only on the given request.
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.
        /// </param>
        /// <param name="previousText">
        /// The text that came before the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.
        /// </param>
        /// <param name="nextText">
        /// The text that comes after the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.
        /// </param>
        /// <param name="previousRequestIds">
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the speech's continuity when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.
        /// </param>
        /// <param name="nextRequestIds">
        /// A list of request_id of the samples that come after this generation. next_request_ids is especially useful for maintaining the speech's continuity when regenerating a sample that has had some audio quality issues. For example, if you have generated 3 speech clips, and you want to improve clip 2, passing the request id of clip 3 as a next_request_id (and that of clip 1 as a previous_request_id) will help maintain natural flow in the combined speech. The results will be best when the same model is used across the generations. In case both next_text and next_request_ids is send, next_text will be ignored. A maximum of 3 request_ids can be send.
        /// </param>
        /// <param name="applyTextNormalization">
        /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' or 'eleven_flash_v2_5' models.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="applyLanguageTextNormalization">
        /// This parameter controls language text normalization. This helps with proper pronunciation of text in some supported languages. WARNING: This parameter can heavily increase the latency of the request. Currently only supported for Japanese.<br/>
        /// Default Value: false
        /// </param>
        public BodyTextToSpeechV1TextToSpeechVoiceIdPost(
            string text,
            string? modelId,
            string? languageCode,
            global::G.VoiceSettingsResponseModel? voiceSettings,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>? pronunciationDictionaryLocators,
            int? seed,
            string? previousText,
            string? nextText,
            global::System.Collections.Generic.IList<string>? previousRequestIds,
            global::System.Collections.Generic.IList<string>? nextRequestIds,
            global::G.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalization? applyTextNormalization,
            bool? applyLanguageTextNormalization)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ModelId = modelId;
            this.LanguageCode = languageCode;
            this.VoiceSettings = voiceSettings;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
            this.Seed = seed;
            this.PreviousText = previousText;
            this.NextText = nextText;
            this.PreviousRequestIds = previousRequestIds;
            this.NextRequestIds = nextRequestIds;
            this.ApplyTextNormalization = applyTextNormalization;
            this.ApplyLanguageTextNormalization = applyLanguageTextNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTextToSpeechV1TextToSpeechVoiceIdPost" /> class.
        /// </summary>
        public BodyTextToSpeechV1TextToSpeechVoiceIdPost()
        {
        }
    }
}