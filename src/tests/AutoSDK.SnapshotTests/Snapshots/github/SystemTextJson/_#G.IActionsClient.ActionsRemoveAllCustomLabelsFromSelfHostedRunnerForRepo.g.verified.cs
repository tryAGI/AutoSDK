//HintName: G.IActionsClient.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Remove all custom labels from a self-hosted runner for a repository<br/>
        /// Remove all custom labels from a self-hosted runner configured in a<br/>
        /// repository. Returns the remaining read-only labels from the runner.<br/>
        /// Authenticated users must have admin access to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoResponse> ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}