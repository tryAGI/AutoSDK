//HintName: G.IWorkflowClient.PatchWorkflow.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Patch Workflow
        /// </summary>
        /// <param name="workflowIdOrName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateWorkflowResponse> PatchWorkflowAsync(
            string workflowIdOrName,

            global::G.PatchWorkflow request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Workflow
        /// </summary>
        /// <param name="workflowIdOrName"></param>
        /// <param name="baseVersion">
        /// The version number to base changes on. Defaults to the latest version.
        /// </param>
        /// <param name="commitMessage">
        /// A message describing the changes.
        /// </param>
        /// <param name="nodes">
        /// Node updates keyed by node name. Use null to remove a node.
        /// </param>
        /// <param name="requiredInputVariables">
        /// If provided, replaces the input variables entirely.
        /// </param>
        /// <param name="edges">
        /// If provided, replaces edges entirely.
        /// </param>
        /// <param name="releaseLabels">
        /// Labels to attach to the new version.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateWorkflowResponse> PatchWorkflowAsync(
            string workflowIdOrName,
            int? baseVersion = default,
            string? commitMessage = default,
            object? nodes = default,
            global::System.Collections.Generic.Dictionary<string, string>? requiredInputVariables = default,
            global::System.Collections.Generic.IList<global::G.Edge>? edges = default,
            global::System.Collections.Generic.IList<string>? releaseLabels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}