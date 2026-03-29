//HintName: G.Models.PhotoInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhotoInfo
    {
        /// <summary>
        /// 图片描述信息
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 图片大小
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public int? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 图片后缀 jpg, png 等
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhotoInfo" /> class.
        /// </summary>
        /// <param name="caption">
        /// 图片描述信息
        /// </param>
        /// <param name="createTime">
        /// 创建时间
        /// </param>
        /// <param name="creatorId">
        /// 创建人
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="name"></param>
        /// <param name="size">
        /// 图片大小
        /// </param>
        /// <param name="sourceType"></param>
        /// <param name="status"></param>
        /// <param name="type">
        /// 图片后缀 jpg, png 等
        /// </param>
        /// <param name="updateTime">
        /// 更新时间
        /// </param>
        /// <param name="url">
        /// 图片链接
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhotoInfo(
            string? caption,
            int? createTime,
            string? creatorId,
            string? documentId,
            string? name,
            int? size,
            int? sourceType,
            int? status,
            string? type,
            int? updateTime,
            string? url)
        {
            this.Caption = caption;
            this.CreateTime = createTime;
            this.CreatorId = creatorId;
            this.DocumentId = documentId;
            this.Name = name;
            this.Size = size;
            this.SourceType = sourceType;
            this.Status = status;
            this.Type = type;
            this.UpdateTime = updateTime;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhotoInfo" /> class.
        /// </summary>
        public PhotoInfo()
        {
        }
    }
}