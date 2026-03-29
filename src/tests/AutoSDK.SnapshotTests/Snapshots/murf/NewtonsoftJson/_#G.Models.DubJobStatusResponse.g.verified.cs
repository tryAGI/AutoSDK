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
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Your Job Id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// Your Job Status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_details")]
        public global::System.Collections.Generic.IList<global::G.DubApiDetailResponse>? DownloadDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_used")]
        public long? CreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_remaining")]
        public long? CreditsRemaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_code")]
        public string? FailureCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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