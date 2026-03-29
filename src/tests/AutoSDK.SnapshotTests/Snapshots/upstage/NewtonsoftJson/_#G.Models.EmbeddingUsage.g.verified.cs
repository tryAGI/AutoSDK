//HintName: G.Models.EmbeddingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingUsage
    {
        /// <summary>
        /// The number of tokens in the input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// The total number of tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// The number of tokens in the input.
        /// </param>
        /// <param name="totalTokens">
        /// The total number of tokens used.
        /// </param>
        public EmbeddingUsage(
            int? promptTokens,
            int? totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsage" /> class.
        /// </summary>
        public EmbeddingUsage()
        {
        }
    }
}