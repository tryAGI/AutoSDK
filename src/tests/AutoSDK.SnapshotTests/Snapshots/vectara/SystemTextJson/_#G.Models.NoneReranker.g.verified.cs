//HintName: G.Models.NoneReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NoneReranker
    {
        /// <summary>
        /// When the type is `none`, no reranking will be done.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "none";

        /// <summary>
        /// Specifies the maximum number of results to be returned after the reranking process. <br/>
        /// When a reranker is applied, it performs the following steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Sorts the reranked results based on their new scores.<br/>
        /// 3. Returns the top N results, where N is the value specified by this limit.<br/>
        /// Note: This limit is applied per reranking stage. In a chain of rerankers, <br/>
        /// each reranker can have its own limit, potentially reducing the number of <br/>
        /// results at each stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}