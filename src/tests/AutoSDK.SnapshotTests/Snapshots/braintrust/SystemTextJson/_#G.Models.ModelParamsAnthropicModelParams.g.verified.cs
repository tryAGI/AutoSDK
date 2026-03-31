//HintName: G.Models.ModelParamsAnthropicModelParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelParamsAnthropicModelParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cache")]
        public bool? UseCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_enabled")]
        public bool? ReasoningEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_budget")]
        public double? ReasoningBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public double? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// This is a legacy parameter that should not be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_to_sample")]
        public double? MaxTokensToSample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsAnthropicModelParams" /> class.
        /// </summary>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="useCache"></param>
        /// <param name="reasoningEnabled"></param>
        /// <param name="reasoningBudget"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="stopSequences"></param>
        /// <param name="maxTokensToSample">
        /// This is a legacy parameter that should not be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelParamsAnthropicModelParams(
            double maxTokens,
            double temperature,
            bool? useCache,
            bool? reasoningEnabled,
            double? reasoningBudget,
            double? topP,
            double? topK,
            global::System.Collections.Generic.IList<string>? stopSequences,
            double? maxTokensToSample)
        {
            this.UseCache = useCache;
            this.ReasoningEnabled = reasoningEnabled;
            this.ReasoningBudget = reasoningBudget;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.StopSequences = stopSequences;
            this.MaxTokensToSample = maxTokensToSample;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsAnthropicModelParams" /> class.
        /// </summary>
        public ModelParamsAnthropicModelParams()
        {
        }
    }
}