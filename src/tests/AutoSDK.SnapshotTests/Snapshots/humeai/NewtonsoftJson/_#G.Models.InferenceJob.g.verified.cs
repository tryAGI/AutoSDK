//HintName: G.Models.InferenceJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferenceJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.InferenceRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.JobState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InferenceJobType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_timestamp_ms")]
        public long? CreatedTimestampMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_timestamp_ms")]
        public long? StartedTimestampMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_timestamp_ms")]
        public long? EndedTimestampMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceJob" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="state"></param>
        /// <param name="type"></param>
        /// <param name="createdTimestampMs"></param>
        /// <param name="startedTimestampMs"></param>
        /// <param name="endedTimestampMs"></param>
        public InferenceJob(
            string? jobId,
            string? userId,
            global::G.InferenceRequest? request,
            global::G.JobState? state,
            global::G.InferenceJobType? type,
            long? createdTimestampMs,
            long? startedTimestampMs,
            long? endedTimestampMs)
        {
            this.JobId = jobId;
            this.UserId = userId;
            this.Request = request;
            this.State = state;
            this.Type = type;
            this.CreatedTimestampMs = createdTimestampMs;
            this.StartedTimestampMs = startedTimestampMs;
            this.EndedTimestampMs = endedTimestampMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceJob" /> class.
        /// </summary>
        public InferenceJob()
        {
        }
    }
}