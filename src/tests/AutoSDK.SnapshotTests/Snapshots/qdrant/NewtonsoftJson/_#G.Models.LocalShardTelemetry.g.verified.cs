//HintName: G.Models.LocalShardTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalShardTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variant_name")]
        public string? VariantName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ShardStatus? Status { get; set; }

        /// <summary>
        /// Total number of optimized points since the last start.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_optimized_points", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalOptimizedPoints { get; set; } = default!;

        /// <summary>
        /// An ESTIMATION of effective amount of bytes used for vectors Do NOT rely on this number unless you know what you are doing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectors_size_bytes")]
        public int? VectorsSizeBytes { get; set; }

        /// <summary>
        /// An estimation of the effective amount of bytes used for payloads Do NOT rely on this number unless you know what you are doing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payloads_size_bytes")]
        public int? PayloadsSizeBytes { get; set; }

        /// <summary>
        /// Sum of segment points This is an approximate number Do NOT rely on this number unless you know what you are doing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_points")]
        public int? NumPoints { get; set; }

        /// <summary>
        /// Sum of number of vectors in all segments This is an approximate number Do NOT rely on this number unless you know what you are doing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_vectors")]
        public int? NumVectors { get; set; }

        /// <summary>
        /// Sum of number of vectors across all segments, grouped by their name. This is an approximate number. Do NOT rely on this number unless you know what you are doing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_vectors_by_name")]
        public global::System.Collections.Generic.Dictionary<string, int>? NumVectorsByName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments")]
        public global::System.Collections.Generic.IList<global::G.SegmentTelemetry>? Segments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimizations")]
        public global::G.OptimizerTelemetry? Optimizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("async_scorer")]
        public bool? AsyncScorer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexed_only_excluded_vectors")]
        public global::System.Collections.Generic.Dictionary<string, int>? IndexedOnlyExcludedVectors { get; set; }

        /// <summary>
        /// Update queue status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_queue")]
        public global::G.ShardUpdateQueueInfo? UpdateQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShardTelemetry" /> class.
        /// </summary>
        /// <param name="totalOptimizedPoints">
        /// Total number of optimized points since the last start.
        /// </param>
        /// <param name="variantName"></param>
        /// <param name="status"></param>
        /// <param name="vectorsSizeBytes">
        /// An ESTIMATION of effective amount of bytes used for vectors Do NOT rely on this number unless you know what you are doing
        /// </param>
        /// <param name="payloadsSizeBytes">
        /// An estimation of the effective amount of bytes used for payloads Do NOT rely on this number unless you know what you are doing
        /// </param>
        /// <param name="numPoints">
        /// Sum of segment points This is an approximate number Do NOT rely on this number unless you know what you are doing
        /// </param>
        /// <param name="numVectors">
        /// Sum of number of vectors in all segments This is an approximate number Do NOT rely on this number unless you know what you are doing
        /// </param>
        /// <param name="numVectorsByName">
        /// Sum of number of vectors across all segments, grouped by their name. This is an approximate number. Do NOT rely on this number unless you know what you are doing
        /// </param>
        /// <param name="segments"></param>
        /// <param name="optimizations"></param>
        /// <param name="asyncScorer"></param>
        /// <param name="indexedOnlyExcludedVectors"></param>
        /// <param name="updateQueue">
        /// Update queue status
        /// </param>
        public LocalShardTelemetry(
            int totalOptimizedPoints,
            string? variantName,
            global::G.ShardStatus? status,
            int? vectorsSizeBytes,
            int? payloadsSizeBytes,
            int? numPoints,
            int? numVectors,
            global::System.Collections.Generic.Dictionary<string, int>? numVectorsByName,
            global::System.Collections.Generic.IList<global::G.SegmentTelemetry>? segments,
            global::G.OptimizerTelemetry? optimizations,
            bool? asyncScorer,
            global::System.Collections.Generic.Dictionary<string, int>? indexedOnlyExcludedVectors,
            global::G.ShardUpdateQueueInfo? updateQueue)
        {
            this.VariantName = variantName;
            this.Status = status;
            this.TotalOptimizedPoints = totalOptimizedPoints;
            this.VectorsSizeBytes = vectorsSizeBytes;
            this.PayloadsSizeBytes = payloadsSizeBytes;
            this.NumPoints = numPoints;
            this.NumVectors = numVectors;
            this.NumVectorsByName = numVectorsByName;
            this.Segments = segments;
            this.Optimizations = optimizations;
            this.AsyncScorer = asyncScorer;
            this.IndexedOnlyExcludedVectors = indexedOnlyExcludedVectors;
            this.UpdateQueue = updateQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShardTelemetry" /> class.
        /// </summary>
        public LocalShardTelemetry()
        {
        }
    }
}