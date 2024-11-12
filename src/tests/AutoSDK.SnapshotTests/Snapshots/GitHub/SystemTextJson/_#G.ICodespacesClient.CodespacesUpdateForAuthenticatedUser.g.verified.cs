//HintName: G.ICodespacesClient.CodespacesUpdateForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Update a codespace for the authenticated user<br/>
        /// Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.<br/>
        /// If you specify a new machine type it will be applied the next time your codespace is started.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesUpdateForAuthenticatedUserAsync(
            string codespaceName,
            global::G.CodespacesUpdateForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a codespace for the authenticated user<br/>
        /// Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.<br/>
        /// If you specify a new machine type it will be applied the next time your codespace is started.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="machine">
        /// A valid machine to transition this codespace to.
        /// </param>
        /// <param name="displayName">
        /// Display name for this codespace
        /// </param>
        /// <param name="recentFolders">
        /// Recently opened folders inside the codespace. It is currently used by the clients to determine the folder path to load the codespace in.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesUpdateForAuthenticatedUserAsync(
            string codespaceName,
            string? machine = default,
            string? displayName = default,
            global::System.Collections.Generic.IList<string>? recentFolders = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}