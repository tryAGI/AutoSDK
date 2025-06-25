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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ThinkingConfigEnabledTypeJsonConverter))]
        public global::G.ThinkingConfigEnabledType Type { get; set; }

        /// <summary>
        /// Determines how many tokens Claude can use for its internal reasoning process. Larger budgets can enable more thorough analysis for complex problems, improving response quality. <br/>
        /// Must be ≥1024 and less than `max_tokens`.<br/>
        /// See [extended thinking](https://docs.anthropic.com/en/docs/build-with-claude/extended-thinking) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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