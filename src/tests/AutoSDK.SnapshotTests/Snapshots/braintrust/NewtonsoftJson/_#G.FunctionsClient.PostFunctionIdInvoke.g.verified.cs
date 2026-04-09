//HintName: G.FunctionsClient.PostFunctionIdInvoke.g.cs

#nullable enable

namespace G
{
    public partial class FunctionsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_PostFunctionIdInvokeSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_PostFunctionIdInvokeSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                { 
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_PostFunctionIdInvokeSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_PostFunctionIdInvokeSecurityRequirement0,
                s_PostFunctionIdInvokeSecurityRequirement1,
            };
        partial void PreparePostFunctionIdInvokeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid functionId,
            global::G.InvokeApi request);
        partial void PreparePostFunctionIdInvokeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid functionId,
            global::G.InvokeApi request);
        partial void ProcessPostFunctionIdInvokeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostFunctionIdInvokeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Invoke function<br/>
        /// Invoke a function.
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> PostFunctionIdInvokeAsync(
            global::System.Guid functionId,

            global::G.InvokeApi request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostFunctionIdInvokeArguments(
                httpClient: HttpClient,
                functionId: ref functionId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostFunctionIdInvokeSecurityRequirements,
                operationName: "PostFunctionIdInvokeAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/function/{functionId}/invoke",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostFunctionIdInvokeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                functionId: functionId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPostFunctionIdInvokeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessPostFunctionIdInvokeResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// Invoke function<br/>
        /// Invoke a function.
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="input">
        /// Argument to the function, which can be any JSON serializable value
        /// </param>
        /// <param name="expected">
        /// The expected output of the function
        /// </param>
        /// <param name="metadata">
        /// Any relevant metadata. This will be logged and available as the `metadata` argument.
        /// </param>
        /// <param name="tags">
        /// Any relevant tags to log on the span.
        /// </param>
        /// <param name="messages">
        /// If the function is an LLM, additional messages to pass along to it
        /// </param>
        /// <param name="parent">
        /// Options for tracing the function call
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response. If true, results will be returned in the Braintrust SSE format.
        /// </param>
        /// <param name="mode">
        /// The mode format of the returned value (defaults to 'auto')
        /// </param>
        /// <param name="strict">
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </param>
        /// <param name="mcpAuth">
        /// Map of MCP server URL to auth credentials
        /// </param>
        /// <param name="overrides">
        /// Partial function definition to merge with the function being invoked. Fields are validated against the function type's schema at runtime. For facets: { preprocessor?, prompt?, model? }. For prompts: { model?, ... }.
        /// </param>
        /// <param name="version">
        /// The version of the function
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> PostFunctionIdInvokeAsync(
            global::System.Guid functionId,
            object? input = default,
            object? expected = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageParam>? messages = default,
            global::G.InvokeParent? parent = default,
            bool? stream = default,
            global::G.StreamingMode? mode = default,
            bool? strict = default,
            global::System.Collections.Generic.Dictionary<string, global::G.InvokeApiMcpAuth2>? mcpAuth = default,
            global::System.Collections.Generic.Dictionary<string, object?>? overrides = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.InvokeApi
            {
                Input = input,
                Expected = expected,
                Metadata = metadata,
                Tags = tags,
                Messages = messages,
                Parent = parent,
                Stream = stream,
                Mode = mode,
                Strict = strict,
                McpAuth = mcpAuth,
                Overrides = overrides,
                Version = version,
            };

            return await PostFunctionIdInvokeAsync(
                functionId: functionId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}