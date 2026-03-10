//HintName: G.Models.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost
    {
        /// <summary>
        /// List of requested RAG indexes. Minimum 1, maximum 100 items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetOrCreateRAGIndexRequestModel> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost" /> class.
        /// </summary>
        /// <param name="items">
        /// List of requested RAG indexes. Minimum 1, maximum 100 items.
        /// </param>
        public BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost(
            global::System.Collections.Generic.IList<global::G.GetOrCreateRAGIndexRequestModel> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost" /> class.
        /// </summary>
        public BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost()
        {
        }
    }
}