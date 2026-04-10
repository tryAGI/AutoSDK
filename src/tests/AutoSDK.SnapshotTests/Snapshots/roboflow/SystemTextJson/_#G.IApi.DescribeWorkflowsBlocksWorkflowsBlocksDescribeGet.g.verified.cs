//HintName: G.IApi.DescribeWorkflowsBlocksWorkflowsBlocksDescribeGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// [LEGACY] Endpoint to get definition of workflows blocks that are accessible<br/>
        /// Endpoint provides detailed information about workflows building blocks that are accessible in the inference server. This information could be used to programmatically build / display workflows.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.WorkflowsBlocksDescription> DescribeWorkflowsBlocksWorkflowsBlocksDescribeGetAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}