//HintName: G.IV2Client.GetClassifyJobApiV2ClassifyJobIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Get Classify Job<br/>
        /// Get a classify job by ID.<br/>
        /// Returns the job status, configuration, and classify result<br/>
        /// when complete. The result includes the matched document type,<br/>
        /// confidence score, and reasoning.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassifyV2JobResponse> GetClassifyJobApiV2ClassifyJobIdGetAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}