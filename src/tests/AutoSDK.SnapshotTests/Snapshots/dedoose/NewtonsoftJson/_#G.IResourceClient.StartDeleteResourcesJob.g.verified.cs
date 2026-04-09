//HintName: G.IResourceClient.StartDeleteResourcesJob.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartDeleteResourcesJob<br/>
        /// StartDeleteResourcesJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartDeleteResourcesJobAsync(

            global::G.StartDeleteResourcesJobRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// StartDeleteResourcesJob<br/>
        /// StartDeleteResourcesJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartDeleteResourcesJobAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> resourceIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}