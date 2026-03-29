//HintName: G.Models.TokenChunkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenChunkingConfig
    {
        /// <summary>
        /// Default Value: 1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_size")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// Default Value: 200
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_overlap")]
        public int? ChunkOverlap { get; set; }

        /// <summary>
        /// Default Value: token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("separator")]
        public string? Separator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenChunkingConfig" /> class.
        /// </summary>
        /// <param name="chunkSize">
        /// Default Value: 1024
        /// </param>
        /// <param name="chunkOverlap">
        /// Default Value: 200
        /// </param>
        /// <param name="mode">
        /// Default Value: token
        /// </param>
        /// <param name="separator"></param>
        public TokenChunkingConfig(
            int? chunkSize,
            int? chunkOverlap,
            string? mode,
            string? separator)
        {
            this.ChunkSize = chunkSize;
            this.ChunkOverlap = chunkOverlap;
            this.Mode = mode;
            this.Separator = separator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenChunkingConfig" /> class.
        /// </summary>
        public TokenChunkingConfig()
        {
        }
    }
}