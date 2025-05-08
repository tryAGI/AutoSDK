//HintName: G.Models.EvalRunOutputItemSampleUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Token usage details for the sample.
    /// </summary>
    public sealed partial class EvalRunOutputItemSampleUsage
    {
        /// <summary>
        /// The total number of tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// The number of completion tokens generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletionTokens { get; set; } = default!;

        /// <summary>
        /// The number of prompt tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSampleUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The total number of tokens used.
        /// </param>
        /// <param name="completionTokens">
        /// The number of completion tokens generated.
        /// </param>
        /// <param name="promptTokens">
        /// The number of prompt tokens used.
        /// </param>
        /// <param name="cachedTokens">
        /// The number of tokens retrieved from cache.
        /// </param>
        public EvalRunOutputItemSampleUsage(
            int totalTokens,
            int completionTokens,
            int promptTokens,
            int cachedTokens)
        {
            this.TotalTokens = totalTokens;
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSampleUsage" /> class.
        /// </summary>
        public EvalRunOutputItemSampleUsage()
        {
        }
    }
}