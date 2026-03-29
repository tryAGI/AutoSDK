//HintName: G.Models.RetryAsyncApplicationJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetryAsyncApplicationJobResponse
    {
        /// <summary>
        /// The unique identifier for the retried async job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// The status of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiJobStatusJsonConverter))]
        public global::G.ApiJobStatus? Status { get; set; }

        /// <summary>
        /// The timestamp when the job was retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The ID of the application associated with this retried job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryAsyncApplicationJobResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The unique identifier for the retried async job.
        /// </param>
        /// <param name="status">
        /// The status of the job.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the job was retried.
        /// </param>
        /// <param name="applicationId">
        /// The ID of the application associated with this retried job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetryAsyncApplicationJobResponse(
            string jobId,
            global::G.ApiJobStatus? status,
            global::System.DateTime? createdAt,
            string? applicationId)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ApplicationId = applicationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryAsyncApplicationJobResponse" /> class.
        /// </summary>
        public RetryAsyncApplicationJobResponse()
        {
        }
    }
}