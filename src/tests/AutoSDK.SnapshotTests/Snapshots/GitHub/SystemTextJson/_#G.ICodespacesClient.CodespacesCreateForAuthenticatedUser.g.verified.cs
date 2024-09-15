//HintName: G.ICodespacesClient.CodespacesCreateForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesCreateForAuthenticatedUserAsync(
            global::G.OneOf<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1, global::G.CodespacesCreateForAuthenticatedUserRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesCreateForAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}