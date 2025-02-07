//HintName: G.Models.TenantStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stats for a tenant.
    /// </summary>
    public sealed partial class TenantStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracer_session_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TracerSessionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepoCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_queue_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AnnotationQueueCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeploymentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboards_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DashboardsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantStats" /> class.
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="datasetCount"></param>
        /// <param name="tracerSessionCount"></param>
        /// <param name="repoCount"></param>
        /// <param name="annotationQueueCount"></param>
        /// <param name="deploymentCount"></param>
        /// <param name="dashboardsCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantStats(
            global::System.Guid tenantId,
            int datasetCount,
            int tracerSessionCount,
            int repoCount,
            int annotationQueueCount,
            int deploymentCount,
            int dashboardsCount)
        {
            this.TenantId = tenantId;
            this.DatasetCount = datasetCount;
            this.TracerSessionCount = tracerSessionCount;
            this.RepoCount = repoCount;
            this.AnnotationQueueCount = annotationQueueCount;
            this.DeploymentCount = deploymentCount;
            this.DashboardsCount = dashboardsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantStats" /> class.
        /// </summary>
        public TenantStats()
        {
        }
    }
}