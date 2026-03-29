//HintName: G.Models.PropertiesDataPropertiesTaskInfosItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesTaskInfosItems
    {
        /// <summary>
        /// 创建时间，Unix 时间戳
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 结束时间，Unix 时间戳
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at")]
        public int? EndedAt { get; set; }

        /// <summary>
        /// 过期时间，Unix 时间戳
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_urls")]
        public global::System.Collections.Generic.IList<string>? FileUrls { get; set; }

        /// <summary>
        /// 开始时间，Unix 时间戳
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public int? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesTaskInfosItems" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// 创建时间，Unix 时间戳
        /// </param>
        /// <param name="endedAt">
        /// 结束时间，Unix 时间戳
        /// </param>
        /// <param name="expiresAt">
        /// 过期时间，Unix 时间戳
        /// </param>
        /// <param name="fileUrls"></param>
        /// <param name="startedAt">
        /// 开始时间，Unix 时间戳
        /// </param>
        /// <param name="status"></param>
        /// <param name="taskId"></param>
        public PropertiesDataPropertiesTaskInfosItems(
            int? createdAt,
            int? endedAt,
            int? expiresAt,
            global::System.Collections.Generic.IList<string>? fileUrls,
            int? startedAt,
            string? status,
            string? taskId)
        {
            this.CreatedAt = createdAt;
            this.EndedAt = endedAt;
            this.ExpiresAt = expiresAt;
            this.FileUrls = fileUrls;
            this.StartedAt = startedAt;
            this.Status = status;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesTaskInfosItems" /> class.
        /// </summary>
        public PropertiesDataPropertiesTaskInfosItems()
        {
        }
    }
}