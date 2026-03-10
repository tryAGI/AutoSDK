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
        /// <default>"alias"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "alias";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryAliasRuleResponseModel" /> class.
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
        /// <param name="alias"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryAliasRuleResponseModel(
            string stringToReplace,
            string alias,
            bool? caseSensitive,
            bool? wordBoundaries,
            string type = "alias")
        {
            this.StringToReplace = stringToReplace ?? throw new global::System.ArgumentNullException(nameof(stringToReplace));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.CaseSensitive = caseSensitive;
            this.WordBoundaries = wordBoundaries;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryAliasRuleResponseModel" /> class.
        /// </summary>
        public PronunciationDictionaryAliasRuleResponseModel()
        {
        }
    }
}