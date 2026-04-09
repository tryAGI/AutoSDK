//HintName: G.IConnectorsClient.OAuthAuthorize.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectorsClient
    {
        /// <summary>
        /// Authorize with oAuth<br/>
        /// Authorize the connector with the given ID for the connector oauth app.  See ['Connector Authentication'](https://docs.cohere.com/docs/connector-authentication) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="afterTokenRedirect"></param>
        /// <param name="xClientName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OAuthAuthorizeResponse> OAuthAuthorizeAsync(
            string id,
            string? afterTokenRedirect = default,
            string? xClientName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}