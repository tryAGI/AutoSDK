//HintName: G.Models.Job.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A background job for processing long-running operations on the platform.
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
        /// Enum representing the possible states of a background job.
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job.
        /// </param>
        /// <param name="type">
        /// The type of job.
        /// </param>
        /// <param name="corpusKeys">
        /// The corpora that this job belongs to. It may not belong to any corpora.
        /// </param>
        /// <param name="state">
        /// Enum representing the possible states of a background job.
        /// </param>
        /// <param name="createdAt">
        /// Specifies when the job was created.
        /// </param>
        /// <param name="startedAt">
        /// Specifies when the job was started.
        /// </param>
        /// <param name="completedAt">
        /// Specifies when the job was completed.
        /// </param>
        /// <param name="createdByUsername">
        /// The username of the user who created the job. This property may be missing, e.g., if the job was created by the system, not a user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Job(
            string? id,
            global::G.JobType? type,
            global::System.Collections.Generic.IList<string>? corpusKeys,
            global::G.JobState? state,
            global::System.DateTime? createdAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            string? createdByUsername)
        {
            this.Id = id;
            this.Type = type;
            this.CorpusKeys = corpusKeys;
            this.State = state;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.CreatedByUsername = createdByUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }
    }
}