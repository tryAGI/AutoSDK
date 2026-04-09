//HintName: G.Models.PromptOpenAIInvocationParametersContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOpenAIInvocationParametersContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortJsonConverter))]
        public global::G.PromptOpenAIInvocationParametersContentReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOpenAIInvocationParametersContent" /> class.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="topP"></param>
        /// <param name="seed"></param>
        /// <param name="reasoningEffort"></param>
        public PromptOpenAIInvocationParametersContent(
            double? temperature,
            int? maxTokens,
            int? maxCompletionTokens,
            double? frequencyPenalty,
            double? presencePenalty,
            double? topP,
            int? seed,
            global::G.PromptOpenAIInvocationParametersContentReasoningEffort? reasoningEffort)
        {
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.TopP = topP;
            this.Seed = seed;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOpenAIInvocationParametersContent" /> class.
        /// </summary>
        public PromptOpenAIInvocationParametersContent()
        {
        }
    }
}