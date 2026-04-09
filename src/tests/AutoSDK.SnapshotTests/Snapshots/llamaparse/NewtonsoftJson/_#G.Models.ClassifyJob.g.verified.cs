//HintName: G.Models.ClassifyJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A classify job.
    /// </summary>
    public sealed partial class ClassifyJob
    {
        /// <summary>
        /// The status of the classify job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StatusEnumJsonConverter))]
        public global::G.StatusEnum Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The job record ID associated with this status, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_record_id")]
        public string? JobRecordId { get; set; }

        /// <summary>
        /// Error message for the latest job attempt, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The rules to classify the files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rules", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ClassifierRule> Rules { get; set; } = default!;

        /// <summary>
        /// The ID of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The ID of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// The classification mode to use<br/>
        /// Default Value: FAST
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClassifyModeJsonConverter))]
        public global::G.ClassifyMode? Mode { get; set; }

        /// <summary>
        /// The configuration for the parsing job<br/>
        /// Default Value: {"lang":"en","max_pages":5}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsing_configuration")]
        public global::G.ClassifyParsingConfiguration? ParsingConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyJob" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the classify job
        /// </param>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="rules">
        /// The rules to classify the files
        /// </param>
        /// <param name="userId">
        /// The ID of the user
        /// </param>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="effectiveAt"></param>
        /// <param name="jobRecordId">
        /// The job record ID associated with this status, if any.
        /// </param>
        /// <param name="errorMessage">
        /// Error message for the latest job attempt, if any.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="mode">
        /// The classification mode to use<br/>
        /// Default Value: FAST
        /// </param>
        /// <param name="parsingConfiguration">
        /// The configuration for the parsing job<br/>
        /// Default Value: {"lang":"en","max_pages":5}
        /// </param>
        public ClassifyJob(
            global::G.StatusEnum status,
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::G.ClassifierRule> rules,
            string userId,
            global::System.Guid projectId,
            global::System.DateTime? effectiveAt,
            string? jobRecordId,
            string? errorMessage,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::G.ClassifyMode? mode,
            global::G.ClassifyParsingConfiguration? parsingConfiguration)
        {
            this.Status = status;
            this.EffectiveAt = effectiveAt;
            this.JobRecordId = jobRecordId;
            this.ErrorMessage = errorMessage;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ProjectId = projectId;
            this.Mode = mode;
            this.ParsingConfiguration = parsingConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyJob" /> class.
        /// </summary>
        public ClassifyJob()
        {
        }
    }
}