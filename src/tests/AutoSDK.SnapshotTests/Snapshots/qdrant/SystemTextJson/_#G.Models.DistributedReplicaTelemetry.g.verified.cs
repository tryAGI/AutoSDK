//HintName: G.Models.DistributedReplicaTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributedReplicaTelemetry
    {
        /// <summary>
        /// Peer ID hosting this replica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeerId { get; set; }

        /// <summary>
        /// State of the single shard within a replica set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReplicaStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReplicaState State { get; set; }

        /// <summary>
        /// Shard status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::G.ShardStatus? Status { get; set; }

        /// <summary>
        /// Total optimized points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_optimized_points")]
        public int? TotalOptimizedPoints { get; set; }

        /// <summary>
        /// Estimated vectors size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors_size_bytes")]
        public int? VectorsSizeBytes { get; set; }

        /// <summary>
        /// Estimated payloads size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloads_size_bytes")]
        public int? PayloadsSizeBytes { get; set; }

        /// <summary>
        /// Approximate number of points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_points")]
        public int? NumPoints { get; set; }

        /// <summary>
        /// Approximate number of vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_vectors")]
        public int? NumVectors { get; set; }

        /// <summary>
        /// Approximate number of vectors by name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_vectors_by_name")]
        public global::System.Collections.Generic.Dictionary<string, int>? NumVectorsByName { get; set; }

        /// <summary>
        /// Shard cleaning task status. After a resharding, a cleanup task is performed to remove outdated points from this shard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_cleaning_status")]
        public global::G.ShardCleanStatusTelemetry? ShardCleaningStatus { get; set; }

        /// <summary>
        /// Partial snapshot telemetry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_snapshot")]
        public global::G.PartialSnapshotTelemetry? PartialSnapshot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedReplicaTelemetry" /> class.
        /// </summary>
        /// <param name="peerId">
        /// Peer ID hosting this replica
        /// </param>
        /// <param name="state">
        /// State of the single shard within a replica set.
        /// </param>
        /// <param name="status">
        /// Shard status
        /// </param>
        /// <param name="totalOptimizedPoints">
        /// Total optimized points
        /// </param>
        /// <param name="vectorsSizeBytes">
        /// Estimated vectors size in bytes
        /// </param>
        /// <param name="payloadsSizeBytes">
        /// Estimated payloads size in bytes
        /// </param>
        /// <param name="numPoints">
        /// Approximate number of points
        /// </param>
        /// <param name="numVectors">
        /// Approximate number of vectors
        /// </param>
        /// <param name="numVectorsByName">
        /// Approximate number of vectors by name
        /// </param>
        /// <param name="shardCleaningStatus">
        /// Shard cleaning task status. After a resharding, a cleanup task is performed to remove outdated points from this shard.
        /// </param>
        /// <param name="partialSnapshot">
        /// Partial snapshot telemetry
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributedReplicaTelemetry(
            int peerId,
            global::G.ReplicaState state,
            global::G.ShardStatus? status,
            int? totalOptimizedPoints,
            int? vectorsSizeBytes,
            int? payloadsSizeBytes,
            int? numPoints,
            int? numVectors,
            global::System.Collections.Generic.Dictionary<string, int>? numVectorsByName,
            global::G.ShardCleanStatusTelemetry? shardCleaningStatus,
            global::G.PartialSnapshotTelemetry? partialSnapshot)
        {
            this.PeerId = peerId;
            this.State = state;
            this.Status = status;
            this.TotalOptimizedPoints = totalOptimizedPoints;
            this.VectorsSizeBytes = vectorsSizeBytes;
            this.PayloadsSizeBytes = payloadsSizeBytes;
            this.NumPoints = numPoints;
            this.NumVectors = numVectors;
            this.NumVectorsByName = numVectorsByName;
            this.ShardCleaningStatus = shardCleaningStatus;
            this.PartialSnapshot = partialSnapshot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedReplicaTelemetry" /> class.
        /// </summary>
        public DistributedReplicaTelemetry()
        {
        }
    }
}