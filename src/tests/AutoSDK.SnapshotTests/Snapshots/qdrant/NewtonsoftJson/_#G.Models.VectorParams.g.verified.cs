//HintName: G.Models.VectorParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Params of single vector data storage
    /// </summary>
    public sealed partial class VectorParams
    {
        /// <summary>
        /// Size of a vectors used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Type of internal tags, build from payload Distance function types used to compare vectors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distance", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DistanceJsonConverter))]
        public global::G.Distance Distance { get; set; } = default!;

        /// <summary>
        /// Custom params for HNSW index. If none - values from collection configuration are used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hnsw_config")]
        public global::G.HnswConfigDiff? HnswConfig { get; set; }

        /// <summary>
        /// Custom params for quantization. If none - values from collection configuration are used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization_config")]
        public global::G.QuantizationConfig? QuantizationConfig { get; set; }

        /// <summary>
        /// If true, vectors are served from disk, improving RAM usage at the cost of latency Default: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_disk")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Defines which datatype should be used to represent vectors in the storage. Choosing different datatypes allows to optimize memory usage and performance vs accuracy.<br/>
        /// - For `float32` datatype - vectors are stored as single-precision floating point numbers, 4 bytes. - For `float16` datatype - vectors are stored as half-precision floating point numbers, 2 bytes. - For `uint8` datatype - vectors are stored as unsigned 8-bit integers, 1 byte. It expects vector elements to be in range `[0, 255]`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datatype")]
        public global::G.Datatype? Datatype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multivector_config")]
        public global::G.MultiVectorConfig? MultivectorConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorParams" /> class.
        /// </summary>
        /// <param name="size">
        /// Size of a vectors used
        /// </param>
        /// <param name="distance">
        /// Type of internal tags, build from payload Distance function types used to compare vectors
        /// </param>
        /// <param name="hnswConfig">
        /// Custom params for HNSW index. If none - values from collection configuration are used.
        /// </param>
        /// <param name="quantizationConfig">
        /// Custom params for quantization. If none - values from collection configuration are used.
        /// </param>
        /// <param name="onDisk">
        /// If true, vectors are served from disk, improving RAM usage at the cost of latency Default: false
        /// </param>
        /// <param name="datatype">
        /// Defines which datatype should be used to represent vectors in the storage. Choosing different datatypes allows to optimize memory usage and performance vs accuracy.<br/>
        /// - For `float32` datatype - vectors are stored as single-precision floating point numbers, 4 bytes. - For `float16` datatype - vectors are stored as half-precision floating point numbers, 2 bytes. - For `uint8` datatype - vectors are stored as unsigned 8-bit integers, 1 byte. It expects vector elements to be in range `[0, 255]`.
        /// </param>
        /// <param name="multivectorConfig"></param>
        public VectorParams(
            int size,
            global::G.Distance distance,
            global::G.HnswConfigDiff? hnswConfig,
            global::G.QuantizationConfig? quantizationConfig,
            bool? onDisk,
            global::G.Datatype? datatype,
            global::G.MultiVectorConfig? multivectorConfig)
        {
            this.Size = size;
            this.Distance = distance;
            this.HnswConfig = hnswConfig;
            this.QuantizationConfig = quantizationConfig;
            this.OnDisk = onDisk;
            this.Datatype = datatype;
            this.MultivectorConfig = multivectorConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorParams" /> class.
        /// </summary>
        public VectorParams()
        {
        }
    }
}