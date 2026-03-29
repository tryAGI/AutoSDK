//HintName: G.Models.BoolIndexParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BoolIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BoolIndexTypeJsonConverter))]
        public global::G.BoolIndexType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BoolIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="onDisk">
        /// If true, store the index on disk. Default: false.
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoolIndexParams(
            global::G.BoolIndexType type,
            bool? onDisk,
            bool? enableHnsw)
        {
            this.Type = type;
            this.OnDisk = onDisk;
            this.EnableHnsw = enableHnsw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoolIndexParams" /> class.
        /// </summary>
        public BoolIndexParams()
        {
        }
    }
}