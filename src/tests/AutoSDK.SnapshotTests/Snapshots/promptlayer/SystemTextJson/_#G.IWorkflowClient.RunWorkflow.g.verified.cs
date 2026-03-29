//HintName: G.IWorkflowClient.RunWorkflow.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Run Workflow
        /// </summary>
        /// <param name="workflowName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunWorkflowResponse> RunWorkflowAsync(
            string workflowName,

            global::G.RunWorkflow request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Workflow
        /// </summary>
        /// <param name="workflowName"></param>
        /// <param name="workflowLabelName">
        /// Specify a workflow label name to run a specific labeled version.
        /// </param>
        /// <param name="workflowVersionNumber">
        /// Specify a workflow version number to run a specific version.
        /// </param>
        /// <param name="metadata">
        /// A dictionary of metadata key-value pairs.
        /// </param>
        /// <param name="inputVariables">
        /// A dictionary of input variables required by the workflow.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="returnAllOutputs">
        /// If set to `true`, all outputs from the workflow execution will be returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunWorkflowResponse> RunWorkflowAsync(
            string workflowName,
            string? workflowLabelName = default,
            int? workflowVersionNumber = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            object? inputVariables = default,
            bool? returnAllOutputs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}