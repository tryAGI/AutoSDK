//HintName: G.Models.Chunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Chunk message represents a chunk of data in the artifact system.
    /// </summary>
    public sealed partial class Chunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkUid")]
        public string? ChunkUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startPos")]
        public long? StartPos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endPos")]
        public long? EndPos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public long? Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("originalFileUid")]
        public string? OriginalFileUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        /// <param name="chunkUid"></param>
        /// <param name="retrievable"></param>
        /// <param name="startPos"></param>
        /// <param name="endPos"></param>
        /// <param name="tokens"></param>
        /// <param name="createTime"></param>
        /// <param name="originalFileUid"></param>
        public Chunk(
            string? chunkUid,
            bool? retrievable,
            long? startPos,
            long? endPos,
            long? tokens,
            global::System.DateTime? createTime,
            string? originalFileUid)
        {
            this.ChunkUid = chunkUid;
            this.Retrievable = retrievable;
            this.StartPos = startPos;
            this.EndPos = endPos;
            this.Tokens = tokens;
            this.CreateTime = createTime;
            this.OriginalFileUid = originalFileUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        public Chunk()
        {
        }
    }
}