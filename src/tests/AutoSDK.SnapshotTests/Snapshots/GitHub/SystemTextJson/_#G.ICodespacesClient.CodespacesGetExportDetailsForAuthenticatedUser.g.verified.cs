//HintName: G.ICodespacesClient.CodespacesGetExportDetailsForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Get details about a codespace export<br/>
        /// Gets information about an export of a codespace.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="exportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespaceExportDetails> CodespacesGetExportDetailsForAuthenticatedUserAsync(
            string codespaceName,
            string exportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}