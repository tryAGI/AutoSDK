//HintName: G.Models.PronunciationDictionaryPhonemeRuleResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDictionaryPhonemeRuleResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string_to_replace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StringToReplace { get; set; }

        /// <summary>
        /// Whether the rule matches case-sensitively.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Whether the rule only matches at word boundaries.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_boundaries")]
        public bool? WordBoundaries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"phoneme"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "phoneme";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phoneme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alphabet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alphabet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleResponseModel" /> class.
        /// </summary>
        /// <param name="stringToReplace"></param>
        /// <param name="caseSensitive">
        /// Whether the rule matches case-sensitively.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="wordBoundaries">
        /// Whether the rule only matches at word boundaries.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type"></param>
        /// <param name="phoneme"></param>
        /// <param name="alphabet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryPhonemeRuleResponseModel(
            string stringToReplace,
            string phoneme,
            string alphabet,
            bool? caseSensitive,
            bool? wordBoundaries,
            string type = "phoneme")
        {
            this.StringToReplace = stringToReplace ?? throw new global::System.ArgumentNullException(nameof(stringToReplace));
            this.Phoneme = phoneme ?? throw new global::System.ArgumentNullException(nameof(phoneme));
            this.Alphabet = alphabet ?? throw new global::System.ArgumentNullException(nameof(alphabet));
            this.CaseSensitive = caseSensitive;
            this.WordBoundaries = wordBoundaries;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleResponseModel" /> class.
        /// </summary>
        public PronunciationDictionaryPhonemeRuleResponseModel()
        {
        }
    }
}