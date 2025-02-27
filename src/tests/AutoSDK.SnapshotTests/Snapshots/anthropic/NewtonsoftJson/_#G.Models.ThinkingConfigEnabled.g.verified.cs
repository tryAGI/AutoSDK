//HintName: G.Models.ThinkingConfigEnabled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkingConfigEnabled
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ThinkingConfigEnabledType Type { get; set; }

        /// <summary>
        /// Determines how many tokens Claude can use for its internal reasoning process. Larger budgets can enable more thorough analysis for complex problems, improving response quality. <br/>
        /// Must be ≥1024 and less than `max_tokens`.<br/>
        /// See [extended thinking](https://docs.anthropic.com/en/docs/build-with-claude/extended-thinking) for details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budget_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int BudgetTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfigEnabled" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="budgetTokens">
        /// Determines how many tokens Claude can use for its internal reasoning process. Larger budgets can enable more thorough analysis for complex problems, improving response quality. <br/>
        /// Must be ≥1024 and less than `max_tokens`.<br/>
        /// See [extended thinking](https://docs.anthropic.com/en/docs/build-with-claude/extended-thinking) for details.
        /// </param>
        public ThinkingConfigEnabled(
            int budgetTokens,
            global::G.ThinkingConfigEnabledType type)
        {
            this.BudgetTokens = budgetTokens;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfigEnabled" /> class.
        /// </summary>
        public ThinkingConfigEnabled()
        {
        }
    }
}