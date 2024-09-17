//HintName: G.ICodespacesClient.CodespacesListForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// List codespaces for the authenticated user<br/>
        /// Lists the authenticated user's codespaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesListForAuthenticatedUserResponse> CodespacesListForAuthenticatedUserAsync(
            int? perPage = 30,
            int? page = 1,
            int? repositoryId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}