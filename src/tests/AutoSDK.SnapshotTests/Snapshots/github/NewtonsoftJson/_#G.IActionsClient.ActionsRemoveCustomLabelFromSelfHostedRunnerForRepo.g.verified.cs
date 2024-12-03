//HintName: G.IActionsClient.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Remove a custom label from a self-hosted runner for a repository<br/>
        /// Remove a custom label from a self-hosted runner configured<br/>
        /// in a repository. Returns the remaining labels from the runner.<br/>
        /// This endpoint returns a `404 Not Found` status if the custom label is not<br/>
        /// present on the runner.<br/>
        /// Authenticated users must have admin access to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponse> ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}