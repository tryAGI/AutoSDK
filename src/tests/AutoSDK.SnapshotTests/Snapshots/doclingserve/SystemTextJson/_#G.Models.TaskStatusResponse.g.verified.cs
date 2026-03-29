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
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TaskTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TaskType TaskType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_position")]
        public int? TaskPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_meta")]
        public global::G.TaskProcessingMeta? TaskMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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