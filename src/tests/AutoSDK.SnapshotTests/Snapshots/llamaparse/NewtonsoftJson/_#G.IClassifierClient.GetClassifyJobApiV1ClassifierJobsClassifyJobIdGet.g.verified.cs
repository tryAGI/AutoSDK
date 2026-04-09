//HintName: G.IClassifierClient.GetClassifyJobApiV1ClassifierJobsClassifyJobIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IClassifierClient
    {
        /// <summary>
        /// Get Classify Job<br/>
        /// Get a classify job.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="classifyJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassifyJob> GetClassifyJobApiV1ClassifierJobsClassifyJobIdGetAsync(
            global::System.Guid classifyJobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}