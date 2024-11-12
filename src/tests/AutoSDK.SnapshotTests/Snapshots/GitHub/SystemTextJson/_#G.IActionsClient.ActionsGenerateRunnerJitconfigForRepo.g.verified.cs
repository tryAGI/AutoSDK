//HintName: G.IActionsClient.ActionsGenerateRunnerJitconfigForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Create configuration for a just-in-time runner for a repository<br/>
        /// Generates a configuration that can be passed to the runner application at startup.<br/>
        /// The authenticated user must have admin access to the repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsGenerateRunnerJitconfigForRepoResponse> ActionsGenerateRunnerJitconfigForRepoAsync(
            string owner,
            string repo,
            global::G.ActionsGenerateRunnerJitconfigForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create configuration for a just-in-time runner for a repository<br/>
        /// Generates a configuration that can be passed to the runner application at startup.<br/>
        /// The authenticated user must have admin access to the repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name">
        /// The name of the new runner.
        /// </param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group to register the runner to.
        /// </param>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner. **Minimum items**: 1. **Maximum items**: 100.
        /// </param>
        /// <param name="workFolder">
        /// The working directory to be used for job execution, relative to the runner install directory.<br/>
        /// Default Value: _work
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsGenerateRunnerJitconfigForRepoResponse> ActionsGenerateRunnerJitconfigForRepoAsync(
            string owner,
            string repo,
            string name,
            int runnerGroupId,
            global::System.Collections.Generic.IList<string> labels,
            string? workFolder = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}