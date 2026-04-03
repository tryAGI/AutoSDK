//HintName: G.PromptTemplatesClient.GetPromptTemplateRaw.g.cs

#nullable enable

namespace G
{
    public partial class PromptTemplatesClient
    {
        partial void PrepareGetPromptTemplateRawArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identifier,
            ref int? version,
            ref string? label,
            ref bool? resolveSnippets,
            ref bool? includeLlmKwargs);
        partial void PrepareGetPromptTemplateRawRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identifier,
            int? version,
            string? label,
            bool? resolveSnippets,
            bool? includeLlmKwargs);
        partial void ProcessGetPromptTemplateRawResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPromptTemplateRawResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Prompt Template Raw Data<br/>
        /// Retrieve raw prompt template data without applying input variables. Designed for GitHub sync, local caching, and template inspection. By default, snippets are resolved (expanded). Use resolve_snippets=false to get the raw template with snippet references intact.
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="version">
        /// Specific version number to retrieve. Mutually exclusive with `label`.
        /// </param>
        /// <param name="label">
        /// Release label name to retrieve (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="resolveSnippets">
        /// When true (default), snippets are expanded in the returned prompt_template. When false, raw @@@snippet@@@ references are preserved.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeLlmKwargs">
        /// When true, includes provider-specific llm_kwargs in the response. Requires model metadata to be set on the template.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetPromptTemplateRawResponse> GetPromptTemplateRawAsync(
            string identifier,
            int? version = default,
            string? label = default,
            bool? resolveSnippets = default,
            bool? includeLlmKwargs = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetPromptTemplateRawArguments(
                httpClient: HttpClient,
                identifier: ref identifier,
                version: ref version,
                label: ref label,
                resolveSnippets: ref resolveSnippets,
                includeLlmKwargs: ref includeLlmKwargs);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/prompt-templates/{identifier}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("version", version?.ToString())
                .AddOptionalParameter("label", label)
                .AddOptionalParameter("resolve_snippets", resolveSnippets?.ToString().ToLowerInvariant())
                .AddOptionalParameter("include_llm_kwargs", includeLlmKwargs?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetPromptTemplateRawRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                identifier: identifier,
                version: version,
                label: label,
                resolveSnippets: resolveSnippets,
                includeLlmKwargs: includeLlmKwargs);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetPromptTemplateRawResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Prompt template not found
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
                ProcessGetPromptTemplateRawResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetPromptTemplateRawResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetPromptTemplateRawResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}