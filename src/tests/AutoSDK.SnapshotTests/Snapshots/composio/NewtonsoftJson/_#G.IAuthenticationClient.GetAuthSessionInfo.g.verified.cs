//HintName: G.IAuthenticationClient.GetAuthSessionInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Get current user session information<br/>
        /// Retrieves detailed information about the current authenticated user session, including project details, organization membership, and API key information if applicable. This endpoint is useful for verifying authentication status and retrieving contextual information about the authenticated user and their access privileges.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAuthSessionInfoResponse> GetAuthSessionInfoAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}