//HintName: G.Api.InferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareInferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceName,
            ref string workflowId,
            global::G.PredefinedWorkflowInferenceRequest request);
        partial void PrepareInferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceName,
            string workflowId,
            global::G.PredefinedWorkflowInferenceRequest request);
        partial void ProcessInferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.WorkflowInferenceResponse> InferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostAsync(
            string workspaceName,
            string workflowId,

            global::G.PredefinedWorkflowInferenceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostArguments(
                httpClient: HttpClient,
                workspaceName: ref workspaceName,
                workflowId: ref workflowId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/infer/workflows/{workspaceName}/{workflowId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareInferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workspaceName: workspaceName,
                workflowId: workflowId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessInferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessInferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.WorkflowInferenceResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.WorkflowInferenceResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::G.WorkflowInferenceResponse> InferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostAsync(
            string workspaceName,
            string workflowId,
            object inputs,
            string? apiKey = default,
            global::System.Collections.Generic.IList<string>? excludedFields = default,
            bool? enableProfiling = default,
            string? requestWorkflowId = default,
            bool? useCache = default,
            string? workflowVersionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.PredefinedWorkflowInferenceRequest
            {
                ApiKey = apiKey,
                Inputs = inputs,
                ExcludedFields = excludedFields,
                EnableProfiling = enableProfiling,
                WorkflowId = requestWorkflowId,
                UseCache = useCache,
                WorkflowVersionId = workflowVersionId,
            };

            return await InferFromPredefinedWorkflowInferWorkflowsWorkspaceNameWorkflowIdPostAsync(
                workspaceName: workspaceName,
                workflowId: workflowId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}