//HintName: G.Models.CollectionInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current statistics and configuration of the collection
    /// </summary>
    public sealed partial class CollectionInfo
    {
        /// <summary>
        /// Current state of the collection. `Green` - all good. `Yellow` - optimization is running, 'Grey' - optimizations are possible but not triggered, `Red` - some operations failed and was not recovered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CollectionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CollectionStatus Status { get; set; }

        /// <summary>
        /// Current state of the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OptimizersStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OptimizersStatus OptimizerStatus { get; set; }

        /// <summary>
        /// Warnings related to the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::G.CollectionWarning>? Warnings { get; set; }

        /// <summary>
        /// Approximate number of indexed vectors in the collection. Indexed vectors in large segments are faster to query, as it is stored in a specialized vector index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexed_vectors_count")]
        public int? IndexedVectorsCount { get; set; }

        /// <summary>
        /// Approximate number of points (vectors + payloads) in collection. Each point could be accessed by unique id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points_count")]
        public int? PointsCount { get; set; }

        /// <summary>
        /// Number of segments in collection. Each segment has independent vector as payload indexes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SegmentsCount { get; set; }

        /// <summary>
        /// Information about the collection configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CollectionConfig Config { get; set; }

        /// <summary>
        /// Types of stored payload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.PayloadIndexInfo> PayloadSchema { get; set; }

        /// <summary>
        /// Update queue info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_queue")]
        public global::G.UpdateQueueInfo? UpdateQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionInfo" /> class.
        /// </summary>
        /// <param name="status">
        /// Current state of the collection. `Green` - all good. `Yellow` - optimization is running, 'Grey' - optimizations are possible but not triggered, `Red` - some operations failed and was not recovered
        /// </param>
        /// <param name="optimizerStatus">
        /// Current state of the collection
        /// </param>
        /// <param name="segmentsCount">
        /// Number of segments in collection. Each segment has independent vector as payload indexes
        /// </param>
        /// <param name="config">
        /// Information about the collection configuration
        /// </param>
        /// <param name="payloadSchema">
        /// Types of stored payload
        /// </param>
        /// <param name="warnings">
        /// Warnings related to the collection
        /// </param>
        /// <param name="indexedVectorsCount">
        /// Approximate number of indexed vectors in the collection. Indexed vectors in large segments are faster to query, as it is stored in a specialized vector index.
        /// </param>
        /// <param name="pointsCount">
        /// Approximate number of points (vectors + payloads) in collection. Each point could be accessed by unique id.
        /// </param>
        /// <param name="updateQueue">
        /// Update queue info
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionInfo(
            global::G.CollectionStatus status,
            global::G.OptimizersStatus optimizerStatus,
            int segmentsCount,
            global::G.CollectionConfig config,
            global::System.Collections.Generic.Dictionary<string, global::G.PayloadIndexInfo> payloadSchema,
            global::System.Collections.Generic.IList<global::G.CollectionWarning>? warnings,
            int? indexedVectorsCount,
            int? pointsCount,
            global::G.UpdateQueueInfo? updateQueue)
        {
            this.Status = status;
            this.OptimizerStatus = optimizerStatus;
            this.Warnings = warnings;
            this.IndexedVectorsCount = indexedVectorsCount;
            this.PointsCount = pointsCount;
            this.SegmentsCount = segmentsCount;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.PayloadSchema = payloadSchema ?? throw new global::System.ArgumentNullException(nameof(payloadSchema));
            this.UpdateQueue = updateQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionInfo" /> class.
        /// </summary>
        public CollectionInfo()
        {
        }
    }
}