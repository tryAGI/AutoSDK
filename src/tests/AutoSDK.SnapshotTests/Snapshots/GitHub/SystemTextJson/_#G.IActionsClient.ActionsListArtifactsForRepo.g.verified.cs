//HintName: G.IActionsClient.ActionsListArtifactsForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List artifacts for a repository<br/>
        /// Lists all artifacts for a repository.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsListArtifactsForRepoResponse> ActionsListArtifactsForRepoAsync(
            string owner,
            string repo,
            int? perPage = 30,
            int? page = 1,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}