//HintName: G.ICodespacesClient.CodespacesListDevcontainersInRepositoryForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// List devcontainer configurations in a repository for the authenticated user<br/>
        /// Lists the devcontainer.json files associated with a specified repository and the authenticated user. These files<br/>
        /// specify launchpoint configurations for codespaces created within the repository.<br/>
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
        global::System.Threading.Tasks.Task<global::G.CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponse> CodespacesListDevcontainersInRepositoryForAuthenticatedUserAsync(
            string owner,
            string repo,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}