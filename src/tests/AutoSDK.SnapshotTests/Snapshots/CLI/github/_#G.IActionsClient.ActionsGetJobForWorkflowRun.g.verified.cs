//HintName: G.IActionsClient.ActionsGetJobForWorkflowRun.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a job for a workflow run<br/>
        /// Gets a specific job in a workflow run.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Job> ActionsGetJobForWorkflowRunAsync(
            string owner,
            string repo,
            int jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}