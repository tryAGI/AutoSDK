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
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tracer_session_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TracerSessionCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepoCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_queue_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int AnnotationQueueCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int DeploymentCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dashboards_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int DashboardsCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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