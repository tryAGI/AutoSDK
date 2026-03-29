//HintName: G.Models.KeywordIndexParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeywordIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KeywordIndexTypeJsonConverter))]
        public global::G.KeywordIndexType Type { get; set; }

        /// <summary>
        /// If true - used for tenant optimization. Default: false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_tenant")]
        public bool? IsTenant { get; set; }

        /// <summary>
        /// If true, store the index on disk. Default: false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_hnsw")]
        public bool? EnableHnsw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeywordIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isTenant">
        /// If true - used for tenant optimization. Default: false.
        /// </param>
        /// <param name="onDisk">
        /// If true, store the index on disk. Default: false.
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeywordIndexParams(
            global::G.KeywordIndexType type,
            bool? isTenant,
            bool? onDisk,
            bool? enableHnsw)
        {
            this.Type = type;
            this.IsTenant = isTenant;
            this.OnDisk = onDisk;
            this.EnableHnsw = enableHnsw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeywordIndexParams" /> class.
        /// </summary>
        public KeywordIndexParams()
        {
        }
    }
}