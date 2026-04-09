//HintName: G.Models.FloatIndexParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FloatIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FloatIndexTypeJsonConverter))]
        public global::G.FloatIndexType Type { get; set; }

        /// <summary>
        /// If true - use this key to organize storage of the collection data. This option assumes that this key will be used in majority of filtered requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_principal")]
        public bool? IsPrincipal { get; set; }

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
        /// Initializes a new instance of the <see cref="FloatIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isPrincipal">
        /// If true - use this key to organize storage of the collection data. This option assumes that this key will be used in majority of filtered requests.
        /// </param>
        /// <param name="onDisk">
        /// If true, store the index on disk. Default: false.
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
        public FloatIndexParams(
            global::G.FloatIndexType type,
            bool? isPrincipal,
            bool? onDisk,
            bool? enableHnsw)
        {
            this.Type = type;
            this.IsPrincipal = isPrincipal;
            this.OnDisk = onDisk;
            this.EnableHnsw = enableHnsw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatIndexParams" /> class.
        /// </summary>
        public FloatIndexParams()
        {
        }
    }
}