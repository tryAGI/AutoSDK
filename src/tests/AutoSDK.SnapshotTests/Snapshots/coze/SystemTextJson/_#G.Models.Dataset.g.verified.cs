//HintName: G.Models.Dataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// 所有文件大小
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_file_size")]
        public int? AllFileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 使用Bot数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_used_count")]
        public int? BotUsedCount { get; set; }

        /// <summary>
        /// 是否可以编辑
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_edit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_strategy")]
        public global::G.ChunkStrategy? ChunkStrategy { get; set; }

        /// <summary>
        /// 创建时间，秒级时间戳
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_name")]
        public string? CreatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_type")]
        public int? DatasetType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 文档数量
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_count")]
        public int? DocCount { get; set; }

        /// <summary>
        /// 处理失败的文件
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_file_list")]
        public global::System.Collections.Generic.IList<string>? FailedFileList { get; set; }

        /// <summary>
        /// 文件列表
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_list")]
        public global::System.Collections.Generic.IList<string>? FileList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_type")]
        public int? FormatType { get; set; }

        /// <summary>
        /// 命中次数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hit_count")]
        public int? HitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_uri")]
        public string? IconUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 处理中的文件ID列表
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_file_id_list")]
        public global::System.Collections.Generic.IList<string>? ProcessingFileIdList { get; set; }

        /// <summary>
        /// 处理中的文件名称列表，兼容老逻辑
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_file_list")]
        public global::System.Collections.Generic.IList<string>? ProcessingFileList { get; set; }

        /// <summary>
        /// 分段数量
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slice_count")]
        public int? SliceCount { get; set; }

        /// <summary>
        /// 空间ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space_id")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_config")]
        public global::G.StorageConfig? StorageConfig { get; set; }

        /// <summary>
        /// 更新时间，秒级时间戳
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="allFileSize">
        /// 所有文件大小
        /// </param>
        /// <param name="avatarUrl"></param>
        /// <param name="botUsedCount">
        /// 使用Bot数
        /// </param>
        /// <param name="canEdit">
        /// 是否可以编辑
        /// </param>
        /// <param name="chunkStrategy"></param>
        /// <param name="createTime">
        /// 创建时间，秒级时间戳
        /// </param>
        /// <param name="creatorId">
        /// 创建者ID
        /// </param>
        /// <param name="creatorName"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetType"></param>
        /// <param name="description"></param>
        /// <param name="docCount">
        /// 文档数量
        /// </param>
        /// <param name="failedFileList">
        /// 处理失败的文件
        /// </param>
        /// <param name="fileList">
        /// 文件列表
        /// </param>
        /// <param name="formatType"></param>
        /// <param name="hitCount">
        /// 命中次数
        /// </param>
        /// <param name="iconUri"></param>
        /// <param name="iconUrl"></param>
        /// <param name="name">
        /// 数据集名称
        /// </param>
        /// <param name="processingFileIdList">
        /// 处理中的文件ID列表
        /// </param>
        /// <param name="processingFileList">
        /// 处理中的文件名称列表，兼容老逻辑
        /// </param>
        /// <param name="sliceCount">
        /// 分段数量
        /// </param>
        /// <param name="spaceId">
        /// 空间ID
        /// </param>
        /// <param name="status"></param>
        /// <param name="storageConfig"></param>
        /// <param name="updateTime">
        /// 更新时间，秒级时间戳
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            int? allFileSize,
            string? avatarUrl,
            int? botUsedCount,
            bool? canEdit,
            global::G.ChunkStrategy? chunkStrategy,
            int? createTime,
            string? creatorId,
            string? creatorName,
            string? datasetId,
            int? datasetType,
            string? description,
            int? docCount,
            global::System.Collections.Generic.IList<string>? failedFileList,
            global::System.Collections.Generic.IList<string>? fileList,
            int? formatType,
            int? hitCount,
            string? iconUri,
            string? iconUrl,
            string? name,
            global::System.Collections.Generic.IList<string>? processingFileIdList,
            global::System.Collections.Generic.IList<string>? processingFileList,
            int? sliceCount,
            string? spaceId,
            int? status,
            global::G.StorageConfig? storageConfig,
            int? updateTime)
        {
            this.AllFileSize = allFileSize;
            this.AvatarUrl = avatarUrl;
            this.BotUsedCount = botUsedCount;
            this.CanEdit = canEdit;
            this.ChunkStrategy = chunkStrategy;
            this.CreateTime = createTime;
            this.CreatorId = creatorId;
            this.CreatorName = creatorName;
            this.DatasetId = datasetId;
            this.DatasetType = datasetType;
            this.Description = description;
            this.DocCount = docCount;
            this.FailedFileList = failedFileList;
            this.FileList = fileList;
            this.FormatType = formatType;
            this.HitCount = hitCount;
            this.IconUri = iconUri;
            this.IconUrl = iconUrl;
            this.Name = name;
            this.ProcessingFileIdList = processingFileIdList;
            this.ProcessingFileList = processingFileList;
            this.SliceCount = sliceCount;
            this.SpaceId = spaceId;
            this.Status = status;
            this.StorageConfig = storageConfig;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}