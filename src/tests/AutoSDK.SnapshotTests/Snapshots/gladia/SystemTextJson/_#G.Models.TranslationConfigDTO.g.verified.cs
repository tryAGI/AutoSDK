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
        [global::System.Text.Json.Serialization.JsonPropertyName("target_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranslationLanguageCodeEnum> TargetLanguages { get; set; }

        /// <summary>
        /// Model you want the translation model to use to translate<br/>
        /// Default Value: base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationModelEnumJsonConverter))]
        public global::G.TranslationModelEnum? Model { get; set; }

        /// <summary>
        /// Align translated utterances with the original ones<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_original_utterances")]
        public bool? MatchOriginalUtterances { get; set; }

        /// <summary>
        /// Whether to apply lipsync to the translated transcription. <br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lipsync")]
        public bool? Lipsync { get; set; }

        /// <summary>
        /// Enables or disables context-aware translation features that allow the model to adapt translations based on provided context.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_adaptation")]
        public bool? ContextAdaptation { get; set; }

        /// <summary>
        /// Context information to improve translation accuracy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Forces the translation to use informal language forms when available in the target language.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("informal")]
        public bool? Informal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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