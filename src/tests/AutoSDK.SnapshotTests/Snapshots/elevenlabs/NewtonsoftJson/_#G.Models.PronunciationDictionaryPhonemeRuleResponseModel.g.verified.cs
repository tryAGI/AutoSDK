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
        [global::Newtonsoft.Json.JsonProperty("string_to_replace", Required = global::Newtonsoft.Json.Required.Always)]
        public string StringToReplace { get; set; } = default!;

        /// <summary>
        /// Whether the rule matches case-sensitively.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Whether the rule only matches at word boundaries.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_boundaries")]
        public bool? WordBoundaries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"phoneme"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "phoneme";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneme", Required = global::Newtonsoft.Json.Required.Always)]
        public string Phoneme { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alphabet", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alphabet { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleResponseModel" /> class.
        /// </summary>
        /// <param name="stringToReplace"></param>
        /// <param name="phoneme"></param>
        /// <param name="alphabet"></param>
        /// <param name="caseSensitive">
        /// Whether the rule matches case-sensitively.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="wordBoundaries">
        /// Whether the rule only matches at word boundaries.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type"></param>
        public PronunciationDictionaryPhonemeRuleResponseModel(
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
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleResponseModel" /> class.
        /// </summary>
        public PronunciationDictionaryPhonemeRuleResponseModel()
        {
        }
    }
}