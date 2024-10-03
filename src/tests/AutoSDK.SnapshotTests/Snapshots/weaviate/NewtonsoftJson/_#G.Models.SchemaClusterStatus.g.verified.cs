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
        [global::Newtonsoft.Json.JsonProperty("healthy")]
        public bool? Healthy { get; set; }

        /// <summary>
        /// Contains the sync check error if one occurred
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Hostname of the coordinating node, i.e. the one that received the cluster. This can be useful information if the error message contains phrases such as 'other nodes agree, but local does not', etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Number of nodes that participated in the sync check
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodeCount")]
        public double? NodeCount { get; set; }

        /// <summary>
        /// The cluster check at startup can be ignored (to recover from an out-of-sync situation).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignoreSchemaSync")]
        public bool? IgnoreSchemaSync { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}