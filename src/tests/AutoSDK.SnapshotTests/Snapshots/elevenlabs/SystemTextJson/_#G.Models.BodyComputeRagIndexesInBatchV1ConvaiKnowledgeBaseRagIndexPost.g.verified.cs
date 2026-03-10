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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetOrCreateRAGIndexRequestModel> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost" /> class.
        /// </summary>
        /// <param name="items">
        /// List of requested RAG indexes. Minimum 1, maximum 100 items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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