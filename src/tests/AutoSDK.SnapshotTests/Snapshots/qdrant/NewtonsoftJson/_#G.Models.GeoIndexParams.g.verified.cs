//HintName: G.Models.GeoIndexParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeoIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GeoIndexType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="GeoIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="onDisk">
        /// If true, store the index on disk. Default: false.
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
        public GeoIndexParams(
            global::G.GeoIndexType type,
            bool? onDisk,
            bool? enableHnsw)
        {
            this.Type = type;
            this.OnDisk = onDisk;
            this.EnableHnsw = enableHnsw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoIndexParams" /> class.
        /// </summary>
        public GeoIndexParams()
        {
        }
    }
}