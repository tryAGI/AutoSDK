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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StatusEnum Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The job record ID associated with this status, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_record_id")]
        public string? JobRecordId { get; set; }

        /// <summary>
        /// Error message for the latest job attempt, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The rules to classify the files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ClassifierRule> Rules { get; set; }

        /// <summary>
        /// The ID of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The ID of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// The classification mode to use<br/>
        /// Default Value: FAST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifyModeJsonConverter))]
        public global::G.ClassifyMode? Mode { get; set; }

        /// <summary>
        /// The configuration for the parsing job<br/>
        /// Default Value: {"lang":"en","max_pages":5}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsing_configuration")]
        public global::G.ClassifyParsingConfiguration? ParsingConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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