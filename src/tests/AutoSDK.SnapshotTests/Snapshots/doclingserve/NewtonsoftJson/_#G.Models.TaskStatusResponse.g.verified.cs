//HintName: G.Models.TaskStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TaskTypeJsonConverter))]
        public global::G.TaskType TaskType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_status", Required = global::Newtonsoft.Json.Required.Always)]
        public string TaskStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_position")]
        public int? TaskPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_meta")]
        public global::G.TaskProcessingMeta? TaskMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStatusResponse" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="taskType"></param>
        /// <param name="taskStatus"></param>
        /// <param name="taskPosition"></param>
        /// <param name="taskMeta"></param>
        /// <param name="errorMessage"></param>
        public TaskStatusResponse(
            string taskId,
            global::G.TaskType taskType,
            string taskStatus,
            int? taskPosition,
            global::G.TaskProcessingMeta? taskMeta,
            string? errorMessage)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.TaskType = taskType;
            this.TaskStatus = taskStatus ?? throw new global::System.ArgumentNullException(nameof(taskStatus));
            this.TaskPosition = taskPosition;
            this.TaskMeta = taskMeta;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStatusResponse" /> class.
        /// </summary>
        public TaskStatusResponse()
        {
        }
    }
}