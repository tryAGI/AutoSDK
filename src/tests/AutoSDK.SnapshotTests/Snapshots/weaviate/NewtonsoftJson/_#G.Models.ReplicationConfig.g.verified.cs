//HintName: G.Models.ReplicationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configure how replication is executed in a cluster
    /// </summary>
    public sealed partial class ReplicationConfig
    {
        /// <summary>
        /// Number of times a class is replicated<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("factor")]
        public int? Factor { get; set; } = 1;

        /// <summary>
        /// Enable asynchronous replication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asyncEnabled")]
        public bool? AsyncEnabled { get; set; }

        /// <summary>
        /// Conflict resolution strategy for deleted objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectDeletionConflictResolution")]
        public global::G.ReplicationConfigObjectDeletionConflictResolution? ObjectDeletionConflictResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}