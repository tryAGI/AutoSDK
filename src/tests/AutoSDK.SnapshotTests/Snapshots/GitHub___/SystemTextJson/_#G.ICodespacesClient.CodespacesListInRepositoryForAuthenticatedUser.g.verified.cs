//HintName: G.ICodespacesClient.CodespacesListInRepositoryForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// List codespaces in a repository for the authenticated user<br/>
        /// Lists the codespaces associated to a specified repository and the authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesListInRepositoryForAuthenticatedUserResponse> CodespacesListInRepositoryForAuthenticatedUserAsync(
            string owner,
            string repo,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}