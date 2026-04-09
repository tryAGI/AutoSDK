//HintName: G.Models.TranslationConfigDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationConfigDTO
    {
        /// <summary>
        /// Target language in `iso639-1` format you want the transcription translated to<br/>
        /// Example: [en]
        /// </summary>
        /// <example>[en]</example>
        [global::Newtonsoft.Json.JsonProperty("target_languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TranslationLanguageCodeEnum> TargetLanguages { get; set; } = default!;

        /// <summary>
        /// Model you want the translation model to use to translate<br/>
        /// Default Value: base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslationModelEnumJsonConverter))]
        public global::G.TranslationModelEnum? Model { get; set; }

        /// <summary>
        /// Align translated utterances with the original ones<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("match_original_utterances")]
        public bool? MatchOriginalUtterances { get; set; }

        /// <summary>
        /// Whether to apply lipsync to the translated transcription. <br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lipsync")]
        public bool? Lipsync { get; set; }

        /// <summary>
        /// Enables or disables context-aware translation features that allow the model to adapt translations based on provided context.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_adaptation")]
        public bool? ContextAdaptation { get; set; }

        /// <summary>
        /// Context information to improve translation accuracy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Forces the translation to use informal language forms when available in the target language.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("informal")]
        public bool? Informal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationConfigDTO" /> class.
        /// </summary>
        /// <param name="targetLanguages">
        /// Target language in `iso639-1` format you want the transcription translated to<br/>
        /// Example: [en]
        /// </param>
        /// <param name="model">
        /// Model you want the translation model to use to translate<br/>
        /// Default Value: base
        /// </param>
        /// <param name="matchOriginalUtterances">
        /// Align translated utterances with the original ones<br/>
        /// Default Value: true
        /// </param>
        /// <param name="lipsync">
        /// Whether to apply lipsync to the translated transcription. <br/>
        /// Default Value: true
        /// </param>
        /// <param name="contextAdaptation">
        /// Enables or disables context-aware translation features that allow the model to adapt translations based on provided context.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="context">
        /// Context information to improve translation accuracy
        /// </param>
        /// <param name="informal">
        /// Forces the translation to use informal language forms when available in the target language.<br/>
        /// Default Value: false
        /// </param>
        public TranslationConfigDTO(
            global::System.Collections.Generic.IList<global::G.TranslationLanguageCodeEnum> targetLanguages,
            global::G.TranslationModelEnum? model,
            bool? matchOriginalUtterances,
            bool? lipsync,
            bool? contextAdaptation,
            string? context,
            bool? informal)
        {
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.Model = model;
            this.MatchOriginalUtterances = matchOriginalUtterances;
            this.Lipsync = lipsync;
            this.ContextAdaptation = contextAdaptation;
            this.Context = context;
            this.Informal = informal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationConfigDTO" /> class.
        /// </summary>
        public TranslationConfigDTO()
        {
        }
    }
}