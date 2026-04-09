//HintName: G.ICodespacesClient.CodespacesCodespaceMachinesForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// List machine types for a codespace<br/>
        /// List the machine types a codespace can transition to use.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesCodespaceMachinesForAuthenticatedUserResponse> CodespacesCodespaceMachinesForAuthenticatedUserAsync(
            string codespaceName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}