//HintName: G.Models.PromptParserNullish.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptParserNullish
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PromptParserNullishType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_cot", Required = global::Newtonsoft.Json.Required.Always)]
        public bool UseCot { get; set; } = default!;

        /// <summary>
        /// Map of choices to scores (0-1). Used by scorers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choice_scores")]
        public global::System.Collections.Generic.Dictionary<string, double>? ChoiceScores { get; set; }

        /// <summary>
        /// List of valid choices without score mapping. Used by classifiers that deposit output to tags.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choice")]
        public global::System.Collections.Generic.IList<string>? Choice { get; set; }

        /// <summary>
        /// If true, adds a 'No match' option. When selected, no tag is deposited.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_no_match")]
        public bool? AllowNoMatch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptParserNullish" /> class.
        /// </summary>
        /// <param name="useCot"></param>
        /// <param name="type"></param>
        /// <param name="choiceScores">
        /// Map of choices to scores (0-1). Used by scorers.
        /// </param>
        /// <param name="choice">
        /// List of valid choices without score mapping. Used by classifiers that deposit output to tags.
        /// </param>
        /// <param name="allowNoMatch">
        /// If true, adds a 'No match' option. When selected, no tag is deposited.
        /// </param>
        public PromptParserNullish(
            bool useCot,
            global::G.PromptParserNullishType type,
            global::System.Collections.Generic.Dictionary<string, double>? choiceScores,
            global::System.Collections.Generic.IList<string>? choice,
            bool? allowNoMatch)
        {
            this.Type = type;
            this.UseCot = useCot;
            this.ChoiceScores = choiceScores;
            this.Choice = choice;
            this.AllowNoMatch = allowNoMatch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptParserNullish" /> class.
        /// </summary>
        public PromptParserNullish()
        {
        }
    }
}