//HintName: G.Models.LLMParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMParameters
    {
        /// <summary>
        /// The name of the model to use for LLM completions.<br/>
        /// Default Value: GPT_4O_MINI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SupportedLLMModelNamesJsonConverter))]
        public global::G.SupportedLLMModelNames? ModelName { get; set; }

        /// <summary>
        /// The system prompt to use for the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// The temperature value for the model.<br/>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Whether to use chain of thought reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_chain_of_thought_reasoning")]
        public bool? UseChainOfThoughtReasoning { get; set; }

        /// <summary>
        /// Whether to show citations in the response.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_citation")]
        public bool? UseCitation { get; set; }

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMParameters" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the model to use for LLM completions.<br/>
        /// Default Value: GPT_4O_MINI
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt to use for the completion.
        /// </param>
        /// <param name="temperature">
        /// The temperature value for the model.<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="useChainOfThoughtReasoning">
        /// Whether to use chain of thought reasoning.
        /// </param>
        /// <param name="useCitation">
        /// Whether to show citations in the response.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMParameters(
            global::G.SupportedLLMModelNames? modelName,
            string? systemPrompt,
            double? temperature,
            bool? useChainOfThoughtReasoning,
            bool? useCitation,
            string? className)
        {
            this.ModelName = modelName;
            this.SystemPrompt = systemPrompt;
            this.Temperature = temperature;
            this.UseChainOfThoughtReasoning = useChainOfThoughtReasoning;
            this.UseCitation = useCitation;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMParameters" /> class.
        /// </summary>
        public LLMParameters()
        {
        }
    }
}