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
        [global::System.Text.Json.Serialization.JsonPropertyName("log_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EPromptOptimizationJobLogTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EPromptOptimizationJobLogType LogType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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