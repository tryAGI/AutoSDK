//HintName: G.Models.DocumentInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentInfo
    {
        /// <summary>
        /// 字符数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("char_count")]
        public int? CharCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_strategy")]
        public global::G.ChunkStrategy? ChunkStrategy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format_type")]
        public int? FormatType { get; set; }

        /// <summary>
        /// 命中次数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hit_count")]
        public int? HitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 文件大小 字节数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 包含分段数量
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slice_count")]
        public int? SliceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public int? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 文件链接
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tos_uri")]
        public string? TosUri { get; set; }

        /// <summary>
        /// 文件后缀 csv, pdf 等
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 更新间隔
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_interval")]
        public int? UpdateInterval { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_type")]
        public int? UpdateType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentInfo" /> class.
        /// </summary>
        /// <param name="charCount">
        /// 字符数
        /// </param>
        /// <param name="chunkStrategy"></param>
        /// <param name="createTime">
        /// 创建时间
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="formatType"></param>
        /// <param name="hitCount">
        /// 命中次数
        /// </param>
        /// <param name="name"></param>
        /// <param name="size">
        /// 文件大小 字节数
        /// </param>
        /// <param name="sliceCount">
        /// 包含分段数量
        /// </param>
        /// <param name="sourceType"></param>
        /// <param name="status"></param>
        /// <param name="tosUri">
        /// 文件链接
        /// </param>
        /// <param name="type">
        /// 文件后缀 csv, pdf 等
        /// </param>
        /// <param name="updateInterval">
        /// 更新间隔
        /// </param>
        /// <param name="updateTime">
        /// 更新时间
        /// </param>
        /// <param name="updateType"></param>
        public DocumentInfo(
            int? charCount,
            global::G.ChunkStrategy? chunkStrategy,
            int? createTime,
            string? documentId,
            int? formatType,
            int? hitCount,
            string? name,
            int? size,
            int? sliceCount,
            int? sourceType,
            int? status,
            string? tosUri,
            string? type,
            int? updateInterval,
            int? updateTime,
            int? updateType)
        {
            this.CharCount = charCount;
            this.ChunkStrategy = chunkStrategy;
            this.CreateTime = createTime;
            this.DocumentId = documentId;
            this.FormatType = formatType;
            this.HitCount = hitCount;
            this.Name = name;
            this.Size = size;
            this.SliceCount = sliceCount;
            this.SourceType = sourceType;
            this.Status = status;
            this.TosUri = tosUri;
            this.Type = type;
            this.UpdateInterval = updateInterval;
            this.UpdateTime = updateTime;
            this.UpdateType = updateType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentInfo" /> class.
        /// </summary>
        public DocumentInfo()
        {
        }
    }
}