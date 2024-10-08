//HintName: G.Models.Job.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Job
    {
        /// <summary>
        /// The ID of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobTypeJsonConverter))]
        public global::G.JobType? Type { get; set; }

        /// <summary>
        /// The corpora that this job belongs to. It may not belong to any corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_keys")]
        public global::System.Collections.Generic.IList<string>? CorpusKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobStateJsonConverter))]
        public global::G.JobState? State { get; set; }

        /// <summary>
        /// Specifies when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Specifies when the job was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Specifies when the job was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The username of the user who created the job. This property may be missing, e.g., if the job was created by the system, not a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_username")]
        public string? CreatedByUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}