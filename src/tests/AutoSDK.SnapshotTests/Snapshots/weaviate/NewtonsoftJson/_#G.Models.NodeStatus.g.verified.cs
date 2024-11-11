//HintName: G.Models.NodeStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of a backup node status response body
    /// </summary>
    public sealed partial class NodeStatus
    {
        /// <summary>
        /// The name of the node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Node's status.<br/>
        /// Default Value: HEALTHY
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.NodeStatusStatus? Status { get; set; }

        /// <summary>
        /// The version of Weaviate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The gitHash of Weaviate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gitHash")]
        public string? GitHash { get; set; }

        /// <summary>
        /// The summary of Weaviate's statistics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats")]
        public global::G.NodeStats? Stats { get; set; }

        /// <summary>
        /// The summary of a nodes batch queue congestion status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batchStats")]
        public global::G.BatchStats? BatchStats { get; set; }

        /// <summary>
        /// The list of the shards with it's statistics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shards")]
        public global::System.Collections.Generic.IList<global::G.NodeShardStatus>? Shards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatus" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the node.
        /// </param>
        /// <param name="status">
        /// Node's status.<br/>
        /// Default Value: HEALTHY
        /// </param>
        /// <param name="version">
        /// The version of Weaviate.
        /// </param>
        /// <param name="gitHash">
        /// The gitHash of Weaviate.
        /// </param>
        /// <param name="stats">
        /// The summary of Weaviate's statistics.
        /// </param>
        /// <param name="batchStats">
        /// The summary of a nodes batch queue congestion status.
        /// </param>
        /// <param name="shards">
        /// The list of the shards with it's statistics.
        /// </param>
        public NodeStatus(
            string? name,
            global::G.NodeStatusStatus? status,
            string? version,
            string? gitHash,
            global::G.NodeStats? stats,
            global::G.BatchStats? batchStats,
            global::System.Collections.Generic.IList<global::G.NodeShardStatus>? shards)
        {
            this.Name = name;
            this.Status = status;
            this.Version = version;
            this.GitHash = gitHash;
            this.Stats = stats;
            this.BatchStats = batchStats;
            this.Shards = shards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatus" /> class.
        /// </summary>
        public NodeStatus()
        {
        }
    }
}