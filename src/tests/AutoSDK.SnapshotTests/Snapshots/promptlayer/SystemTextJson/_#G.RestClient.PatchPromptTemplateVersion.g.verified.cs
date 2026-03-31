//HintName: G.RestClient.PatchPromptTemplateVersion.g.cs

#nullable enable

namespace G
{
    public partial class RestClient
    {
        partial void PreparePatchPromptTemplateVersionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identifier,
            global::G.PatchPromptTemplateVersion request);
        partial void PreparePatchPromptTemplateVersionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identifier,
            global::G.PatchPromptTemplateVersion request);
        partial void ProcessPatchPromptTemplateVersionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchPromptTemplateVersionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch Prompt Template Version<br/>
        /// Partially update a prompt template by creating a new version with merged changes. This endpoint fetches a base version (latest by default), applies your patches, validates the result, and creates a new version.
        /// </summary>
        /// <param name="identifier">
        /// The prompt template name or ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreatePromptTemplateResponse> PatchPromptTemplateVersionAsync(
            string identifier,

            global::G.PatchPromptTemplateVersion request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePatchPromptTemplateVersionArguments(
                httpClient: HttpClient,
                identifier: ref identifier,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/rest/prompt-templates/{identifier}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PreparePatchPromptTemplateVersionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                identifier: identifier,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPatchPromptTemplateVersionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation error (e.g. conflicting fields, out-of-bounds index, wrong template type)
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized - missing or invalid API key
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.ErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.ErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Prompt template, version, or label not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.ErrorResponse? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.ErrorResponse.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.ErrorResponse.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
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
                ProcessPatchPromptTemplateVersionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreatePromptTemplateResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreatePromptTemplateResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Patch Prompt Template Version<br/>
        /// Partially update a prompt template by creating a new version with merged changes. This endpoint fetches a base version (latest by default), applies your patches, validates the result, and creates a new version.
        /// </summary>
        /// <param name="identifier">
        /// The prompt template name or ID.
        /// </param>
        /// <param name="version">
        /// The base version number to patch from. Mutually exclusive with `label`. If neither is provided, the latest version is used.
        /// </param>
        /// <param name="label">
        /// The release label identifying the base version to patch from (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="messages">
        /// Patch for chat template messages. Pass an object with index keys for index-based patching, or an array for full replacement. Chat templates only.
        /// </param>
        /// <param name="tools">
        /// Patch for tools. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </param>
        /// <param name="functions">
        /// Patch for functions. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </param>
        /// <param name="functionCall">
        /// Replace the function_call setting. Set to null to remove. Chat templates only.
        /// </param>
        /// <param name="toolChoice">
        /// Replace the tool_choice setting. Set to null to remove. Chat templates only.
        /// </param>
        /// <param name="content">
        /// Patch for completion template content. Object for index-based patching, array for full replacement. Completion templates only.
        /// </param>
        /// <param name="modelParameters">
        /// Parameters to shallow-merge into the existing model parameters (e.g. temperature, max_tokens). Existing keys not specified here are preserved.
        /// </param>
        /// <param name="responseFormat">
        /// Convenience field to set response_format in model parameters. Cannot be used simultaneously with response_format inside model_parameters. Set to null to remove.
        /// </param>
        /// <param name="commitMessage">
        /// A message describing the changes in this version.
        /// </param>
        /// <param name="releaseLabels">
        /// Release labels to create or move to the newly created version (e.g. ['staging', 'production']).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreatePromptTemplateResponse> PatchPromptTemplateVersionAsync(
            string identifier,
            int? version = default,
            string? label = default,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? messages = default,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? tools = default,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? functions = default,
            global::G.AnyOf<string, object, object>? functionCall = default,
            global::G.AnyOf<string, object, object>? toolChoice = default,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? content = default,
            object? modelParameters = default,
            object? responseFormat = default,
            string? commitMessage = default,
            global::System.Collections.Generic.IList<string>? releaseLabels = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.PatchPromptTemplateVersion
            {
                Version = version,
                Label = label,
                Messages = messages,
                Tools = tools,
                Functions = functions,
                FunctionCall = functionCall,
                ToolChoice = toolChoice,
                Content = content,
                ModelParameters = modelParameters,
                ResponseFormat = responseFormat,
                CommitMessage = commitMessage,
                ReleaseLabels = releaseLabels,
            };

            return await PatchPromptTemplateVersionAsync(
                identifier: identifier,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}