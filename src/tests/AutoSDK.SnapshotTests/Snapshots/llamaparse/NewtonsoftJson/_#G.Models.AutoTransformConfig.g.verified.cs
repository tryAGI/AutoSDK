//HintName: G.Models.AutoTransformConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoTransformConfig
    {
        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Chunk size for the transformation.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_size")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// Chunk overlap for the transformation.<br/>
        /// Default Value: 200
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_overlap")]
        public int? ChunkOverlap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTransformConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// Default Value: auto
        /// </param>
        /// <param name="chunkSize">
        /// Chunk size for the transformation.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="chunkOverlap">
        /// Chunk overlap for the transformation.<br/>
        /// Default Value: 200
        /// </param>
        public AutoTransformConfig(
            string? mode,
            int? chunkSize,
            int? chunkOverlap)
        {
            this.Mode = mode;
            this.ChunkSize = chunkSize;
            this.ChunkOverlap = chunkOverlap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTransformConfig" /> class.
        /// </summary>
        public AutoTransformConfig()
        {
        }
    }
}