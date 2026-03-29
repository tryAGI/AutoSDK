//HintName: G.Models.GetAsyncApplicationJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAsyncApplicationJobResponse
    {
        /// <summary>
        /// The unique identifier for the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The status of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiJobStatus Status { get; set; }

        /// <summary>
        /// The ID of the application associated with this job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApplicationId { get; set; }

        /// <summary>
        /// The timestamp when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the job was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The timestamp when the job was completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.GenerateApplicationResponse? Data { get; set; }

        /// <summary>
        /// The error message if the job failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAsyncApplicationJobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the job.
        /// </param>
        /// <param name="status">
        /// The status of the job.
        /// </param>
        /// <param name="applicationId">
        /// The ID of the application associated with this job.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the job was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the job was last updated.
        /// </param>
        /// <param name="completedAt">
        /// The timestamp when the job was completed.
        /// </param>
        /// <param name="data"></param>
        /// <param name="error">
        /// The error message if the job failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAsyncApplicationJobResponse(
            global::System.Guid id,
            global::G.ApiJobStatus status,
            string applicationId,
            global::System.DateTime createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? completedAt,
            global::G.GenerateApplicationResponse? data,
            string? error)
        {
            this.Id = id;
            this.Status = status;
            this.ApplicationId = applicationId ?? throw new global::System.ArgumentNullException(nameof(applicationId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.Data = data;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAsyncApplicationJobResponse" /> class.
        /// </summary>
        public GetAsyncApplicationJobResponse()
        {
        }
    }
}