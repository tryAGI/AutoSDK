//HintName: G.IApi.DescribeWorkflowsBlocksWorkflowsBlocksDescribePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// [EXPERIMENTAL] Endpoint to get definition of workflows blocks that are accessible<br/>
        /// Endpoint provides detailed information about workflows building blocks that are accessible in the inference server. This information could be used to programmatically build / display workflows. Additionally - in request body one can specify list of dynamic blocks definitions which will be transformed into blocks and used to generate schemas and definitions of connections
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_EXPERIMENTAL_001")]
#endif
        global::System.Threading.Tasks.Task<global::G.WorkflowsBlocksDescription> DescribeWorkflowsBlocksWorkflowsBlocksDescribePostAsync(

            global::G.DescribeBlocksRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [EXPERIMENTAL] Endpoint to get definition of workflows blocks that are accessible<br/>
        /// Endpoint provides detailed information about workflows building blocks that are accessible in the inference server. This information could be used to programmatically build / display workflows. Additionally - in request body one can specify list of dynamic blocks definitions which will be transformed into blocks and used to generate schemas and definitions of connections
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_EXPERIMENTAL_001")]
#endif
        global::System.Threading.Tasks.Task<global::G.WorkflowsBlocksDescription> DescribeWorkflowsBlocksWorkflowsBlocksDescribePostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}