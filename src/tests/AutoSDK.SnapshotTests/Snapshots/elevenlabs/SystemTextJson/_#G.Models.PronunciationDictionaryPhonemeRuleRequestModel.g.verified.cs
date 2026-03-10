//HintName: G.Models.PronunciationDictionaryPhonemeRuleRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"alphabet":"ipa","case_sensitive":true,"phoneme":"/\u02C8ta\u026A.l\u00E6nd/","string_to_replace":"Thailand","type":"phoneme","word_boundaries":true}
    /// </summary>
    public sealed partial class PronunciationDictionaryPhonemeRuleRequestModel
    {
        /// <summary>
        /// The string to replace. Must be a non-empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string_to_replace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StringToReplace { get; set; }

        /// <summary>
        /// Whether the rule should match case-sensitively.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Whether the rule should only match at word boundaries.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_boundaries")]
        public bool? WordBoundaries { get; set; }

        /// <summary>
        /// The type of the rule.
        /// </summary>
        /// <default>"phoneme"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "phoneme";

        /// <summary>
        /// The phoneme rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phoneme { get; set; }

        /// <summary>
        /// The alphabet to use with the phoneme rule.
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
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleRequestModel" /> class.
        /// </summary>
        /// <param name="stringToReplace">
        /// The string to replace. Must be a non-empty string.
        /// </param>
        /// <param name="caseSensitive">
        /// Whether the rule should match case-sensitively.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="wordBoundaries">
        /// Whether the rule should only match at word boundaries.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type">
        /// The type of the rule.
        /// </param>
        /// <param name="phoneme">
        /// The phoneme rule.
        /// </param>
        /// <param name="alphabet">
        /// The alphabet to use with the phoneme rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryPhonemeRuleRequestModel(
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
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleRequestModel" /> class.
        /// </summary>
        public PronunciationDictionaryPhonemeRuleRequestModel()
        {
        }
    }
}