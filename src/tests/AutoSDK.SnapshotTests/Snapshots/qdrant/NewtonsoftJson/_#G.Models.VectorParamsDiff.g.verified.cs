//HintName: G.Models.VectorParamsDiff.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorParamsDiff
    {
        /// <summary>
        /// Update params for HNSW index. If empty object - it will be unset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hnsw_config")]
        public global::G.HnswConfigDiff? HnswConfig { get; set; }

        /// <summary>
        /// Update params for quantization. If none - it is left unchanged.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization_config")]
        public global::G.QuantizationConfigDiff? QuantizationConfig { get; set; }

        /// <summary>
        /// If true, vectors are served from disk, improving RAM usage at the cost of latency
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_disk")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorParamsDiff" /> class.
        /// </summary>
        /// <param name="hnswConfig">
        /// Update params for HNSW index. If empty object - it will be unset.
        /// </param>
        /// <param name="quantizationConfig">
        /// Update params for quantization. If none - it is left unchanged.
        /// </param>
        /// <param name="onDisk">
        /// If true, vectors are served from disk, improving RAM usage at the cost of latency
        /// </param>
        public VectorParamsDiff(
            global::G.HnswConfigDiff? hnswConfig,
            global::G.QuantizationConfigDiff? quantizationConfig,
            bool? onDisk)
        {
            this.HnswConfig = hnswConfig;
            this.QuantizationConfig = quantizationConfig;
            this.OnDisk = onDisk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorParamsDiff" /> class.
        /// </summary>
        public VectorParamsDiff()
        {
        }
    }
}