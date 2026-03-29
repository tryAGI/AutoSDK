//HintName: G.Models.SegmentInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregated information about segment
    /// </summary>
    public sealed partial class SegmentInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        /// Type of segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SegmentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SegmentType SegmentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumVectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_deferred_points")]
        public int? NumDeferredPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_deleted_deferred_points")]
        public int? NumDeletedDeferredPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_indexed_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumIndexedVectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_deleted_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumDeletedVectors { get; set; }

        /// <summary>
        /// An ESTIMATION of effective amount of bytes used for vectors Do NOT rely on this number unless you know what you are doing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VectorsSizeBytes { get; set; }

        /// <summary>
        /// An estimation of the effective amount of bytes used for payloads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloads_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PayloadsSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ram_usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RamUsageBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DiskUsageBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_appendable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAppendable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.PayloadIndexInfo> IndexSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.VectorDataInfo> VectorData { get; set; }

        /// <summary>
        /// Internal ID from which points are deferred (hidden from reads). Only set for appendable segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deferred_internal_id")]
        public int? DeferredInternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentInfo" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="segmentType">
        /// Type of segment
        /// </param>
        /// <param name="numVectors"></param>
        /// <param name="numPoints"></param>
        /// <param name="numIndexedVectors"></param>
        /// <param name="numDeletedVectors"></param>
        /// <param name="vectorsSizeBytes">
        /// An ESTIMATION of effective amount of bytes used for vectors Do NOT rely on this number unless you know what you are doing
        /// </param>
        /// <param name="payloadsSizeBytes">
        /// An estimation of the effective amount of bytes used for payloads
        /// </param>
        /// <param name="ramUsageBytes"></param>
        /// <param name="diskUsageBytes"></param>
        /// <param name="isAppendable"></param>
        /// <param name="indexSchema"></param>
        /// <param name="vectorData"></param>
        /// <param name="numDeferredPoints"></param>
        /// <param name="numDeletedDeferredPoints"></param>
        /// <param name="deferredInternalId">
        /// Internal ID from which points are deferred (hidden from reads). Only set for appendable segments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentInfo(
            global::System.Guid uuid,
            global::G.SegmentType segmentType,
            int numVectors,
            int numPoints,
            int numIndexedVectors,
            int numDeletedVectors,
            int vectorsSizeBytes,
            int payloadsSizeBytes,
            int ramUsageBytes,
            int diskUsageBytes,
            bool isAppendable,
            global::System.Collections.Generic.Dictionary<string, global::G.PayloadIndexInfo> indexSchema,
            global::System.Collections.Generic.Dictionary<string, global::G.VectorDataInfo> vectorData,
            int? numDeferredPoints,
            int? numDeletedDeferredPoints,
            int? deferredInternalId)
        {
            this.Uuid = uuid;
            this.SegmentType = segmentType;
            this.NumVectors = numVectors;
            this.NumPoints = numPoints;
            this.NumDeferredPoints = numDeferredPoints;
            this.NumDeletedDeferredPoints = numDeletedDeferredPoints;
            this.NumIndexedVectors = numIndexedVectors;
            this.NumDeletedVectors = numDeletedVectors;
            this.VectorsSizeBytes = vectorsSizeBytes;
            this.PayloadsSizeBytes = payloadsSizeBytes;
            this.RamUsageBytes = ramUsageBytes;
            this.DiskUsageBytes = diskUsageBytes;
            this.IsAppendable = isAppendable;
            this.IndexSchema = indexSchema ?? throw new global::System.ArgumentNullException(nameof(indexSchema));
            this.VectorData = vectorData ?? throw new global::System.ArgumentNullException(nameof(vectorData));
            this.DeferredInternalId = deferredInternalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentInfo" /> class.
        /// </summary>
        public SegmentInfo()
        {
        }
    }
}