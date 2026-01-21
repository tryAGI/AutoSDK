//HintName: G.Models.GetClusterJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for getting a cluster job.
    /// </summary>
    public sealed partial class GetClusterJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Time of job creation in RFC3339 format<br/>
        /// Included only in responses<br/>
        /// Example: 2023-04-28T21:00:56.646257Z
        /// </summary>
        /// <example>2023-04-28T21:00:56.646257Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The input file URL used for the job<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings_url")]
        public string? EmbeddingsUrl { get; set; }

        /// <summary>
        /// The input dataset ID used for the job<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_dataset_id")]
        public string? InputDatasetId { get; set; }

        /// <summary>
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_cluster_size")]
        public int? MinClusterSize { get; set; }

        /// <summary>
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_neighbors")]
        public int? NNeighbors { get; set; }

        /// <summary>
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deterministic")]
        public bool? IsDeterministic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetClusterJobResponseStatusJsonConverter))]
        public global::G.GetClusterJobResponseStatus? Status { get; set; }

        /// <summary>
        /// A boolean indicating whether the job is in a final state, whether completed or failed<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final_state")]
        public bool? IsFinalState { get; set; }

        /// <summary>
        /// The output file URL for the clusters (signed url that expires)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_clusters_url")]
        public string? OutputClustersUrl { get; set; }

        /// <summary>
        /// The output file URL for the outliers (signed url that expires)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_outliers_url")]
        public string? OutputOutliersUrl { get; set; }

        /// <summary>
        /// The list of cluster summaries for the job<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusters")]
        public global::System.Collections.Generic.IList<global::G.Cluster>? Clusters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClusterJobResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="createdAt">
        /// Time of job creation in RFC3339 format<br/>
        /// Included only in responses<br/>
        /// Example: 2023-04-28T21:00:56.646257Z
        /// </param>
        /// <param name="embeddingsUrl">
        /// The input file URL used for the job<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputDatasetId">
        /// The input dataset ID used for the job<br/>
        /// Included only in responses
        /// </param>
        /// <param name="minClusterSize">
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nNeighbors">
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </param>
        /// <param name="isDeterministic">
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status"></param>
        /// <param name="isFinalState">
        /// A boolean indicating whether the job is in a final state, whether completed or failed<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputClustersUrl">
        /// The output file URL for the clusters (signed url that expires)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputOutliersUrl">
        /// The output file URL for the outliers (signed url that expires)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="clusters">
        /// The list of cluster summaries for the job<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetClusterJobResponse(
            string jobId,
            global::System.DateTime? createdAt,
            string? embeddingsUrl,
            string? inputDatasetId,
            int? minClusterSize,
            int? nNeighbors,
            bool? isDeterministic,
            global::G.GetClusterJobResponseStatus? status,
            bool? isFinalState,
            string? outputClustersUrl,
            string? outputOutliersUrl,
            global::System.Collections.Generic.IList<global::G.Cluster>? clusters,
            string? error,
            global::G.ApiMeta? meta)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.CreatedAt = createdAt;
            this.EmbeddingsUrl = embeddingsUrl;
            this.InputDatasetId = inputDatasetId;
            this.MinClusterSize = minClusterSize;
            this.NNeighbors = nNeighbors;
            this.IsDeterministic = isDeterministic;
            this.Status = status;
            this.IsFinalState = isFinalState;
            this.OutputClustersUrl = outputClustersUrl;
            this.OutputOutliersUrl = outputOutliersUrl;
            this.Clusters = clusters;
            this.Error = error;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClusterJobResponse" /> class.
        /// </summary>
        public GetClusterJobResponse()
        {
        }
    }
}