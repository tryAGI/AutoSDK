//HintName: G.Models.VectorDataConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config of single vector data storage
    /// </summary>
    public sealed partial class VectorDataConfig
    {
        /// <summary>
        /// Size/dimensionality of the vectors used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Type of internal tags, build from payload Distance function types used to compare vectors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Distance Distance { get; set; } = default!;

        /// <summary>
        /// Storage types for vectors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStorageType StorageType { get; set; } = default!;

        /// <summary>
        /// Vector index configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Indexes Index { get; set; } = default!;

        /// <summary>
        /// Vector specific quantization config that overrides collection config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization_config")]
        public global::G.QuantizationConfig? QuantizationConfig { get; set; }

        /// <summary>
        /// Vector specific configuration to enable multiple vectors per point
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multivector_config")]
        public global::G.MultiVectorConfig? MultivectorConfig { get; set; }

        /// <summary>
        /// Vector specific configuration to set specific storage element type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datatype")]
        public global::G.VectorStorageDatatype? Datatype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorDataConfig" /> class.
        /// </summary>
        /// <param name="size">
        /// Size/dimensionality of the vectors used
        /// </param>
        /// <param name="distance">
        /// Type of internal tags, build from payload Distance function types used to compare vectors
        /// </param>
        /// <param name="storageType">
        /// Storage types for vectors
        /// </param>
        /// <param name="index">
        /// Vector index configuration
        /// </param>
        /// <param name="quantizationConfig">
        /// Vector specific quantization config that overrides collection config
        /// </param>
        /// <param name="multivectorConfig">
        /// Vector specific configuration to enable multiple vectors per point
        /// </param>
        /// <param name="datatype">
        /// Vector specific configuration to set specific storage element type
        /// </param>
        public VectorDataConfig(
            int size,
            global::G.Distance distance,
            global::G.VectorStorageType storageType,
            global::G.Indexes index,
            global::G.QuantizationConfig? quantizationConfig,
            global::G.MultiVectorConfig? multivectorConfig,
            global::G.VectorStorageDatatype? datatype)
        {
            this.Size = size;
            this.Distance = distance;
            this.StorageType = storageType;
            this.Index = index;
            this.QuantizationConfig = quantizationConfig;
            this.MultivectorConfig = multivectorConfig;
            this.Datatype = datatype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorDataConfig" /> class.
        /// </summary>
        public VectorDataConfig()
        {
        }
    }
}