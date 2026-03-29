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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkflowAnthropicModelProviderJsonConverter))]
        public global::G.WorkflowAnthropicModelProvider Provider { get; set; }

        /// <summary>
        /// This is the specific model that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkflowAnthropicModelModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkflowAnthropicModelModel Model { get; set; }

        /// <summary>
        /// This is the optional configuration for Anthropic's thinking feature.<br/>
        /// - If provided, `maxTokens` must be greater than `thinking.budgetTokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::G.AnthropicThinkingConfig? Thinking { get; set; }

        /// <summary>
        /// This is the temperature of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max tokens of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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