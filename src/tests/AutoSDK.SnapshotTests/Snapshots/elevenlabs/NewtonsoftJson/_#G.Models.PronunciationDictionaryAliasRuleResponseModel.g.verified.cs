//HintName: G.Models.PronunciationDictionaryAliasRuleResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDictionaryAliasRuleResponseModel
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
        /// <default>"alias"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "alias";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryAliasRuleResponseModel" /> class.
        /// </summary>
        /// <param name="stringToReplace"></param>
        /// <param name="alias"></param>
        /// <param name="caseSensitive">
        /// Whether the rule matches case-sensitively.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="wordBoundaries">
        /// Whether the rule only matches at word boundaries.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type"></param>
        public PronunciationDictionaryAliasRuleResponseModel(
            string stringToReplace,
            string alias,
            bool? caseSensitive,
            bool? wordBoundaries,
            string type = "alias")
        {
            this.StringToReplace = stringToReplace ?? throw new global::System.ArgumentNullException(nameof(stringToReplace));
            this.CaseSensitive = caseSensitive;
            this.WordBoundaries = wordBoundaries;
            this.Type = type;
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryAliasRuleResponseModel" /> class.
        /// </summary>
        public PronunciationDictionaryAliasRuleResponseModel()
        {
        }
    }
}