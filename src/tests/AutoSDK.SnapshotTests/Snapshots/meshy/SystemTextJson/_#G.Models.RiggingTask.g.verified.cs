//HintName: G.Models.RiggingTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RiggingTask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TaskStatusJsonConverter))]
        public global::G.TaskStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public long? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public long? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_error")]
        public global::G.TaskError? TaskError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preceding_tasks")]
        public int? PrecedingTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.RiggingResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RiggingTask" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="progress"></param>
        /// <param name="createdAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="finishedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="taskError"></param>
        /// <param name="precedingTasks"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RiggingTask(
            string? id,
            string? type,
            global::G.TaskStatus? status,
            int? progress,
            long? createdAt,
            long? startedAt,
            long? finishedAt,
            long? expiresAt,
            global::G.TaskError? taskError,
            int? precedingTasks,
            global::G.RiggingResult? result)
        {
            this.Id = id;
            this.Type = type;
            this.Status = status;
            this.Progress = progress;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.ExpiresAt = expiresAt;
            this.TaskError = taskError;
            this.PrecedingTasks = precedingTasks;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiggingTask" /> class.
        /// </summary>
        public RiggingTask()
        {
        }
    }
}