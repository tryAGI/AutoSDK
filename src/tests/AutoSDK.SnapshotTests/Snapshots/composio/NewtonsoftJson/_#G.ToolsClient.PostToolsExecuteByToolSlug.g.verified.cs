//HintName: G.ToolsClient.PostToolsExecuteByToolSlug.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class ToolsClient
    {
        partial void PreparePostToolsExecuteByToolSlugArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string toolSlug,
            ref string? xLlmGatewayHeaders,
            global::G.PostToolsExecuteByToolSlugRequest request);
        partial void PreparePostToolsExecuteByToolSlugRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string toolSlug,
            string? xLlmGatewayHeaders,
            global::G.PostToolsExecuteByToolSlugRequest request);
        partial void ProcessPostToolsExecuteByToolSlugResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostToolsExecuteByToolSlugResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Execute tool<br/>
        /// Execute a specific tool operation with provided arguments and authentication. This is the primary endpoint for integrating with third-party services and executing tools. You can provide structured arguments or use natural language processing by providing a text description of what you want to accomplish.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="xLlmGatewayHeaders">
        /// JSON object containing custom headers to pass to LLM providers (OpenAI, Bedrock, etc.)<br/>
        /// Example: {"x-custom-header": "value", "authorization": "Bearer token"}
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PostToolsExecuteByToolSlugResponse> PostToolsExecuteByToolSlugAsync(
            string toolSlug,

            global::G.PostToolsExecuteByToolSlugRequest request,
            string? xLlmGatewayHeaders = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostToolsExecuteByToolSlugArguments(
                httpClient: HttpClient,
                toolSlug: ref toolSlug,
                xLlmGatewayHeaders: ref xLlmGatewayHeaders,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/v3/tools/execute/{toolSlug}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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
            }

            if (xLlmGatewayHeaders != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-llm-gateway-headers", xLlmGatewayHeaders.ToString());
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
            PreparePostToolsExecuteByToolSlugRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                toolSlug: toolSlug,
                xLlmGatewayHeaders: xLlmGatewayHeaders,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPostToolsExecuteByToolSlugResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request - Invalid request parameters, missing required arguments, or conflicting parameters
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.Error? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.Error.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.Error.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
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
            // Unauthorized - Authentication credentials are missing or invalid
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.Error? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
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
            // Forbidden - Connected account does not have permission to execute this tool or access the requested resource
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.Error? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not found - Tool or connected account not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.Error? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.Error.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.Error.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
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
            // Request timeout - Tool execution exceeded the maximum allowed time
            if ((int)__response.StatusCode == 408)
            {
                string? __content_408 = null;
                global::System.Exception? __exception_408 = null;
                global::G.Error? __value_408 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_408 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_408 = global::G.Error.FromJson(__content_408, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_408 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_408 = global::G.Error.FromJson(__content_408, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_408 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_408 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_408,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_408,
                    ResponseObject = __value_408,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Gone - Tool has been deprecated and is no longer available
            if ((int)__response.StatusCode == 410)
            {
                string? __content_410 = null;
                global::System.Exception? __exception_410 = null;
                global::G.Error? __value_410 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_410 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_410 = global::G.Error.FromJson(__content_410, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_410 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_410 = global::G.Error.FromJson(__content_410, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_410 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_410 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_410,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_410,
                    ResponseObject = __value_410,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Payload too large - Request or response payload exceeds size limits
            if ((int)__response.StatusCode == 413)
            {
                string? __content_413 = null;
                global::System.Exception? __exception_413 = null;
                global::G.Error? __value_413 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_413 = global::G.Error.FromJson(__content_413, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_413 = global::G.Error.FromJson(__content_413, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_413 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_413,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_413,
                    ResponseObject = __value_413,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unprocessable entity - Invalid state of the connected account
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.Error? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.Error.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.Error.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
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
            // Rate limit exceeded - Too many requests to the tool or underlying API
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.Error? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.Error.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.Error.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error - Something went wrong on the server
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.Error? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not implemented
            if ((int)__response.StatusCode == 501)
            {
                string? __content_501 = null;
                global::System.Exception? __exception_501 = null;
                global::G.Error? __value_501 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_501 = global::G.Error.FromJson(__content_501, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_501 = global::G.Error.FromJson(__content_501, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_501 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_501 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_501,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_501,
                    ResponseObject = __value_501,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Bad gateway - Error communicating with the tool provider API
            if ((int)__response.StatusCode == 502)
            {
                string? __content_502 = null;
                global::System.Exception? __exception_502 = null;
                global::G.Error? __value_502 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_502 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_502 = global::G.Error.FromJson(__content_502, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_502 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_502 = global::G.Error.FromJson(__content_502, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_502 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_502 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_502,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_502,
                    ResponseObject = __value_502,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Upstream service unavailable - Tool provider API is currently down or unavailable
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::System.Exception? __exception_503 = null;
                global::G.Error? __value_503 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_503 = global::G.Error.FromJson(__content_503, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_503 = global::G.Error.FromJson(__content_503, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_503 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_503,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
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
                ProcessPostToolsExecuteByToolSlugResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PostToolsExecuteByToolSlugResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PostToolsExecuteByToolSlugResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Execute tool<br/>
        /// Execute a specific tool operation with provided arguments and authentication. This is the primary endpoint for integrating with third-party services and executing tools. You can provide structured arguments or use natural language processing by providing a text description of what you want to accomplish.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="xLlmGatewayHeaders">
        /// JSON object containing custom headers to pass to LLM providers (OpenAI, Bedrock, etc.)<br/>
        /// Example: {"x-custom-header": "value", "authorization": "Bearer token"}
        /// </param>
        /// <param name="connectedAccountId">
        /// Unique identifier for the connected account to use for authentication<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </param>
        /// <param name="userId">
        /// User id for multi-user connected accounts (e.g. multiple users, organizations)<br/>
        /// Example: user-123
        /// </param>
        /// <param name="version">
        /// Tool version to execute (defaults to "00000000_00" if not specified)<br/>
        /// Example: latest
        /// </param>
        /// <param name="customAuthParams">
        /// Custom authentication parameters for tools that support parameterized authentication<br/>
        /// Example: {"base_url":"https://api.example.com","parameters":[{"name":"x-api-key","value":"secret-key","in":"header"}]}
        /// </param>
        /// <param name="customConnectionData">
        /// Custom connection data for tools that support custom connection data<br/>
        /// Example: {"authScheme":"OAUTH2","toolkitSlug":"github","val":{"access_token":"secret-token"}}
        /// </param>
        /// <param name="arguments">
        /// Key-value pairs of arguments required by the tool (mutually exclusive with text)<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="text">
        /// Natural language description of the task to perform (mutually exclusive with arguments)<br/>
        /// Example: Trigger the main workflow in the octocat/Hello-World repository on the main branch for the production environment
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PostToolsExecuteByToolSlugResponse> PostToolsExecuteByToolSlugAsync(
            string toolSlug,
            string? xLlmGatewayHeaders = default,
            string? connectedAccountId = default,
            string? userId = default,
            string? version = default,
            global::G.PostToolsExecuteByToolSlugRequestCustomAuthParams? customAuthParams = default,
            global::G.OneOf<global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>? customConnectionData = default,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments = default,
            string? text = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PostToolsExecuteByToolSlugRequest
            {
                ConnectedAccountId = connectedAccountId,
                UserId = userId,
                Version = version,
                CustomAuthParams = customAuthParams,
                CustomConnectionData = customConnectionData,
                Arguments = arguments,
                Text = text,
            };

            return await PostToolsExecuteByToolSlugAsync(
                toolSlug: toolSlug,
                xLlmGatewayHeaders: xLlmGatewayHeaders,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}