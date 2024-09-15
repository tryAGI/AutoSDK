//HintName: G.ICodespacesClient.CodespacesPublishForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Create a repository from an unpublished codespace<br/>
        /// Publishes an unpublished codespace, creating a new repository and assigning it to the codespace.<br/>
        /// The codespace's token is granted write permissions to the repository, allowing the user to push their changes.<br/>
        /// This will fail for a codespace that is already published, meaning it has an associated repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespaceWithFullRepository> CodespacesPublishForAuthenticatedUserAsync(
            string codespaceName,
            global::G.CodespacesPublishForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a repository from an unpublished codespace<br/>
        /// Publishes an unpublished codespace, creating a new repository and assigning it to the codespace.<br/>
        /// The codespace's token is granted write permissions to the repository, allowing the user to push their changes.<br/>
        /// This will fail for a codespace that is already published, meaning it has an associated repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="name">
        /// A name for the new repository.
        /// </param>
        /// <param name="private">
        /// Whether the new repository should be private.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespaceWithFullRepository> CodespacesPublishForAuthenticatedUserAsync(
            string codespaceName,
            string? name = default,
            bool @private = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}