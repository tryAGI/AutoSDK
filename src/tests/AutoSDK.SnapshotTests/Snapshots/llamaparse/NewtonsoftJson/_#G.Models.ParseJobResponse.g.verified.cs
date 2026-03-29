//HintName: G.Models.ParseJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A parse job.
    /// </summary>
    public sealed partial class ParseJobResponse
    {
        /// <summary>
        /// Unique parse job identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        /// Project this job belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Current job status: PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ParseJobResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// Error details when status is FAILED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Optional display name for this parse job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Parsing tier used for this job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseJobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique parse job identifier
        /// </param>
        /// <param name="projectId">
        /// Project this job belongs to
        /// </param>
        /// <param name="status">
        /// Current job status: PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="errorMessage">
        /// Error details when status is FAILED
        /// </param>
        /// <param name="name">
        /// Optional display name for this parse job
        /// </param>
        /// <param name="tier">
        /// Parsing tier used for this job
        /// </param>
        public ParseJobResponse(
            string id,
            string projectId,
            global::G.ParseJobResponseStatus status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? errorMessage,
            string? name,
            string? tier)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.Name = name;
            this.Tier = tier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseJobResponse" /> class.
        /// </summary>
        public ParseJobResponse()
        {
        }
    }
}