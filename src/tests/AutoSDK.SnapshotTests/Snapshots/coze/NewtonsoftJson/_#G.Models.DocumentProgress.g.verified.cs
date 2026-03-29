//HintName: G.Models.DocumentProgress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_name")]
        public string? DocumentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remaining_time")]
        public int? RemainingTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 状态的详细描述；如果切片失败，返回失败信息
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_descript")]
        public string? StatusDescript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 更新间隔
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_interval")]
        public int? UpdateInterval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_type")]
        public int? UpdateType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentProgress" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="documentName"></param>
        /// <param name="progress"></param>
        /// <param name="remainingTime"></param>
        /// <param name="size"></param>
        /// <param name="status"></param>
        /// <param name="statusDescript">
        /// 状态的详细描述；如果切片失败，返回失败信息
        /// </param>
        /// <param name="type"></param>
        /// <param name="updateInterval">
        /// 更新间隔
        /// </param>
        /// <param name="updateType"></param>
        /// <param name="url"></param>
        public DocumentProgress(
            string? documentId,
            string? documentName,
            int? progress,
            int? remainingTime,
            int? size,
            int? status,
            string? statusDescript,
            string? type,
            int? updateInterval,
            int? updateType,
            string? url)
        {
            this.DocumentId = documentId;
            this.DocumentName = documentName;
            this.Progress = progress;
            this.RemainingTime = remainingTime;
            this.Size = size;
            this.Status = status;
            this.StatusDescript = statusDescript;
            this.Type = type;
            this.UpdateInterval = updateInterval;
            this.UpdateType = updateType;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentProgress" /> class.
        /// </summary>
        public DocumentProgress()
        {
        }
    }
}