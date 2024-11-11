//HintName: G.Models.SchemaClusterStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the health of the schema in a cluster.
    /// </summary>
    public sealed partial class SchemaClusterStatus
    {
        /// <summary>
        /// True if the cluster is in sync, false if there is an issue (see error).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthy")]
        public bool? Healthy { get; set; }

        /// <summary>
        /// Contains the sync check error if one occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Hostname of the coordinating node, i.e. the one that received the cluster. This can be useful information if the error message contains phrases such as 'other nodes agree, but local does not', etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Number of nodes that participated in the sync check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeCount")]
        public double? NodeCount { get; set; }

        /// <summary>
        /// The cluster check at startup can be ignored (to recover from an out-of-sync situation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSchemaSync")]
        public bool? IgnoreSchemaSync { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaClusterStatus" /> class.
        /// </summary>
        /// <param name="healthy">
        /// True if the cluster is in sync, false if there is an issue (see error).
        /// </param>
        /// <param name="error">
        /// Contains the sync check error if one occurred
        /// </param>
        /// <param name="hostname">
        /// Hostname of the coordinating node, i.e. the one that received the cluster. This can be useful information if the error message contains phrases such as 'other nodes agree, but local does not', etc.
        /// </param>
        /// <param name="nodeCount">
        /// Number of nodes that participated in the sync check
        /// </param>
        /// <param name="ignoreSchemaSync">
        /// The cluster check at startup can be ignored (to recover from an out-of-sync situation).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SchemaClusterStatus(
            bool? healthy,
            string? error,
            string? hostname,
            double? nodeCount,
            bool? ignoreSchemaSync)
        {
            this.Healthy = healthy;
            this.Error = error;
            this.Hostname = hostname;
            this.NodeCount = nodeCount;
            this.IgnoreSchemaSync = ignoreSchemaSync;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaClusterStatus" /> class.
        /// </summary>
        public SchemaClusterStatus()
        {
        }
    }
}