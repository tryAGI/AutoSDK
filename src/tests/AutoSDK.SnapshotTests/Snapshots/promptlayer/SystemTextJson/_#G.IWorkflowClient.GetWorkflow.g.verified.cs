//HintName: G.IWorkflowClient.GetWorkflow.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Get Agent
        /// </summary>
        /// <param name="workflowIdOrName"></param>
        /// <param name="version"></param>
        /// <param name="label"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWorkflowResponse> GetWorkflowAsync(
            string workflowIdOrName,
            int? version = default,
            string? label = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}