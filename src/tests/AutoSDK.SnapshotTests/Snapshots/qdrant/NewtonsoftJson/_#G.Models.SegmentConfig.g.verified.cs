//HintName: G.Models.SegmentConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentConfig
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_data")]
        public global::System.Collections.Generic.Dictionary<string, global::G.VectorDataConfig>? VectorData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sparse_vector_data")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorDataConfig>? SparseVectorData { get; set; }

        /// <summary>
        /// Type of payload storage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_storage_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PayloadStorageType PayloadStorageType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentConfig" /> class.
        /// </summary>
        /// <param name="payloadStorageType">
        /// Type of payload storage
        /// </param>
        /// <param name="vectorData">
        /// Default Value: {}
        /// </param>
        /// <param name="sparseVectorData"></param>
        public SegmentConfig(
            global::G.PayloadStorageType payloadStorageType,
            global::System.Collections.Generic.Dictionary<string, global::G.VectorDataConfig>? vectorData,
            global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorDataConfig>? sparseVectorData)
        {
            this.VectorData = vectorData;
            this.SparseVectorData = sparseVectorData;
            this.PayloadStorageType = payloadStorageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentConfig" /> class.
        /// </summary>
        public SegmentConfig()
        {
        }
    }
}