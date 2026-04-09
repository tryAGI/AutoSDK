//HintName: G.Models.UuidIndexParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UuidIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UuidIndexTypeJsonConverter))]
        public global::G.UuidIndexType Type { get; set; }

        /// <summary>
        /// If true - used for tenant optimization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_tenant")]
        public bool? IsTenant { get; set; }

        /// <summary>
        /// If true, store the index on disk. Default: false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_disk")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_hnsw")]
        public bool? EnableHnsw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UuidIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isTenant">
        /// If true - used for tenant optimization.
        /// </param>
        /// <param name="onDisk">
        /// If true, store the index on disk. Default: false.
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
        public UuidIndexParams(
            global::G.UuidIndexType type,
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
        /// Initializes a new instance of the <see cref="UuidIndexParams" /> class.
        /// </summary>
        public UuidIndexParams()
        {
        }
    }
}