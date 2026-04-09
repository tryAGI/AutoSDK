//HintName: G.Models.ConfiguredRulesVocabulary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfiguredRulesVocabulary
    {
        /// <summary>
        /// Formatting options for Abbreviations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("abbreviations")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesVocabularyAbbreviationsJsonConverter))]
        public global::G.ConfiguredRulesVocabularyAbbreviations? Abbreviations { get; set; }

        /// <summary>
        /// Formatting options for Loanwords
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loanwords")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesVocabularyLoanwordsJsonConverter))]
        public global::G.ConfiguredRulesVocabularyLoanwords? Loanwords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesVocabulary" /> class.
        /// </summary>
        /// <param name="abbreviations">
        /// Formatting options for Abbreviations
        /// </param>
        /// <param name="loanwords">
        /// Formatting options for Loanwords
        /// </param>
        public ConfiguredRulesVocabulary(
            global::G.ConfiguredRulesVocabularyAbbreviations? abbreviations,
            global::G.ConfiguredRulesVocabularyLoanwords? loanwords)
        {
            this.Abbreviations = abbreviations;
            this.Loanwords = loanwords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesVocabulary" /> class.
        /// </summary>
        public ConfiguredRulesVocabulary()
        {
        }
    }
}