//HintName: G.Models.ModelParamsJsCompletionParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelParamsJsCompletionParams
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsJsCompletionParams" /> class.
        /// </summary>
        /// <param name="useCache"></param>
        /// <param name="reasoningEnabled"></param>
        /// <param name="reasoningBudget"></param>
        public ModelParamsJsCompletionParams(
            bool? useCache,
            bool? reasoningEnabled,
            double? reasoningBudget)
        {
            this.UseCache = useCache;
            this.ReasoningEnabled = reasoningEnabled;
            this.ReasoningBudget = reasoningBudget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsJsCompletionParams" /> class.
        /// </summary>
        public ModelParamsJsCompletionParams()
        {
        }
    }
}