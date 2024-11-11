//HintName: G.Models.CreateClusterJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClusterJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddingsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_dataset_id")]
        public string? InputDatasetId { get; set; }

        /// <summary>
        /// Defaults to `10`. Parameter for HDBSCAN. Only clusters with this number of elements will be returned with a positive cluster number.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_cluster_size")]
        public int? MinClusterSize { get; set; }

        /// <summary>
        /// Parameter for UMAP. A scalar governing how to balance global vs local structure in the data.<br/>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_neighbors")]
        public int? NNeighbors { get; set; }

        /// <summary>
        /// Parameter for UMAP. A boolean governing whether the embeddings from UMAP (that will be clustered with HDBSCAN) are deterministic.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deterministic")]
        public bool? IsDeterministic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_descriptions")]
        public bool? GenerateDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClusterJobRequest" /> class.
        /// </summary>
        /// <param name="embeddingsUrl"></param>
        /// <param name="inputDatasetId"></param>
        /// <param name="minClusterSize">
        /// Defaults to `10`. Parameter for HDBSCAN. Only clusters with this number of elements will be returned with a positive cluster number.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="nNeighbors">
        /// Parameter for UMAP. A scalar governing how to balance global vs local structure in the data.<br/>
        /// Default Value: 15
        /// </param>
        /// <param name="isDeterministic">
        /// Parameter for UMAP. A boolean governing whether the embeddings from UMAP (that will be clustered with HDBSCAN) are deterministic.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="generateDescriptions"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateClusterJobRequest(
            string embeddingsUrl,
            string? inputDatasetId,
            int? minClusterSize,
            int? nNeighbors,
            bool? isDeterministic,
            bool? generateDescriptions)
        {
            this.EmbeddingsUrl = embeddingsUrl ?? throw new global::System.ArgumentNullException(nameof(embeddingsUrl));
            this.InputDatasetId = inputDatasetId;
            this.MinClusterSize = minClusterSize;
            this.NNeighbors = nNeighbors;
            this.IsDeterministic = isDeterministic;
            this.GenerateDescriptions = generateDescriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClusterJobRequest" /> class.
        /// </summary>
        public CreateClusterJobRequest()
        {
        }
    }
}