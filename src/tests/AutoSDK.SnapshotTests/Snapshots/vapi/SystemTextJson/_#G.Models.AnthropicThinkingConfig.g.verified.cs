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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnthropicThinkingConfigTypeJsonConverter))]
        public global::G.AnthropicThinkingConfigType Type { get; set; }

        /// <summary>
        /// The maximum number of tokens to allocate for thinking.<br/>
        /// Must be between 1024 and 100000 tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budgetTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BudgetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingConfig" /> class.
        /// </summary>
        /// <param name="budgetTokens">
        /// The maximum number of tokens to allocate for thinking.<br/>
        /// Must be between 1024 and 100000 tokens.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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