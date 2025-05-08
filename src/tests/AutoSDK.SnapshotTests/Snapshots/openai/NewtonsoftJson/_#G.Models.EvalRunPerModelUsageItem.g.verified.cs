//HintName: G.Models.EvalRunPerModelUsageItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalRunPerModelUsageItem
    {
        /// <summary>
        /// The name of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// The number of invocations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invocation_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int InvocationCount { get; set; } = default!;

        /// <summary>
        /// The number of prompt tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// The number of completion tokens generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletionTokens { get; set; } = default!;

        /// <summary>
        /// The total number of tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// The number of tokens retrieved from cache.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CachedTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunPerModelUsageItem" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the model.
        /// </param>
        /// <param name="invocationCount">
        /// The number of invocations.
        /// </param>
        /// <param name="promptTokens">
        /// The number of prompt tokens used.
        /// </param>
        /// <param name="completionTokens">
        /// The number of completion tokens generated.
        /// </param>
        /// <param name="totalTokens">
        /// The total number of tokens used.
        /// </param>
        /// <param name="cachedTokens">
        /// The number of tokens retrieved from cache.
        /// </param>
        public EvalRunPerModelUsageItem(
            string modelName,
            int invocationCount,
            int promptTokens,
            int completionTokens,
            int totalTokens,
            int cachedTokens)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.InvocationCount = invocationCount;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunPerModelUsageItem" /> class.
        /// </summary>
        public EvalRunPerModelUsageItem()
        {
        }
    }
}