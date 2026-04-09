//HintName: G.IApiKeysClient.ListApiKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// List API keys<br/>
        /// List all API keys for the authenticated user.<br/>
        /// Args:<br/>
        ///     pagination: The pagination options<br/>
        /// Returns:<br/>
        ///     A list of API keys belonging to the user.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return per page<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Offset of the first item to return<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyListResponse> ListApiKeysAsync(
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}