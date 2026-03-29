//HintName: G.Models.ModelParamsGoogleModelParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelParamsGoogleModelParams
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
        [global::Newtonsoft.Json.JsonProperty("maxOutputTokens")]
        public double? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public double? TopP { get; set; }

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
        /// Initializes a new instance of the <see cref="ModelParamsGoogleModelParams" /> class.
        /// </summary>
        /// <param name="useCache"></param>
        /// <param name="reasoningEnabled"></param>
        /// <param name="reasoningBudget"></param>
        /// <param name="temperature"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        public ModelParamsGoogleModelParams(
            bool? useCache,
            bool? reasoningEnabled,
            double? reasoningBudget,
            double? temperature,
            double? maxOutputTokens,
            double? topP,
            double? topK)
        {
            this.UseCache = useCache;
            this.ReasoningEnabled = reasoningEnabled;
            this.ReasoningBudget = reasoningBudget;
            this.Temperature = temperature;
            this.MaxOutputTokens = maxOutputTokens;
            this.TopP = topP;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsGoogleModelParams" /> class.
        /// </summary>
        public ModelParamsGoogleModelParams()
        {
        }
    }
}