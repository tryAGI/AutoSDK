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
        [global::System.Text.Json.Serialization.JsonPropertyName("factor")]
        public int? Factor { get; set; }

        /// <summary>
        /// Enable asynchronous replication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asyncEnabled")]
        public bool? AsyncEnabled { get; set; }

        /// <summary>
        /// Conflict resolution strategy for deleted objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectDeletionConflictResolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReplicationConfigObjectDeletionConflictResolutionJsonConverter))]
        public global::G.ReplicationConfigObjectDeletionConflictResolution? ObjectDeletionConflictResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationConfig" /> class.
        /// </summary>
        /// <param name="factor">
        /// Number of times a class is replicated<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="asyncEnabled">
        /// Enable asynchronous replication
        /// </param>
        /// <param name="objectDeletionConflictResolution">
        /// Conflict resolution strategy for deleted objects
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationConfig(
            int? factor,
            bool? asyncEnabled,
            global::G.ReplicationConfigObjectDeletionConflictResolution? objectDeletionConflictResolution)
        {
            this.Factor = factor;
            this.AsyncEnabled = asyncEnabled;
            this.ObjectDeletionConflictResolution = objectDeletionConflictResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationConfig" /> class.
        /// </summary>
        public ReplicationConfig()
        {
        }
    }
}