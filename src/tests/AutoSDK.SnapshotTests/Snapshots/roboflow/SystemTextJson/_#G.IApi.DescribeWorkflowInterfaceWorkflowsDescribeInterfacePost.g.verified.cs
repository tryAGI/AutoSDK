//HintName: G.IApi.DescribeWorkflowInterfaceWorkflowsDescribeInterfacePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Endpoint to describe interface of workflow given in request<br/>
        /// Parses workflow definition and retrieves describes inputs and outputs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescribeInterfaceResponse> DescribeWorkflowInterfaceWorkflowsDescribeInterfacePostAsync(

            global::G.WorkflowSpecificationDescribeInterfaceRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Endpoint to describe interface of workflow given in request<br/>
        /// Parses workflow definition and retrieves describes inputs and outputs
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="specification"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescribeInterfaceResponse> DescribeWorkflowInterfaceWorkflowsDescribeInterfacePostAsync(
            string apiKey,
            object specification,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}