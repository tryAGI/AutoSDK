//HintName: G.IToolsClient.SetToolDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Set Tool Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolResponse> SetToolDeploymentAsync(
            string id,
            string environmentId,

            global::G.SetDeploymentRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Tool Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="versionId">
        /// Version ID to deploy.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolResponse> SetToolDeploymentAsync(
            string id,
            string environmentId,
            string versionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}