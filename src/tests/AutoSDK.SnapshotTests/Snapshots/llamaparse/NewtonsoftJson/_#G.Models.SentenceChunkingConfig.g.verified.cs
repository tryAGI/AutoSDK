//HintName: G.Models.SentenceChunkingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentenceChunkingConfig
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
        /// Default Value: sentence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("separator")]
        public string? Separator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("paragraph_separator")]
        public string? ParagraphSeparator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunkingConfig" /> class.
        /// </summary>
        /// <param name="chunkSize">
        /// Default Value: 1024
        /// </param>
        /// <param name="chunkOverlap">
        /// Default Value: 200
        /// </param>
        /// <param name="mode">
        /// Default Value: sentence
        /// </param>
        /// <param name="separator"></param>
        /// <param name="paragraphSeparator"></param>
        public SentenceChunkingConfig(
            int? chunkSize,
            int? chunkOverlap,
            string? mode,
            string? separator,
            string? paragraphSeparator)
        {
            this.ChunkSize = chunkSize;
            this.ChunkOverlap = chunkOverlap;
            this.Mode = mode;
            this.Separator = separator;
            this.ParagraphSeparator = paragraphSeparator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunkingConfig" /> class.
        /// </summary>
        public SentenceChunkingConfig()
        {
        }
    }
}