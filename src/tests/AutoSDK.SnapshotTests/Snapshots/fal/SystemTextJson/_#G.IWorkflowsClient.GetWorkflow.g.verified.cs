//HintName: G.IWorkflowsClient.GetWorkflow.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Get workflow details<br/>
        /// Get detailed information about a specific workflow, including its full contents/definition.<br/>
        /// **Authentication:** Required.<br/>
        /// **Common Use Cases:**<br/>
        /// - Load a workflow for editing<br/>
        /// - View workflow configuration<br/>
        /// - Export workflow definition<br/>
        ///     
        /// </summary>
        /// <param name="username">
        /// The username of the workflow owner<br/>
        /// Example: johndoe
        /// </param>
        /// <param name="workflowName">
        /// The workflow name/slug<br/>
        /// Example: my-image-workflow
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWorkflowResponse> GetWorkflowAsync(
            string username,
            string workflowName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}