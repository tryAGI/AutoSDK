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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobStateStatusJsonConverter))]
        public global::G.JobStateStatus? Status { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobState" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="createdTimestampMs"></param>
        /// <param name="startedTimestampMs"></param>
        /// <param name="endedTimestampMs"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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