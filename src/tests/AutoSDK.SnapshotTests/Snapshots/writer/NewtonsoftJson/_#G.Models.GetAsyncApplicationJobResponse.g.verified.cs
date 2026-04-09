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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The status of the job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiJobStatusJsonConverter))]
        public global::G.ApiJobStatus Status { get; set; } = default!;

        /// <summary>
        /// The ID of the application associated with this job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("application_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApplicationId { get; set; } = default!;

        /// <summary>
        /// The timestamp when the job was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The timestamp when the job was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The timestamp when the job was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.GenerateApplicationResponse? Data { get; set; }

        /// <summary>
        /// The error message if the job failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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