//HintName: G.Models.IntegerIndexParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegerIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.IntegerIndexType Type { get; set; }

        /// <summary>
        /// If true - support direct lookups. Default is true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lookup")]
        public bool? Lookup { get; set; }

        /// <summary>
        /// If true - support ranges filters. Default is true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range")]
        public bool? Range { get; set; }

        /// <summary>
        /// If true - use this key to organize storage of the collection data. This option assumes that this key will be used in majority of filtered requests. Default is false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_principal")]
        public bool? IsPrincipal { get; set; }

        /// <summary>
        /// If true, store the index on disk. Default: false. Default is false.
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
        /// Initializes a new instance of the <see cref="IntegerIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="lookup">
        /// If true - support direct lookups. Default is true.
        /// </param>
        /// <param name="range">
        /// If true - support ranges filters. Default is true.
        /// </param>
        /// <param name="isPrincipal">
        /// If true - use this key to organize storage of the collection data. This option assumes that this key will be used in majority of filtered requests. Default is false.
        /// </param>
        /// <param name="onDisk">
        /// If true, store the index on disk. Default: false. Default is false.
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
        public IntegerIndexParams(
            global::G.IntegerIndexType type,
            bool? lookup,
            bool? range,
            bool? isPrincipal,
            bool? onDisk,
            bool? enableHnsw)
        {
            this.Type = type;
            this.Lookup = lookup;
            this.Range = range;
            this.IsPrincipal = isPrincipal;
            this.OnDisk = onDisk;
            this.EnableHnsw = enableHnsw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerIndexParams" /> class.
        /// </summary>
        public IntegerIndexParams()
        {
        }
    }
}