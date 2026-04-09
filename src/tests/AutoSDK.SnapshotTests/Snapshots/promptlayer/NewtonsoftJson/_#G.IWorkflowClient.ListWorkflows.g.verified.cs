//HintName: G.IWorkflowClient.ListWorkflows.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowClient
    {
        /// <summary>
        /// List Workflows
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListWorkflowsResponse> ListWorkflowsAsync(
            int? page = default,
            int? perPage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}