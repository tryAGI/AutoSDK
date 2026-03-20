//HintName: G.IActionsClient.ActionsGetWorkflowRun.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a workflow run<br/>
        /// Gets a specific workflow run.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="excludePullRequests">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkflowRun> ActionsGetWorkflowRunAsync(
            string owner,
            string repo,
            int runId,
            bool? excludePullRequests = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}