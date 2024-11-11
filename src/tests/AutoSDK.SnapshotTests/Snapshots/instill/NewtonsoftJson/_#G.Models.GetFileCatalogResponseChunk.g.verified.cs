//HintName: G.Models.GetFileCatalogResponseChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFileCatalogResponseChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChunkType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startPos")]
        public int? StartPos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endPos")]
        public int? EndPos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokensNum")]
        public int? TokensNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::System.Collections.Generic.IList<float>? Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponseChunk" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="type"></param>
        /// <param name="startPos"></param>
        /// <param name="endPos"></param>
        /// <param name="content"></param>
        /// <param name="tokensNum"></param>
        /// <param name="embedding"></param>
        /// <param name="createTime"></param>
        /// <param name="retrievable"></param>
        public GetFileCatalogResponseChunk(
            string? uid,
            global::G.ChunkType? type,
            int? startPos,
            int? endPos,
            string? content,
            int? tokensNum,
            global::System.Collections.Generic.IList<float>? embedding,
            global::System.DateTime? createTime,
            bool? retrievable)
        {
            this.Uid = uid;
            this.Type = type;
            this.StartPos = startPos;
            this.EndPos = endPos;
            this.Content = content;
            this.TokensNum = tokensNum;
            this.Embedding = embedding;
            this.CreateTime = createTime;
            this.Retrievable = retrievable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponseChunk" /> class.
        /// </summary>
        public GetFileCatalogResponseChunk()
        {
        }
    }
}