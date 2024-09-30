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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.JobType? Type { get; set; }

        /// <summary>
        /// The corpora that this job belongs to. It may not belong to any corpora.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corpus_keys")]
        public global::System.Collections.Generic.IList<string>? CorpusKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.JobState? State { get; set; }

        /// <summary>
        /// Specifies when the job was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Specifies when the job was started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Specifies when the job was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}