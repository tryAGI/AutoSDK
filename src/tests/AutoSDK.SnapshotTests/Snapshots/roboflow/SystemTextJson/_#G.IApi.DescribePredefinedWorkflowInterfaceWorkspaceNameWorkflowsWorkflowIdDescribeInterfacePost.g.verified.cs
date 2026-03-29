//HintName: G.IApi.DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Endpoint to describe interface of predefined workflow<br/>
        /// Checks Roboflow API for workflow definition, once acquired - describes workflow inputs and outputs
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescribeInterfaceResponse> DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync(
            string workspaceName,
            string workflowId,

            global::G.PredefinedWorkflowDescribeInterfaceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Endpoint to describe interface of predefined workflow<br/>
        /// Checks Roboflow API for workflow definition, once acquired - describes workflow inputs and outputs
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="workflowId"></param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="useCache">
        /// Controls usage of cache for workflow definitions. Set this to False when you frequently modify definition saved in Roboflow app and want to fetch the newest version for the request. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="workflowVersionId">
        /// Specific version of the workflow to fetch. If not provided, the latest version is used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescribeInterfaceResponse> DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync(
            string workspaceName,
            string workflowId,
            string apiKey,
            bool? useCache = default,
            string? workflowVersionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}