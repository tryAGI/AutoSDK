//HintName: G.Models.SplitJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document split job.
    /// </summary>
    public sealed partial class SplitJobResponse
    {
        /// <summary>
        /// Unique identifier for the split job.
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
        /// Project ID this job belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// User ID who created this job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Split configuration ID used for this job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Document that was split.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SplitDocumentInput DocumentInput { get; set; } = default!;

        /// <summary>
        /// Categories used for splitting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SplitCategory> Categories { get; set; } = default!;

        /// <summary>
        /// Current status of the job. Valid values are: pending, processing, completed, failed, cancelled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Split result (available when status is COMPLETED).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.SplitResultResponse? Result { get; set; }

        /// <summary>
        /// Error message if the job failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitJobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the split job.
        /// </param>
        /// <param name="projectId">
        /// Project ID this job belongs to.
        /// </param>
        /// <param name="userId">
        /// User ID who created this job.
        /// </param>
        /// <param name="documentInput">
        /// Document that was split.
        /// </param>
        /// <param name="categories">
        /// Categories used for splitting.
        /// </param>
        /// <param name="status">
        /// Current status of the job. Valid values are: pending, processing, completed, failed, cancelled.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="configurationId">
        /// Split configuration ID used for this job.
        /// </param>
        /// <param name="result">
        /// Split result (available when status is COMPLETED).
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the job failed.
        /// </param>
        public SplitJobResponse(
            string id,
            string projectId,
            string userId,
            global::G.SplitDocumentInput documentInput,
            global::System.Collections.Generic.IList<global::G.SplitCategory> categories,
            string status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? configurationId,
            global::G.SplitResultResponse? result,
            string? errorMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ConfigurationId = configurationId;
            this.DocumentInput = documentInput ?? throw new global::System.ArgumentNullException(nameof(documentInput));
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Result = result;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitJobResponse" /> class.
        /// </summary>
        public SplitJobResponse()
        {
        }
    }
}