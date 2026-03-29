//HintName: G.Models.CollectionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the collection configuration
    /// </summary>
    public sealed partial class CollectionConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CollectionParams Params { get; set; }

        /// <summary>
        /// Config of HNSW index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HnswConfig HnswConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OptimizersConfig OptimizerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wal_config")]
        public global::G.WalConfig? WalConfig { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization_config")]
        public global::G.QuantizationConfig? QuantizationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_mode_config")]
        public global::G.StrictModeConfigOutput? StrictModeConfig { get; set; }

        /// <summary>
        /// Arbitrary JSON metadata for the collection This can be used to store application-specific information such as creation time, migration data, inference model info, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Payload? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionConfig" /> class.
        /// </summary>
        /// <param name="params"></param>
        /// <param name="hnswConfig">
        /// Config of HNSW index
        /// </param>
        /// <param name="optimizerConfig"></param>
        /// <param name="walConfig"></param>
        /// <param name="quantizationConfig">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="strictModeConfig"></param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata for the collection This can be used to store application-specific information such as creation time, migration data, inference model info, etc.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionConfig(
            global::G.CollectionParams @params,
            global::G.HnswConfig hnswConfig,
            global::G.OptimizersConfig optimizerConfig,
            global::G.WalConfig? walConfig,
            global::G.QuantizationConfig? quantizationConfig,
            global::G.StrictModeConfigOutput? strictModeConfig,
            global::G.Payload? metadata)
        {
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.HnswConfig = hnswConfig ?? throw new global::System.ArgumentNullException(nameof(hnswConfig));
            this.OptimizerConfig = optimizerConfig ?? throw new global::System.ArgumentNullException(nameof(optimizerConfig));
            this.WalConfig = walConfig;
            this.QuantizationConfig = quantizationConfig;
            this.StrictModeConfig = strictModeConfig;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionConfig" /> class.
        /// </summary>
        public CollectionConfig()
        {
        }
    }
}