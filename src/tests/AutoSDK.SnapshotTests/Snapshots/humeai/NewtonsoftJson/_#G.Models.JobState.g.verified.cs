//HintName: G.Models.JobState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JobStateStatusJsonConverter))]
        public global::G.JobStateStatus? Status { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobState" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="createdTimestampMs"></param>
        /// <param name="startedTimestampMs"></param>
        /// <param name="endedTimestampMs"></param>
        /// <param name="message"></param>
        public JobState(
            global::G.JobStateStatus? status,
            long? createdTimestampMs,
            long? startedTimestampMs,
            long? endedTimestampMs,
            string? message)
        {
            this.Status = status;
            this.CreatedTimestampMs = createdTimestampMs;
            this.StartedTimestampMs = startedTimestampMs;
            this.EndedTimestampMs = endedTimestampMs;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobState" /> class.
        /// </summary>
        public JobState()
        {
        }
    }
}