//HintName: G.Models.DubJobStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubJobStatusResponse
    {
        /// <summary>
        /// Your Project Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Your Job Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Your Job Status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_details")]
        public global::System.Collections.Generic.IList<global::G.DubApiDetailResponse>? DownloadDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_used")]
        public long? CreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_remaining")]
        public long? CreditsRemaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_code")]
        public string? FailureCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubJobStatusResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Your Job Id
        /// </param>
        /// <param name="status">
        /// Your Job Status
        /// </param>
        /// <param name="projectId">
        /// Your Project Id
        /// </param>
        /// <param name="downloadDetails"></param>
        /// <param name="creditsUsed"></param>
        /// <param name="creditsRemaining"></param>
        /// <param name="failureReason"></param>
        /// <param name="failureCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubJobStatusResponse(
            string jobId,
            string status,
            string? projectId,
            global::System.Collections.Generic.IList<global::G.DubApiDetailResponse>? downloadDetails,
            long? creditsUsed,
            long? creditsRemaining,
            string? failureReason,
            string? failureCode)
        {
            this.ProjectId = projectId;
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.DownloadDetails = downloadDetails;
            this.CreditsUsed = creditsUsed;
            this.CreditsRemaining = creditsRemaining;
            this.FailureReason = failureReason;
            this.FailureCode = failureCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubJobStatusResponse" /> class.
        /// </summary>
        public DubJobStatusResponse()
        {
        }
    }
}