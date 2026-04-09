//HintName: G.Models.NodeDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeDetail
    {
        /// <summary>
        /// Identifier of the cluster
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clusterID", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClusterID { get; set; } = default!;

        /// <summary>
        /// Version of the orchestrator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Commit of the orchestrator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Commit { get; set; } = default!;

        /// <summary>
        /// Identifier of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Service instance identifier of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serviceInstanceID", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServiceInstanceID { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("machineInfo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MachineInfo MachineInfo { get; set; } = default!;

        /// <summary>
        /// Status of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NodeStatusJsonConverter))]
        public global::G.NodeStatus Status { get; set; } = default!;

        /// <summary>
        /// Number of sandboxes running on the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandboxCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int SandboxCount { get; set; } = default!;

        /// <summary>
        /// Node metrics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NodeMetrics Metrics { get; set; } = default!;

        /// <summary>
        /// List of cached builds id on the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cachedBuilds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> CachedBuilds { get; set; } = default!;

        /// <summary>
        /// Number of sandbox create successes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createSuccesses", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreateSuccesses { get; set; } = default!;

        /// <summary>
        /// Number of sandbox create fails
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createFails", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreateFails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeDetail" /> class.
        /// </summary>
        /// <param name="clusterID">
        /// Identifier of the cluster
        /// </param>
        /// <param name="version">
        /// Version of the orchestrator
        /// </param>
        /// <param name="commit">
        /// Commit of the orchestrator
        /// </param>
        /// <param name="id">
        /// Identifier of the node
        /// </param>
        /// <param name="serviceInstanceID">
        /// Service instance identifier of the node
        /// </param>
        /// <param name="machineInfo"></param>
        /// <param name="status">
        /// Status of the node
        /// </param>
        /// <param name="sandboxCount">
        /// Number of sandboxes running on the node
        /// </param>
        /// <param name="metrics">
        /// Node metrics
        /// </param>
        /// <param name="cachedBuilds">
        /// List of cached builds id on the node
        /// </param>
        /// <param name="createSuccesses">
        /// Number of sandbox create successes
        /// </param>
        /// <param name="createFails">
        /// Number of sandbox create fails
        /// </param>
        public NodeDetail(
            string clusterID,
            string version,
            string commit,
            string id,
            string serviceInstanceID,
            global::G.MachineInfo machineInfo,
            global::G.NodeStatus status,
            int sandboxCount,
            global::G.NodeMetrics metrics,
            global::System.Collections.Generic.IList<string> cachedBuilds,
            int createSuccesses,
            int createFails)
        {
            this.ClusterID = clusterID ?? throw new global::System.ArgumentNullException(nameof(clusterID));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServiceInstanceID = serviceInstanceID ?? throw new global::System.ArgumentNullException(nameof(serviceInstanceID));
            this.MachineInfo = machineInfo ?? throw new global::System.ArgumentNullException(nameof(machineInfo));
            this.Status = status;
            this.SandboxCount = sandboxCount;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.CachedBuilds = cachedBuilds ?? throw new global::System.ArgumentNullException(nameof(cachedBuilds));
            this.CreateSuccesses = createSuccesses;
            this.CreateFails = createFails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeDetail" /> class.
        /// </summary>
        public NodeDetail()
        {
        }
    }
}