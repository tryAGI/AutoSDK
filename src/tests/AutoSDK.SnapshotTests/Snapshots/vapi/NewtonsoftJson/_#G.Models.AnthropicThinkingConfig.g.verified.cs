//HintName: G.Models.AnthropicThinkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicThinkingConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AnthropicThinkingConfigType Type { get; set; }

        /// <summary>
        /// The maximum number of tokens to allocate for thinking.<br/>
        /// Must be between 1024 and 100000 tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budgetTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double BudgetTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingConfig" /> class.
        /// </summary>
        /// <param name="budgetTokens">
        /// The maximum number of tokens to allocate for thinking.<br/>
        /// Must be between 1024 and 100000 tokens.
        /// </param>
        /// <param name="type"></param>
        public AnthropicThinkingConfig(
            double budgetTokens,
            global::G.AnthropicThinkingConfigType type)
        {
            this.Type = type;
            this.BudgetTokens = budgetTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingConfig" /> class.
        /// </summary>
        public AnthropicThinkingConfig()
        {
        }
    }
}