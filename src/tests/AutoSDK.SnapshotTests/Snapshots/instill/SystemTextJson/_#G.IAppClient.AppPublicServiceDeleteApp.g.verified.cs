//HintName: G.IAppClient.AppPublicServiceDeleteApp.g.cs
#nullable enable

namespace G
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Delete a app<br/>
        /// Deletes an app.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteAppResponse> AppPublicServiceDeleteAppAsync(
            string namespaceId,
            string appId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}