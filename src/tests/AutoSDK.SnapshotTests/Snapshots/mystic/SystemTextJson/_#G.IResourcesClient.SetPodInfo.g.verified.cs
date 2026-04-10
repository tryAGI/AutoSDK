//HintName: G.IResourcesClient.SetPodInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IResourcesClient
    {
        /// <summary>
        /// Set Pod Info
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SetPodInfoAsync(

            global::G.ResourcePodInfo request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Pod Info
        /// </summary>
        /// <param name="podName"></param>
        /// <param name="podIp"></param>
        /// <param name="nodeName"></param>
        /// <param name="state">
        /// An enumeration.
        /// </param>
        /// <param name="currentRun"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SetPodInfoAsync(
            string podName,
            string podIp,
            string nodeName,
            global::G.PipelineState state,
            string? currentRun = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}