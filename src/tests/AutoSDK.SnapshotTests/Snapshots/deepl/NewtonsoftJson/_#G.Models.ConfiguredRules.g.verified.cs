//HintName: G.Models.ConfiguredRules.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.
    /// </summary>
    public sealed partial class ConfiguredRules
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dates_and_times")]
        public global::G.ConfiguredRulesDatesAndTimes? DatesAndTimes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("formatting")]
        public global::G.ConfiguredRulesFormatting? Formatting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numbers")]
        public global::G.ConfiguredRulesNumbers? Numbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("punctuation")]
        public global::G.ConfiguredRulesPunctuation? Punctuation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spelling_and_grammar")]
        public global::G.ConfiguredRulesSpellingAndGrammar? SpellingAndGrammar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style_and_tone")]
        public global::G.ConfiguredRulesStyleAndTone? StyleAndTone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vocabulary")]
        public global::G.ConfiguredRulesVocabulary? Vocabulary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRules" /> class.
        /// </summary>
        /// <param name="datesAndTimes"></param>
        /// <param name="formatting"></param>
        /// <param name="numbers"></param>
        /// <param name="punctuation"></param>
        /// <param name="spellingAndGrammar"></param>
        /// <param name="styleAndTone"></param>
        /// <param name="vocabulary"></param>
        public ConfiguredRules(
            global::G.ConfiguredRulesDatesAndTimes? datesAndTimes,
            global::G.ConfiguredRulesFormatting? formatting,
            global::G.ConfiguredRulesNumbers? numbers,
            global::G.ConfiguredRulesPunctuation? punctuation,
            global::G.ConfiguredRulesSpellingAndGrammar? spellingAndGrammar,
            global::G.ConfiguredRulesStyleAndTone? styleAndTone,
            global::G.ConfiguredRulesVocabulary? vocabulary)
        {
            this.DatesAndTimes = datesAndTimes;
            this.Formatting = formatting;
            this.Numbers = numbers;
            this.Punctuation = punctuation;
            this.SpellingAndGrammar = spellingAndGrammar;
            this.StyleAndTone = styleAndTone;
            this.Vocabulary = vocabulary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRules" /> class.
        /// </summary>
        public ConfiguredRules()
        {
        }
    }
}