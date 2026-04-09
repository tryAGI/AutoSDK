//HintName: G.IV2Client.CreateClassifyJobApiV2ClassifyPost.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Create Classify Job<br/>
        /// Create a classify job.<br/>
        /// Classifies a document against a set of rules. Provide either<br/>
        /// `file_id` or `parse_job_id` as the document input, and either<br/>
        /// inline `configuration` with rules or a `configuration_id`<br/>
        /// referencing a saved preset.<br/>
        /// Each rule has a `type` (the label to assign) and a `description`<br/>
        /// (natural language criteria). The classifier returns the best<br/>
        /// matching rule with a confidence score.<br/>
        /// The job runs asynchronously. Poll `GET /classify/{job_id}` to<br/>
        /// check status and retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassifyV2JobResponse> CreateClassifyJobApiV2ClassifyPostAsync(

            global::G.ClassifyV2JobCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Classify Job<br/>
        /// Create a classify job.<br/>
        /// Classifies a document against a set of rules. Provide either<br/>
        /// `file_id` or `parse_job_id` as the document input, and either<br/>
        /// inline `configuration` with rules or a `configuration_id`<br/>
        /// referencing a saved preset.<br/>
        /// Each rule has a `type` (the label to assign) and a `description`<br/>
        /// (natural language criteria). The classifier returns the best<br/>
        /// matching rule with a confidence score.<br/>
        /// The job runs asynchronously. Poll `GET /classify/{job_id}` to<br/>
        /// check status and retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="fileId">
        /// File ID to classify
        /// </param>
        /// <param name="parseJobId">
        /// Parse job ID to classify
        /// </param>
        /// <param name="configuration">
        /// Inline classify configuration (required if configuration_id is not provided)
        /// </param>
        /// <param name="configurationId">
        /// Product configuration ID for reusable presets
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key scoped to the project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassifyV2JobResponse> CreateClassifyJobApiV2ClassifyPostAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? fileId = default,
            string? parseJobId = default,
            global::G.ClassifyV2Configuration? configuration = default,
            string? configurationId = default,
            string? transactionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}