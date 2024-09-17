//HintName: G.IActionsClient.ActionsReRunWorkflowFailedJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Re-run failed jobs from a workflow run<br/>
        /// Re-run all of the failed jobs and their dependent jobs in a workflow run using the `id` of the workflow run.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsReRunWorkflowFailedJobsAsync(
            string owner,
            string repo,
            int runId,
            global::G.ActionsReRunWorkflowFailedJobsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Re-run failed jobs from a workflow run<br/>
        /// Re-run all of the failed jobs and their dependent jobs in a workflow run using the `id` of the workflow run.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="enableDebugLogging">
        /// Whether to enable debug logging for the re-run.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsReRunWorkflowFailedJobsAsync(
            string owner,
            string repo,
            int runId,
            bool? enableDebugLogging = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}