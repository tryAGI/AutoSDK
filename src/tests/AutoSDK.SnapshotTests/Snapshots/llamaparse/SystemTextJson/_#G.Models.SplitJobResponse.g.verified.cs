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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// Project ID this job belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// User ID who created this job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Split configuration ID used for this job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Document that was split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SplitDocumentInput DocumentInput { get; set; }

        /// <summary>
        /// Categories used for splitting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SplitCategory> Categories { get; set; }

        /// <summary>
        /// Current status of the job. Valid values are: pending, processing, completed, failed, cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Split result (available when status is COMPLETED).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.SplitResultResponse? Result { get; set; }

        /// <summary>
        /// Error message if the job failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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