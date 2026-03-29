//HintName: G.Models.WorkflowAnthropicModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowAnthropicModel
    {
        /// <summary>
        /// This is the provider of the model (`anthropic`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.WorkflowAnthropicModelProvider Provider { get; set; }

        /// <summary>
        /// This is the specific model that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WorkflowAnthropicModelModel Model { get; set; } = default!;

        /// <summary>
        /// This is the optional configuration for Anthropic's thinking feature.<br/>
        /// - If provided, `maxTokens` must be greater than `thinking.budgetTokens`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinking")]
        public global::G.AnthropicThinkingConfig? Thinking { get; set; }

        /// <summary>
        /// This is the temperature of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max tokens of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAnthropicModel" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the specific model that will be used.
        /// </param>
        /// <param name="provider">
        /// This is the provider of the model (`anthropic`).
        /// </param>
        /// <param name="thinking">
        /// This is the optional configuration for Anthropic's thinking feature.<br/>
        /// - If provided, `maxTokens` must be greater than `thinking.budgetTokens`.
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.
        /// </param>
        public WorkflowAnthropicModel(
            global::G.WorkflowAnthropicModelModel model,
            global::G.WorkflowAnthropicModelProvider provider,
            global::G.AnthropicThinkingConfig? thinking,
            double? temperature,
            double? maxTokens)
        {
            this.Provider = provider;
            this.Model = model;
            this.Thinking = thinking;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAnthropicModel" /> class.
        /// </summary>
        public WorkflowAnthropicModel()
        {
        }
    }
}