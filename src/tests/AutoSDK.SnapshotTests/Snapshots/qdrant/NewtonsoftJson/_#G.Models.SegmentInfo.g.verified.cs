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
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Uuid { get; set; } = default!;

        /// <summary>
        /// Type of segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segment_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SegmentType SegmentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumVectors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_points", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumPoints { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_deferred_points")]
        public int? NumDeferredPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_deleted_deferred_points")]
        public int? NumDeletedDeferredPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_indexed_vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumIndexedVectors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_deleted_vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumDeletedVectors { get; set; } = default!;

        /// <summary>
        /// An ESTIMATION of effective amount of bytes used for vectors Do NOT rely on this number unless you know what you are doing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectors_size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int VectorsSizeBytes { get; set; } = default!;

        /// <summary>
        /// An estimation of the effective amount of bytes used for payloads
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payloads_size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int PayloadsSizeBytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ram_usage_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int RamUsageBytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disk_usage_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int DiskUsageBytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_appendable", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAppendable { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.PayloadIndexInfo> IndexSchema { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.VectorDataInfo> VectorData { get; set; } = default!;

        /// <summary>
        /// Internal ID from which points are deferred (hidden from reads). Only set for appendable segments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deferred_internal_id")]
        public int? DeferredInternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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