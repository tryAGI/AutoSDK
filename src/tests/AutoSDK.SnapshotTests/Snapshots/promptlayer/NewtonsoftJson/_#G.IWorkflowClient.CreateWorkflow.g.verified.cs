//HintName: G.IWorkflowClient.CreateWorkflow.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Create Workflow
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateWorkflowResponse> CreateWorkflowAsync(

            global::G.CreateWorkflow request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workflow
        /// </summary>
        /// <param name="name">
        /// The name for a new workflow. If not provided, a name will be auto-generated.
        /// </param>
        /// <param name="workflowId">
        /// The ID of an existing workflow to create a new version for.
        /// </param>
        /// <param name="workflowName">
        /// The name of an existing workflow to create a new version for.
        /// </param>
        /// <param name="folderId">
        /// The folder ID to place the workflow in.
        /// </param>
        /// <param name="commitMessage">
        /// A message describing the changes in this version.
        /// </param>
        /// <param name="nodes">
        /// The nodes in the workflow.
        /// </param>
        /// <param name="requiredInputVariables">
        /// A mapping of variable names to their types.
        /// </param>
        /// <param name="edges">
        /// Conditional edges between nodes.
        /// </param>
        /// <param name="releaseLabels">
        /// Labels to attach to this version.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateWorkflowResponse> CreateWorkflowAsync(
            global::System.Collections.Generic.IList<global::G.WorkflowNode> nodes,
            string? name = default,
            int? workflowId = default,
            string? workflowName = default,
            int? folderId = default,
            string? commitMessage = default,
            global::System.Collections.Generic.Dictionary<string, string>? requiredInputVariables = default,
            global::System.Collections.Generic.IList<global::G.Edge>? edges = default,
            global::System.Collections.Generic.IList<string>? releaseLabels = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}