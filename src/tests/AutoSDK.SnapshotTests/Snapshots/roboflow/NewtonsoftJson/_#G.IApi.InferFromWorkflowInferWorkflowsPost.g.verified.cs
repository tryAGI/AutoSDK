//HintName: G.IApi.InferFromWorkflowInferWorkflowsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// [LEGACY] Endpoint to run workflow specification provided in payload<br/>
        /// Parses and executes workflow specification, injecting runtime parameters from request body. This endpoint is deprecated and will be removed end of Q2 2024.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.WorkflowInferenceResponse> InferFromWorkflowInferWorkflowsPostAsync(

            global::G.WorkflowSpecificationInferenceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [LEGACY] Endpoint to run workflow specification provided in payload<br/>
        /// Parses and executes workflow specification, injecting runtime parameters from request body. This endpoint is deprecated and will be removed end of Q2 2024.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="inputs">
        /// Dictionary that contains each parameter defined as an input for chosen workflow
        /// </param>
        /// <param name="excludedFields">
        /// List of field that shall be excluded from the response (among those defined in workflow specification)
        /// </param>
        /// <param name="enableProfiling">
        /// Flag to request Workflow run profiling. Enables Workflow profiler only when server settings allow profiling traces to be exported to clients. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="workflowId">
        /// Optional identifier of workflow
        /// </param>
        /// <param name="specification"></param>
        /// <param name="isPreview">
        /// Reserved, used internally by Roboflow to distinguish between preview and non-preview runs<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.WorkflowInferenceResponse> InferFromWorkflowInferWorkflowsPostAsync(
            object inputs,
            object specification,
            string? apiKey = default,
            global::System.Collections.Generic.IList<string>? excludedFields = default,
            bool? enableProfiling = default,
            string? workflowId = default,
            bool? isPreview = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}