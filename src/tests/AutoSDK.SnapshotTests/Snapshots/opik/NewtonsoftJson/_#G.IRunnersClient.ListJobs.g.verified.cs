//HintName: G.IRunnersClient.ListJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// List local runner jobs<br/>
        /// List jobs for a local runner
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalRunnerJobPage> ListJobsAsync(
            global::System.Guid runnerId,
            global::System.Guid? projectId = default,
            int? page = default,
            int? size = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}