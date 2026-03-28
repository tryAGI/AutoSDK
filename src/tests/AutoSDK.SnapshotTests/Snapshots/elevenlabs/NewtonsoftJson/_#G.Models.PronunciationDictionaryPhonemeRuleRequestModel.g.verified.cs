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
        [global::Newtonsoft.Json.JsonProperty("string_to_replace", Required = global::Newtonsoft.Json.Required.Always)]
        public string StringToReplace { get; set; } = default!;

        /// <summary>
        /// Whether the rule should match case-sensitively.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Whether the rule should only match at word boundaries.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_boundaries")]
        public bool? WordBoundaries { get; set; }

        /// <summary>
        /// The type of the rule.
        /// </summary>
        /// <default>"phoneme"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "phoneme";

        /// <summary>
        /// The phoneme rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneme", Required = global::Newtonsoft.Json.Required.Always)]
        public string Phoneme { get; set; } = default!;

        /// <summary>
        /// The alphabet to use with the phoneme rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alphabet", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alphabet { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleRequestModel" /> class.
        /// </summary>
        /// <param name="stringToReplace">
        /// The string to replace. Must be a non-empty string.
        /// </param>
        /// <param name="phoneme">
        /// The phoneme rule.
        /// </param>
        /// <param name="alphabet">
        /// The alphabet to use with the phoneme rule.
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
        public PronunciationDictionaryPhonemeRuleRequestModel(
            string stringToReplace,
            string phoneme,
            string alphabet,
            bool? caseSensitive,
            bool? wordBoundaries,
            string type = "phoneme")
        {
            this.StringToReplace = stringToReplace ?? throw new global::System.ArgumentNullException(nameof(stringToReplace));
            this.CaseSensitive = caseSensitive;
            this.WordBoundaries = wordBoundaries;
            this.Type = type;
            this.Phoneme = phoneme ?? throw new global::System.ArgumentNullException(nameof(phoneme));
            this.Alphabet = alphabet ?? throw new global::System.ArgumentNullException(nameof(alphabet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleRequestModel" /> class.
        /// </summary>
        public PronunciationDictionaryPhonemeRuleRequestModel()
        {
        }
    }
}