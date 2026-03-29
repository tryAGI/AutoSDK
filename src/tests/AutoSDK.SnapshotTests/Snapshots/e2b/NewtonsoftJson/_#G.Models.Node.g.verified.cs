//HintName: G.Models.Node.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Node
    {
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
        /// Identifier of the cluster
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clusterID", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClusterID { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("machineInfo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MachineInfo MachineInfo { get; set; } = default!;

        /// <summary>
        /// Status of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
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
        /// Number of starting Sandboxes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandboxStartingCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int SandboxStartingCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Node" /> class.
        /// </summary>
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
        /// <param name="clusterID">
        /// Identifier of the cluster
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
        /// <param name="createSuccesses">
        /// Number of sandbox create successes
        /// </param>
        /// <param name="createFails">
        /// Number of sandbox create fails
        /// </param>
        /// <param name="sandboxStartingCount">
        /// Number of starting Sandboxes
        /// </param>
        public Node(
            string version,
            string commit,
            string id,
            string serviceInstanceID,
            string clusterID,
            global::G.MachineInfo machineInfo,
            global::G.NodeStatus status,
            int sandboxCount,
            global::G.NodeMetrics metrics,
            int createSuccesses,
            int createFails,
            int sandboxStartingCount)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ServiceInstanceID = serviceInstanceID ?? throw new global::System.ArgumentNullException(nameof(serviceInstanceID));
            this.ClusterID = clusterID ?? throw new global::System.ArgumentNullException(nameof(clusterID));
            this.MachineInfo = machineInfo ?? throw new global::System.ArgumentNullException(nameof(machineInfo));
            this.Status = status;
            this.SandboxCount = sandboxCount;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.CreateSuccesses = createSuccesses;
            this.CreateFails = createFails;
            this.SandboxStartingCount = sandboxStartingCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node" /> class.
        /// </summary>
        public Node()
        {
        }
    }
}