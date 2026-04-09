//HintName: G.IRedirectClient.DatasetsRedirect.g.cs
#nullable enable

namespace G
{
    public partial interface IRedirectClient
    {
        /// <summary>
        /// Create dataset redirect url<br/>
        /// Create dataset redirect url
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="workspaceName"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DatasetsRedirectAsync(
            global::System.Guid datasetId,
            string path,
            string? workspaceName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}