//HintName: G.Models.PronunciationDictionaryAliasRuleRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"alias":"tie-land","case_sensitive":true,"string_to_replace":"Thailand","type":"alias","word_boundaries":true}
    /// </summary>
    public sealed partial class PronunciationDictionaryAliasRuleRequestModel
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
        /// <default>"alias"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "alias";

        /// <summary>
        /// The alias for the string to be replaced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryAliasRuleRequestModel" /> class.
        /// </summary>
        /// <param name="stringToReplace">
        /// The string to replace. Must be a non-empty string.
        /// </param>
        /// <param name="alias">
        /// The alias for the string to be replaced.
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
        public PronunciationDictionaryAliasRuleRequestModel(
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
        /// Initializes a new instance of the <see cref="PronunciationDictionaryAliasRuleRequestModel" /> class.
        /// </summary>
        public PronunciationDictionaryAliasRuleRequestModel()
        {
        }
    }
}