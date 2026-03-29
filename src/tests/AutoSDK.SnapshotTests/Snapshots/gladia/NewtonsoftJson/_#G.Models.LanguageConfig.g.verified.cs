//HintName: G.Models.LanguageConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageConfig
    {
        /// <summary>
        /// If one language is set, it will be used for the transcription. Otherwise, language will be auto-detected by the model.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionLanguageCodeEnum>? Languages { get; set; }

        /// <summary>
        /// If true, language will be auto-detected on each utterance. Otherwise, language will be auto-detected on first utterance and then used for the rest of the transcription. If one language is set, this option will be ignored.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_switching")]
        public bool? CodeSwitching { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageConfig" /> class.
        /// </summary>
        /// <param name="languages">
        /// If one language is set, it will be used for the transcription. Otherwise, language will be auto-detected by the model.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="codeSwitching">
        /// If true, language will be auto-detected on each utterance. Otherwise, language will be auto-detected on first utterance and then used for the rest of the transcription. If one language is set, this option will be ignored.<br/>
        /// Default Value: false
        /// </param>
        public LanguageConfig(
            global::System.Collections.Generic.IList<global::G.TranscriptionLanguageCodeEnum>? languages,
            bool? codeSwitching)
        {
            this.Languages = languages;
            this.CodeSwitching = codeSwitching;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageConfig" /> class.
        /// </summary>
        public LanguageConfig()
        {
        }
    }
}