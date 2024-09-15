//HintName: G.IActionsClient.ActionsReRunJobForWorkflowRun.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Re-run a job from a workflow run<br/>
        /// Re-run a job and its dependent jobs in a workflow run.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsReRunJobForWorkflowRunAsync(
            string owner,
            string repo,
            int jobId,
            global::G.ActionsReRunJobForWorkflowRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Re-run a job from a workflow run<br/>
        /// Re-run a job and its dependent jobs in a workflow run.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="jobId"></param>
        /// <param name="enableDebugLogging">
        /// Whether to enable debug logging for the re-run.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsReRunJobForWorkflowRunAsync(
            string owner,
            string repo,
            int jobId,
            bool enableDebugLogging = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}