//HintName: G.ICodespacesClient.CodespacesExportForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Export a codespace for the authenticated user<br/>
        /// Triggers an export of the specified codespace and returns a URL and ID where the status of the export can be monitored.<br/>
        /// If changes cannot be pushed to the codespace's repository, they will be pushed to a new or previously-existing fork instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespaceExportDetails> CodespacesExportForAuthenticatedUserAsync(
            string codespaceName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}