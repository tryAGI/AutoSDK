//HintName: G.Models.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost
    {
        /// <summary>
        /// The text that will get converted into speech.<br/>
        /// Example: This is a test for the API of ElevenLabs.
        /// </summary>
        /// <example>This is a test for the API of ElevenLabs.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_multilingual_v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 and Flash v2.5 support language enforcement. For other models, an error will be returned if language code is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::G.VoiceSettingsResponseModel? VoiceSettings { get; set; }

        /// <summary>
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The text that came before the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.<br/>
        /// Example: In the heart of a lush valley surrounded by towering mountains lies the quaint village of Willowbrook.
        /// </summary>
        /// <example>In the heart of a lush valley surrounded by towering mountains lies the quaint village of Willowbrook.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_text")]
        public string? PreviousText { get; set; }

        /// <summary>
        /// The text that comes after the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.<br/>
        /// Example: The Willowbrook Festival, held every spring, celebrates the blossoming of the wild bluebells that carpet the nearby forest floors, creating a breathtaking sea of blue under the canopy of fresh green leaves.
        /// </summary>
        /// <example>The Willowbrook Festival, held every spring, celebrates the blossoming of the wild bluebells that carpet the nearby forest floors, creating a breathtaking sea of blue under the canopy of fresh green leaves.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_text")]
        public string? NextText { get; set; }

        /// <summary>
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the speech's continuity when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Example: [09bOJkdYVjKy2oOiiVtR, 0p2uKqOnZyce22SPZ9d5, 1KYvY8WZAKmcjCJ1mvVB]
        /// </summary>
        /// <example>[09bOJkdYVjKy2oOiiVtR, 0p2uKqOnZyce22SPZ9d5, 1KYvY8WZAKmcjCJ1mvVB]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_request_ids")]
        public global::System.Collections.Generic.IList<string>? PreviousRequestIds { get; set; }

        /// <summary>
        /// A list of request_id of the samples that come after this generation. next_request_ids is especially useful for maintaining the speech's continuity when regenerating a sample that has had some audio quality issues. For example, if you have generated 3 speech clips, and you want to improve clip 2, passing the request id of clip 3 as a next_request_id (and that of clip 1 as a previous_request_id) will help maintain natural flow in the combined speech. The results will be best when the same model is used across the generations. In case both next_text and next_request_ids is send, next_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Example: [3tPgBrD1UdW3snUkGw1K, 4D1jAxiRFkolBNUGzXkU, 4c8Z4aWliVR2oipYRXhj]
        /// </summary>
        /// <example>[3tPgBrD1UdW3snUkGw1K, 4D1jAxiRFkolBNUGzXkU, 4c8Z4aWliVR2oipYRXhj]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_request_ids")]
        public global::System.Collections.Generic.IList<string>? NextRequestIds { get; set; }

        /// <summary>
        /// If true, we won't use PVC version of the voice for the generation but the IVC version. This is a temporary workaround for higher latency in PVC versions.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_pvc_as_ivc")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UsePvcAsIvc { get; set; }

        /// <summary>
        /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' or 'eleven_flash_v2_5' models.<br/>
        /// Default Value: auto<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_text_normalization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationJsonConverter))]
        public global::G.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalization? ApplyTextNormalization { get; set; }

        /// <summary>
        /// This parameter controls language text normalization. This helps with proper pronunciation of text in some supported languages. WARNING: This parameter can heavily increase the latency of the request. Currently only supported for Japanese.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_language_text_normalization")]
        public bool? ApplyLanguageTextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost" /> class.
        /// </summary>
        /// <param name="text">
        /// The text that will get converted into speech.<br/>
        /// Example: This is a test for the API of ElevenLabs.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_multilingual_v2
        /// </param>
        /// <param name="languageCode">
        /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 and Flash v2.5 support language enforcement. For other models, an error will be returned if language code is provided.
        /// </param>
        /// <param name="voiceSettings"></param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request<br/>
        /// Example: []
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="previousText">
        /// The text that came before the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.<br/>
        /// Example: In the heart of a lush valley surrounded by towering mountains lies the quaint village of Willowbrook.
        /// </param>
        /// <param name="nextText">
        /// The text that comes after the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.<br/>
        /// Example: The Willowbrook Festival, held every spring, celebrates the blossoming of the wild bluebells that carpet the nearby forest floors, creating a breathtaking sea of blue under the canopy of fresh green leaves.
        /// </param>
        /// <param name="previousRequestIds">
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the speech's continuity when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Example: [09bOJkdYVjKy2oOiiVtR, 0p2uKqOnZyce22SPZ9d5, 1KYvY8WZAKmcjCJ1mvVB]
        /// </param>
        /// <param name="nextRequestIds">
        /// A list of request_id of the samples that come after this generation. next_request_ids is especially useful for maintaining the speech's continuity when regenerating a sample that has had some audio quality issues. For example, if you have generated 3 speech clips, and you want to improve clip 2, passing the request id of clip 3 as a next_request_id (and that of clip 1 as a previous_request_id) will help maintain natural flow in the combined speech. The results will be best when the same model is used across the generations. In case both next_text and next_request_ids is send, next_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Example: [3tPgBrD1UdW3snUkGw1K, 4D1jAxiRFkolBNUGzXkU, 4c8Z4aWliVR2oipYRXhj]
        /// </param>
        /// <param name="applyTextNormalization">
        /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' or 'eleven_flash_v2_5' models.<br/>
        /// Default Value: auto<br/>
        /// Example: true
        /// </param>
        /// <param name="applyLanguageTextNormalization">
        /// This parameter controls language text normalization. This helps with proper pronunciation of text in some supported languages. WARNING: This parameter can heavily increase the latency of the request. Currently only supported for Japanese.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost(
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
            global::G.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalization? applyTextNormalization,
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
        /// Initializes a new instance of the <see cref="BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost" /> class.
        /// </summary>
        public BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPost()
        {
        }
    }
}