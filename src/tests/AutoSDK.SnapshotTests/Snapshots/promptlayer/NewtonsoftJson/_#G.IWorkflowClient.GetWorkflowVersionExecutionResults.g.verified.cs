//HintName: G.IWorkflowClient.GetWorkflowVersionExecutionResults.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Get Workflow Version Execution Results
        /// </summary>
        /// <param name="workflowVersionExecutionId"></param>
        /// <param name="returnAllOutputs">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::System.Collections.Generic.Dictionary<string, global::G.GetWorkflowVersionExecutionResultsResponseVariant12>, object>> GetWorkflowVersionExecutionResultsAsync(
            long workflowVersionExecutionId,
            bool? returnAllOutputs = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}