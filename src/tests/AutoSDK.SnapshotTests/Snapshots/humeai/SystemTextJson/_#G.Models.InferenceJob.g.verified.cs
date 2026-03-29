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
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::G.InferenceRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::G.JobState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InferenceJobTypeJsonConverter))]
        public global::G.InferenceJobType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp_ms")]
        public long? CreatedTimestampMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_timestamp_ms")]
        public long? StartedTimestampMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_timestamp_ms")]
        public long? EndedTimestampMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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