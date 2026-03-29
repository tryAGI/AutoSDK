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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Commit of the orchestrator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Commit { get; set; }

        /// <summary>
        /// Identifier of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Service instance identifier of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceInstanceID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceInstanceID { get; set; }

        /// <summary>
        /// Identifier of the cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClusterID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MachineInfo MachineInfo { get; set; }

        /// <summary>
        /// Status of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NodeStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NodeStatus Status { get; set; }

        /// <summary>
        /// Number of sandboxes running on the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SandboxCount { get; set; }

        /// <summary>
        /// Node metrics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NodeMetrics Metrics { get; set; }

        /// <summary>
        /// Number of sandbox create successes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createSuccesses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreateSuccesses { get; set; }

        /// <summary>
        /// Number of sandbox create fails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createFails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreateFails { get; set; }

        /// <summary>
        /// Number of starting Sandboxes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxStartingCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SandboxStartingCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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