//HintName: G.Models.RemeshTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemeshTask
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
        [global::Newtonsoft.Json.JsonProperty("model_urls")]
        public global::G.ModelUrlsRemesh? ModelUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.RemeshTaskStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preceding_tasks")]
        public int? PrecedingTasks { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("task_error")]
        public global::G.TaskError? TaskError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemeshTask" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="modelUrls"></param>
        /// <param name="progress"></param>
        /// <param name="status"></param>
        /// <param name="precedingTasks"></param>
        /// <param name="createdAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="finishedAt"></param>
        /// <param name="taskError"></param>
        public RemeshTask(
            string? id,
            string? type,
            global::G.ModelUrlsRemesh? modelUrls,
            int? progress,
            global::G.RemeshTaskStatus? status,
            int? precedingTasks,
            long? createdAt,
            long? startedAt,
            long? finishedAt,
            global::G.TaskError? taskError)
        {
            this.Id = id;
            this.Type = type;
            this.ModelUrls = modelUrls;
            this.Progress = progress;
            this.Status = status;
            this.PrecedingTasks = precedingTasks;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.TaskError = taskError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemeshTask" /> class.
        /// </summary>
        public RemeshTask()
        {
        }
    }
}