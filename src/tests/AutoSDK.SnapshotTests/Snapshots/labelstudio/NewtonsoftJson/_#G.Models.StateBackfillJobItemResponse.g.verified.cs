//HintName: G.Models.StateBackfillJobItemResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillJobItemResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int JobId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress_data")]
        public global::G.StateBackfillProgress? ProgressData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rq_job_id")]
        public string? RqJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggered_by")]
        public global::G.StateTriggeredBy? TriggeredBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillJobItemResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="jobId"></param>
        /// <param name="status"></param>
        /// <param name="completedAt"></param>
        /// <param name="errorMessage"></param>
        /// <param name="progressData"></param>
        /// <param name="rqJobId"></param>
        /// <param name="startedAt"></param>
        /// <param name="triggeredBy"></param>
        public StateBackfillJobItemResponse(
            global::System.DateTime createdAt,
            int jobId,
            string status,
            global::System.DateTime? completedAt,
            string? errorMessage,
            global::G.StateBackfillProgress? progressData,
            string? rqJobId,
            global::System.DateTime? startedAt,
            global::G.StateTriggeredBy? triggeredBy)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.ErrorMessage = errorMessage;
            this.JobId = jobId;
            this.ProgressData = progressData;
            this.RqJobId = rqJobId;
            this.StartedAt = startedAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TriggeredBy = triggeredBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillJobItemResponse" /> class.
        /// </summary>
        public StateBackfillJobItemResponse()
        {
        }
    }
}