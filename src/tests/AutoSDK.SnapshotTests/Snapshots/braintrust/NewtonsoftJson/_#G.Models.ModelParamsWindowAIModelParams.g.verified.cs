//HintName: G.Models.ModelParamsWindowAIModelParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelParamsWindowAIModelParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_enabled")]
        public bool? ReasoningEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_budget")]
        public double? ReasoningBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public double? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsWindowAIModelParams" /> class.
        /// </summary>
        /// <param name="useCache"></param>
        /// <param name="reasoningEnabled"></param>
        /// <param name="reasoningBudget"></param>
        /// <param name="temperature"></param>
        /// <param name="topK"></param>
        public ModelParamsWindowAIModelParams(
            bool? useCache,
            bool? reasoningEnabled,
            double? reasoningBudget,
            double? temperature,
            double? topK)
        {
            this.UseCache = useCache;
            this.ReasoningEnabled = reasoningEnabled;
            this.ReasoningBudget = reasoningBudget;
            this.Temperature = temperature;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsWindowAIModelParams" /> class.
        /// </summary>
        public ModelParamsWindowAIModelParams()
        {
        }
    }
}