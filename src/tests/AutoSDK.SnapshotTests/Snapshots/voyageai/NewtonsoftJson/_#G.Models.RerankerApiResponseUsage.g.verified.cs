//HintName: G.Models.RerankerApiResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankerApiResponseUsage
    {
        /// <summary>
        /// The total number of tokens used for computing the reranking.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerApiResponseUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The total number of tokens used for computing the reranking.
        /// </param>
        public RerankerApiResponseUsage(
            int? totalTokens)
        {
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerApiResponseUsage" /> class.
        /// </summary>
        public RerankerApiResponseUsage()
        {
        }
    }
}