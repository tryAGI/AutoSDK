//HintName: G.Models.UpdateClusterJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateClusterJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateClusterJobRequestStatusJsonConverter))]
        public global::G.UpdateClusterJobRequestStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusters")]
        public global::System.Collections.Generic.IList<global::G.Cluster>? Clusters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_clusters_gs_path")]
        public string? OutputClustersGsPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_outliers_gs_path")]
        public string? OutputOutliersGsPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tracking_metrics")]
        public object? InputTrackingMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tracking_metrics")]
        public object? OutputTrackingMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusterJobRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="clusters"></param>
        /// <param name="outputClustersGsPath"></param>
        /// <param name="outputOutliersGsPath"></param>
        /// <param name="error"></param>
        /// <param name="inputTrackingMetrics"></param>
        /// <param name="outputTrackingMetrics"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateClusterJobRequest(
            global::G.UpdateClusterJobRequestStatus? status,
            global::System.Collections.Generic.IList<global::G.Cluster>? clusters,
            string? outputClustersGsPath,
            string? outputOutliersGsPath,
            string? error,
            object? inputTrackingMetrics,
            object? outputTrackingMetrics)
        {
            this.Status = status;
            this.Clusters = clusters;
            this.OutputClustersGsPath = outputClustersGsPath;
            this.OutputOutliersGsPath = outputOutliersGsPath;
            this.Error = error;
            this.InputTrackingMetrics = inputTrackingMetrics;
            this.OutputTrackingMetrics = outputTrackingMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusterJobRequest" /> class.
        /// </summary>
        public UpdateClusterJobRequest()
        {
        }
    }
}