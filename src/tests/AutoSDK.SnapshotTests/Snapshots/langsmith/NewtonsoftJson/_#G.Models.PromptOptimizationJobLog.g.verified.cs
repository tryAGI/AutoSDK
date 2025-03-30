//HintName: G.Models.PromptOptimizationJobLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJobLog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EPromptOptimizationJobLogType LogType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid JobId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobLog" /> class.
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <param name="jobId"></param>
        /// <param name="createdAt"></param>
        public PromptOptimizationJobLog(
            global::G.EPromptOptimizationJobLogType logType,
            string message,
            global::System.Guid id,
            global::System.Guid jobId,
            global::System.DateTime createdAt,
            object? data)
        {
            this.LogType = logType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Id = id;
            this.JobId = jobId;
            this.CreatedAt = createdAt;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobLog" /> class.
        /// </summary>
        public PromptOptimizationJobLog()
        {
        }
    }
}