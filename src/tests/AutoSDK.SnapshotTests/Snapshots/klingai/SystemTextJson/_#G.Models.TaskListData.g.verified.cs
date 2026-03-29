//HintName: G.Models.TaskListData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskListData
    {
        /// <summary>
        /// Unique task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Status of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TaskListDataTaskStatusJsonConverter))]
        public global::G.TaskListDataTaskStatus? TaskStatus { get; set; }

        /// <summary>
        /// Human-readable task status message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_status_msg")]
        public string? TaskStatusMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_info")]
        public global::G.TaskInfo? TaskInfo { get; set; }

        /// <summary>
        /// Task creation timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Task last update timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_result")]
        public global::G.TaskResult? TaskResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListData" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique task ID.
        /// </param>
        /// <param name="taskStatus">
        /// Status of the task.
        /// </param>
        /// <param name="taskStatusMsg">
        /// Human-readable task status message.
        /// </param>
        /// <param name="taskInfo"></param>
        /// <param name="createdAt">
        /// Task creation timestamp.
        /// </param>
        /// <param name="updatedAt">
        /// Task last update timestamp.
        /// </param>
        /// <param name="taskResult"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskListData(
            string? taskId,
            global::G.TaskListDataTaskStatus? taskStatus,
            string? taskStatusMsg,
            global::G.TaskInfo? taskInfo,
            long? createdAt,
            long? updatedAt,
            global::G.TaskResult? taskResult)
        {
            this.TaskId = taskId;
            this.TaskStatus = taskStatus;
            this.TaskStatusMsg = taskStatusMsg;
            this.TaskInfo = taskInfo;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TaskResult = taskResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListData" /> class.
        /// </summary>
        public TaskListData()
        {
        }
    }
}