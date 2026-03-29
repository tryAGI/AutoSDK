//HintName: G.Models.CreateTaskData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskData
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
        public string? TaskStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_info")]
        public global::G.TaskInfo? TaskInfo { get; set; }

        /// <summary>
        /// Task creation timestamp (Unix milliseconds).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Task last update timestamp (Unix milliseconds).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskData" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique task ID.
        /// </param>
        /// <param name="taskStatus">
        /// Status of the task.
        /// </param>
        /// <param name="taskInfo"></param>
        /// <param name="createdAt">
        /// Task creation timestamp (Unix milliseconds).
        /// </param>
        /// <param name="updatedAt">
        /// Task last update timestamp (Unix milliseconds).
        /// </param>
        public CreateTaskData(
            string? taskId,
            string? taskStatus,
            global::G.TaskInfo? taskInfo,
            long? createdAt,
            long? updatedAt)
        {
            this.TaskId = taskId;
            this.TaskStatus = taskStatus;
            this.TaskInfo = taskInfo;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskData" /> class.
        /// </summary>
        public CreateTaskData()
        {
        }
    }
}