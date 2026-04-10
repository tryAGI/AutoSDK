//HintName: G.Models.OpenCopyTaskInfoData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenCopyTaskInfoData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TaskEntityTypeJsonConverter))]
        public global::G.TaskEntityType? EntityType { get; set; }

        /// <summary>
        /// 失败原因汇总
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_reasons")]
        public global::System.Collections.Generic.IList<global::G.TaskFailedReason>? FailedReasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_entity_id")]
        public string? SourceEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_entity_id")]
        public string? TargetEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_workspace_id")]
        public string? TargetWorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TaskStatusJsonConverter))]
        public global::G.TaskStatus? TaskStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCopyTaskInfoData" /> class.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="failedReasons">
        /// 失败原因汇总
        /// </param>
        /// <param name="sourceEntityId"></param>
        /// <param name="targetEntityId"></param>
        /// <param name="targetWorkspaceId"></param>
        /// <param name="taskId"></param>
        /// <param name="taskStatus"></param>
        public OpenCopyTaskInfoData(
            global::G.TaskEntityType? entityType,
            global::System.Collections.Generic.IList<global::G.TaskFailedReason>? failedReasons,
            string? sourceEntityId,
            string? targetEntityId,
            string? targetWorkspaceId,
            string? taskId,
            global::G.TaskStatus? taskStatus)
        {
            this.EntityType = entityType;
            this.FailedReasons = failedReasons;
            this.SourceEntityId = sourceEntityId;
            this.TargetEntityId = targetEntityId;
            this.TargetWorkspaceId = targetWorkspaceId;
            this.TaskId = taskId;
            this.TaskStatus = taskStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCopyTaskInfoData" /> class.
        /// </summary>
        public OpenCopyTaskInfoData()
        {
        }
    }
}