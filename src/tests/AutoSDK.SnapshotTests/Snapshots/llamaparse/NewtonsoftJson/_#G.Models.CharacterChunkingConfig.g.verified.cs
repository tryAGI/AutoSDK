//HintName: G.Models.CharacterChunkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharacterChunkingConfig
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
        /// Default Value: character
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterChunkingConfig" /> class.
        /// </summary>
        /// <param name="chunkSize">
        /// Default Value: 1024
        /// </param>
        /// <param name="chunkOverlap">
        /// Default Value: 200
        /// </param>
        /// <param name="mode">
        /// Default Value: character
        /// </param>
        public CharacterChunkingConfig(
            int? chunkSize,
            int? chunkOverlap,
            string? mode)
        {
            this.ChunkSize = chunkSize;
            this.ChunkOverlap = chunkOverlap;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterChunkingConfig" /> class.
        /// </summary>
        public CharacterChunkingConfig()
        {
        }
    }
}