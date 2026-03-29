//HintName: G.IApi.InferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// [LEGACY] Endpoint to run predefined workflow<br/>
        /// Checks Roboflow API for workflow definition, once acquired - parses and executes injecting runtime parameters from request body. This endpoint is deprecated and will be removed end of Q2 2024
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.WorkflowInferenceResponse> InferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostAsync(
            string workspaceName,
            string workflowId,

            global::G.PredefinedWorkflowInferenceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [LEGACY] Endpoint to run predefined workflow<br/>
        /// Checks Roboflow API for workflow definition, once acquired - parses and executes injecting runtime parameters from request body. This endpoint is deprecated and will be removed end of Q2 2024
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="workflowId"></param>
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
        /// <param name="requestWorkflowId">
        /// Optional identifier of workflow
        /// </param>
        /// <param name="useCache">
        /// Controls usage of cache for workflow definitions. Set this to False when you frequently modify definition saved in Roboflow app and want to fetch the newest version for the request.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="workflowVersionId">
        /// Specific version of the workflow to fetch. If not provided, the latest version is used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.WorkflowInferenceResponse> InferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostAsync(
            string workspaceName,
            string workflowId,
            object inputs,
            string? apiKey = default,
            global::System.Collections.Generic.IList<string>? excludedFields = default,
            bool? enableProfiling = default,
            string? requestWorkflowId = default,
            bool? useCache = default,
            string? workflowVersionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}