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
        [global::Newtonsoft.Json.JsonProperty("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Status of the task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_status")]
        public global::G.TaskListDataTaskStatus? TaskStatus { get; set; }

        /// <summary>
        /// Human-readable task status message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_status_msg")]
        public string? TaskStatusMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_info")]
        public global::G.TaskInfo? TaskInfo { get; set; }

        /// <summary>
        /// Task creation timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Task last update timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_result")]
        public global::G.TaskResult? TaskResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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