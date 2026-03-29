//HintName: G.IClassifierClient.GetClassificationJobResultsApiV1ClassifierJobsClassifyJobIdResultsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IClassifierClient
    {
        /// <summary>
        /// Get Classification Job Results<br/>
        /// Get the results of a classify job.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="classifyJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassifyJobResults> GetClassificationJobResultsApiV1ClassifierJobsClassifyJobIdResultsGetAsync(
            global::System.Guid classifyJobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}