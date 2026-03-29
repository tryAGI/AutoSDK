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
        [global::System.Text.Json.Serialization.JsonPropertyName("abbreviations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesVocabularyAbbreviationsJsonConverter))]
        public global::G.ConfiguredRulesVocabularyAbbreviations? Abbreviations { get; set; }

        /// <summary>
        /// Formatting options for Loanwords
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loanwords")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfiguredRulesVocabularyLoanwordsJsonConverter))]
        public global::G.ConfiguredRulesVocabularyLoanwords? Loanwords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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