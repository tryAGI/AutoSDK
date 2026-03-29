//HintName: G.IWorkflowClient.GetWorkflowLabels.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// Get Agent Labels
        /// </summary>
        /// <param name="workflowIdOrName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWorkflowLabelsResponse> GetWorkflowLabelsAsync(
            string workflowIdOrName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}