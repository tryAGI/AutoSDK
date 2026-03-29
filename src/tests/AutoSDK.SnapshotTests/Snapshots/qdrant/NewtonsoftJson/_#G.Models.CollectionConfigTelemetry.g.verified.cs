//HintName: G.Models.CollectionConfigTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionConfigTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CollectionParams Params { get; set; } = default!;

        /// <summary>
        /// Config of HNSW index
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hnsw_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HnswConfig HnswConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimizer_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OptimizersConfig OptimizerConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wal_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WalConfig WalConfig { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization_config")]
        public global::G.QuantizationConfig? QuantizationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict_mode_config")]
        public global::G.StrictModeConfigOutput? StrictModeConfig { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        /// Arbitrary JSON metadata for the collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Payload? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionConfigTelemetry" /> class.
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
        /// <param name="uuid">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata for the collection
        /// </param>
        public CollectionConfigTelemetry(
            global::G.CollectionParams @params,
            global::G.HnswConfig hnswConfig,
            global::G.OptimizersConfig optimizerConfig,
            global::G.WalConfig walConfig,
            global::G.QuantizationConfig? quantizationConfig,
            global::G.StrictModeConfigOutput? strictModeConfig,
            global::System.Guid? uuid,
            global::G.Payload? metadata)
        {
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.HnswConfig = hnswConfig ?? throw new global::System.ArgumentNullException(nameof(hnswConfig));
            this.OptimizerConfig = optimizerConfig ?? throw new global::System.ArgumentNullException(nameof(optimizerConfig));
            this.WalConfig = walConfig ?? throw new global::System.ArgumentNullException(nameof(walConfig));
            this.QuantizationConfig = quantizationConfig;
            this.StrictModeConfig = strictModeConfig;
            this.Uuid = uuid;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionConfigTelemetry" /> class.
        /// </summary>
        public CollectionConfigTelemetry()
        {
        }
    }
}