//HintName: G.Models.CreateChatCompletionRequestThinking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// View the thinking/reasoning tokens as part of your response. Thinking models produce a long internal chain of thought before generating a response. Supported only for specific Claude models on Anthropic, Google Vertex AI, and AWS Bedrock.  Requires setting `strict_openai_compliance = false` in your API call.<br/>
    /// Example: {"type":"enabled","budget_tokens":2030}
    /// </summary>
    public sealed partial class CreateChatCompletionRequestThinking
    {
        /// <summary>
        /// Enables or disables the thinking mode capability.<br/>
        /// Default Value: disabled
        /// </summary>
        /// <default>global::G.CreateChatCompletionRequestThinkingType.Disabled</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter))]
        public global::G.CreateChatCompletionRequestThinkingType Type { get; set; } = default!;

        /// <summary>
        /// The maximum number of tokens to allocate for the thinking process.<br/>
        /// A higher token budget allows for more thorough reasoning but may increase overall response time.<br/>
        /// Example: 2030
        /// </summary>
        /// <example>2030</example>
        [global::Newtonsoft.Json.JsonProperty("budget_tokens")]
        public int? BudgetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestThinking" /> class.
        /// </summary>
        /// <param name="type">
        /// Enables or disables the thinking mode capability.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="budgetTokens">
        /// The maximum number of tokens to allocate for the thinking process.<br/>
        /// A higher token budget allows for more thorough reasoning but may increase overall response time.<br/>
        /// Example: 2030
        /// </param>
        public CreateChatCompletionRequestThinking(
            global::G.CreateChatCompletionRequestThinkingType type,
            int? budgetTokens)
        {
            this.Type = type;
            this.BudgetTokens = budgetTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestThinking" /> class.
        /// </summary>
        public CreateChatCompletionRequestThinking()
        {
        }
    }
}