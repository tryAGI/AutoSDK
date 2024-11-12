//HintName: G.IActionsClient.ActionsDeleteWorkflowRun.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete a workflow run<br/>
        /// Deletes a specific workflow run.<br/>
        /// Anyone with write access to the repository can use this endpoint.<br/>
        /// If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsDeleteWorkflowRunAsync(
            string owner,
            string repo,
            int runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}