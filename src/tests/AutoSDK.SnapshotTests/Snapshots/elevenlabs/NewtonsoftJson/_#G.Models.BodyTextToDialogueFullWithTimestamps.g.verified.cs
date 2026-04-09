//HintName: G.Models.BodyTextToDialogueFullWithTimestamps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTextToDialogueFullWithTimestamps
    {
        /// <summary>
        /// A list of dialogue inputs, each containing text and a voice ID which will be converted into speech. The maximum number of unique voice IDs is 10.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DialogueInput> Inputs { get; set; } = default!;

        /// <summary>
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_v3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Language code (ISO 639-1) used to enforce a language for the model and text normalization. If the model does not support provided language code, an error will be returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Settings controlling the dialogue generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public global::G.ModelSettingsResponseModel? Settings { get; set; }

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
        /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_text_normalization")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter))]
        public global::G.BodyTextToDialogueFullWithTimestampsApplyTextNormalization? ApplyTextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTextToDialogueFullWithTimestamps" /> class.
        /// </summary>
        /// <param name="inputs">
        /// A list of dialogue inputs, each containing text and a voice ID which will be converted into speech. The maximum number of unique voice IDs is 10.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_v3
        /// </param>
        /// <param name="languageCode">
        /// Language code (ISO 639-1) used to enforce a language for the model and text normalization. If the model does not support provided language code, an error will be returned.
        /// </param>
        /// <param name="settings">
        /// Settings controlling the dialogue generation.
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.
        /// </param>
        /// <param name="applyTextNormalization">
        /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.<br/>
        /// Default Value: auto
        /// </param>
        public BodyTextToDialogueFullWithTimestamps(
            global::System.Collections.Generic.IList<global::G.DialogueInput> inputs,
            string? modelId,
            string? languageCode,
            global::G.ModelSettingsResponseModel? settings,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>? pronunciationDictionaryLocators,
            int? seed,
            global::G.BodyTextToDialogueFullWithTimestampsApplyTextNormalization? applyTextNormalization)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.ModelId = modelId;
            this.LanguageCode = languageCode;
            this.Settings = settings;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
            this.Seed = seed;
            this.ApplyTextNormalization = applyTextNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTextToDialogueFullWithTimestamps" /> class.
        /// </summary>
        public BodyTextToDialogueFullWithTimestamps()
        {
        }
    }
}