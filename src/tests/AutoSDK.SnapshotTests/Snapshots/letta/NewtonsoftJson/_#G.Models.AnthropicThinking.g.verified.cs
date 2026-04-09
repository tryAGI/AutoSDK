//HintName: G.Models.AnthropicThinking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicThinking
    {
        /// <summary>
        /// The type of thinking to use.<br/>
        /// Default Value: enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AnthropicThinkingTypeJsonConverter))]
        public global::G.AnthropicThinkingType? Type { get; set; }

        /// <summary>
        /// The maximum number of tokens the model can use for extended thinking.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budget_tokens")]
        public int? BudgetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinking" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of thinking to use.<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="budgetTokens">
        /// The maximum number of tokens the model can use for extended thinking.<br/>
        /// Default Value: 1024
        /// </param>
        public AnthropicThinking(
            global::G.AnthropicThinkingType? type,
            int? budgetTokens)
        {
            this.Type = type;
            this.BudgetTokens = budgetTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinking" /> class.
        /// </summary>
        public AnthropicThinking()
        {
        }
    }
}