//HintName: G.IActionsClient.ActionsReRunWorkflow.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Re-run a workflow<br/>
        /// Re-runs your workflow run using its `id`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsReRunWorkflowAsync(
            string owner,
            string repo,
            int runId,
            global::G.ActionsReRunWorkflowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Re-run a workflow<br/>
        /// Re-runs your workflow run using its `id`.<br/>
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
        global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsReRunWorkflowAsync(
            string owner,
            string repo,
            int runId,
            bool? enableDebugLogging = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}