//HintName: G.Models.AnimationTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnimationTask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.TaskStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public long? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public long? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_error")]
        public global::G.TaskError? TaskError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preceding_tasks")]
        public int? PrecedingTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.AnimationResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationTask" /> class.
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
        public AnimationTask(
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
            global::G.AnimationResult? result)
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
        /// Initializes a new instance of the <see cref="AnimationTask" /> class.
        /// </summary>
        public AnimationTask()
        {
        }
    }
}