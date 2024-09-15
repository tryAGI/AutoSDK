//HintName: G.IActionsClient.ActionsAddCustomLabelsToSelfHostedRunnerForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Add custom labels to a self-hosted runner for a repository<br/>
        /// Adds custom labels to a self-hosted runner configured in a repository.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoResponse> ActionsAddCustomLabelsToSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add custom labels to a self-hosted runner for a repository<br/>
        /// Adds custom labels to a self-hosted runner configured in a repository.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoResponse> ActionsAddCustomLabelsToSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}