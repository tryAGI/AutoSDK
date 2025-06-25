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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// The number of completion tokens generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// The number of prompt tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// The number of tokens retrieved from cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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