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
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Type of internal tags, build from payload Distance function types used to compare vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DistanceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Distance Distance { get; set; }

        /// <summary>
        /// Storage types for vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStorageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorStorageType StorageType { get; set; }

        /// <summary>
        /// Vector index configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IndexesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Indexes Index { get; set; }

        /// <summary>
        /// Vector specific quantization config that overrides collection config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization_config")]
        public global::G.QuantizationConfig? QuantizationConfig { get; set; }

        /// <summary>
        /// Vector specific configuration to enable multiple vectors per point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivector_config")]
        public global::G.MultiVectorConfig? MultivectorConfig { get; set; }

        /// <summary>
        /// Vector specific configuration to set specific storage element type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datatype")]
        public global::G.VectorStorageDatatype? Datatype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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