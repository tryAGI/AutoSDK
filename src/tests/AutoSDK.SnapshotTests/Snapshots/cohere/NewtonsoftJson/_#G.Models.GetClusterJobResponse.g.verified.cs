﻿//HintName: G.Models.GetClusterJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for getting a cluster job.
    /// </summary>
    public sealed partial class GetClusterJobResponse
    {
        /// <summary>
        /// The list of cluster summaries for the job<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clusters")]
        public global::System.Collections.Generic.IList<global::G.Cluster>? Clusters { get; set; }

        /// <summary>
        /// Time of job creation in RFC3339 format<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The input file URL used for the job<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings_url")]
        public string? EmbeddingsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The input dataset ID used for the job<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_dataset_id")]
        public string? InputDatasetId { get; set; }

        /// <summary>
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_deterministic")]
        public bool? IsDeterministic { get; set; }

        /// <summary>
        /// A boolean indicating whether the job is in a final state, whether completed or failed<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_final_state")]
        public bool? IsFinalState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_cluster_size")]
        public int? MinClusterSize { get; set; }

        /// <summary>
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_neighbors")]
        public int? NNeighbors { get; set; }

        /// <summary>
        /// The output file URL for the clusters (signed url that expires)<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_clusters_url")]
        public string? OutputClustersUrl { get; set; }

        /// <summary>
        /// The output file URL for the outliers (signed url that expires)<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_outliers_url")]
        public string? OutputOutliersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.GetClusterJobResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClusterJobResponse" /> class.
        /// </summary>
        /// <param name="clusters">
        /// The list of cluster summaries for the job<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Time of job creation in RFC3339 format<br/>
        /// Included only in responses
        /// </param>
        /// <param name="embeddingsUrl">
        /// The input file URL used for the job<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error"></param>
        /// <param name="inputDatasetId">
        /// The input dataset ID used for the job<br/>
        /// Included only in responses
        /// </param>
        /// <param name="isDeterministic">
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </param>
        /// <param name="isFinalState">
        /// A boolean indicating whether the job is in a final state, whether completed or failed<br/>
        /// Included only in responses
        /// </param>
        /// <param name="jobId"></param>
        /// <param name="meta"></param>
        /// <param name="minClusterSize">
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nNeighbors">
        /// The parameter used in the job creation. Please refer to the job creation endpoint for more details<br/>
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
        /// <param name="status"></param>
        public GetClusterJobResponse(
            string jobId,
            global::System.Collections.Generic.IList<global::G.Cluster>? clusters,
            global::System.DateTime? createdAt,
            string? embeddingsUrl,
            string? error,
            string? inputDatasetId,
            bool? isDeterministic,
            bool? isFinalState,
            global::G.ApiMeta? meta,
            int? minClusterSize,
            int? nNeighbors,
            string? outputClustersUrl,
            string? outputOutliersUrl,
            global::G.GetClusterJobResponseStatus? status)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Clusters = clusters;
            this.CreatedAt = createdAt;
            this.EmbeddingsUrl = embeddingsUrl;
            this.Error = error;
            this.InputDatasetId = inputDatasetId;
            this.IsDeterministic = isDeterministic;
            this.IsFinalState = isFinalState;
            this.Meta = meta;
            this.MinClusterSize = minClusterSize;
            this.NNeighbors = nNeighbors;
            this.OutputClustersUrl = outputClustersUrl;
            this.OutputOutliersUrl = outputOutliersUrl;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClusterJobResponse" /> class.
        /// </summary>
        public GetClusterJobResponse()
        {
        }
    }
}