//HintName: G.IActionsClient.ActionsListWorkflowRunArtifacts.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List workflow run artifacts<br/>
        /// Lists artifacts for a workflow run.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsListWorkflowRunArtifactsResponse> ActionsListWorkflowRunArtifactsAsync(
            string owner,
            string repo,
            int runId,
            int? perPage = default,
            int? page = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}