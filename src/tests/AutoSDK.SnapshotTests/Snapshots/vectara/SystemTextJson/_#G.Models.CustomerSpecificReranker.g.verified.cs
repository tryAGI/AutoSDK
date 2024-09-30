//HintName: G.Models.CustomerSpecificReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reranker that is specific to the customer.
    /// </summary>
    public sealed partial class CustomerSpecificReranker
    {
        /// <summary>
        /// When type is is `customer_reranker`, you can specify the `reranker_name` of a reranker. `reranker_id` is deprecated.<br/>
        /// The retrieval engine will then rerank results using that reranker.<br/>
        /// Default Value: customer_reranker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "customer_reranker";

        /// <summary>
        /// The ID of the reranker. Current reranker that may be used by Scale customers is rnk_272725719.<br/>
        /// Do not specify the MMR reranker ID here, and instead use the MMR reranker object type.<br/>
        /// **Deprecated**: Use `reranker_name` instead.<br/>
        /// Example: rnk_272725719
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reranker_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RerankerId { get; set; }

        /// <summary>
        /// The name of the reranker. Do not specify the MMR reranker name here. Instead use the MMR reranker object type.<br/>
        /// Example: Rerank_Multilingual_v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reranker_name")]
        public string? RerankerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}