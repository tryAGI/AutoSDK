//HintName: G.Models.PromptAnthropicThinkingConfigEnabled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicThinkingConfigEnabled
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigEnabled" /> class.
        /// </summary>
        /// <param name="budgetTokens"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAnthropicThinkingConfigEnabled(
            int budgetTokens,
            string type = "enabled")
        {
            this.Type = type;
            this.BudgetTokens = budgetTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigEnabled" /> class.
        /// </summary>
        public PromptAnthropicThinkingConfigEnabled()
        {
        }
    }
}