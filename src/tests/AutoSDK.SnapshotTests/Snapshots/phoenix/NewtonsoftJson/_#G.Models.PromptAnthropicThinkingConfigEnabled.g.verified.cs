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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budget_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int BudgetTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigEnabled" /> class.
        /// </summary>
        /// <param name="budgetTokens"></param>
        /// <param name="type"></param>
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