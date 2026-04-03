//HintName: G.OllamaClient.TestConnection.g.cs

#nullable enable

namespace G
{
    public partial class OllamaClient
    {
        partial void PrepareTestConnectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.OllamaInstanceBaseUrlRequest request);
        partial void PrepareTestConnectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OllamaInstanceBaseUrlRequest request);
        partial void ProcessTestConnectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTestConnectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Test connection to Ollama instance<br/>
        /// Validates that the provided Ollama URL is reachable. URL may be provided with or without /v1 suffix (e.g., http://localhost:11434 or http://localhost:11434/v1). The /v1 suffix will be automatically removed for connection testing. For inference, use the URL with /v1 suffix.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OllamaConnectionTestResponse> TestConnectionAsync(

            global::G.OllamaInstanceBaseUrlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTestConnectionArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/ollama/test-connection",
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
            PrepareTestConnectionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTestConnectionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Unprocessable Content - Invalid URL format
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.ErrorMessage? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.ErrorMessage.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.ErrorMessage.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorMessage>(
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
            // Connection test failed - Ollama instance unreachable
            if ((int)__response.StatusCode == 502)
            {
                string? __content_502 = null;
                global::System.Exception? __exception_502 = null;
                global::G.OllamaConnectionTestResponse? __value_502 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_502 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_502 = global::G.OllamaConnectionTestResponse.FromJson(__content_502, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_502 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_502 = global::G.OllamaConnectionTestResponse.FromJson(__content_502, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_502 = __ex;
                }

                throw new global::G.ApiException<global::G.OllamaConnectionTestResponse>(
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
            // Ollama provider is disabled
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::System.Exception? __exception_503 = null;
                global::G.ErrorMessage? __value_503 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_503 = global::G.ErrorMessage.FromJson(__content_503, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_503 = global::G.ErrorMessage.FromJson(__content_503, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_503 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorMessage>(
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
                ProcessTestConnectionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OllamaConnectionTestResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OllamaConnectionTestResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Test connection to Ollama instance<br/>
        /// Validates that the provided Ollama URL is reachable. URL may be provided with or without /v1 suffix (e.g., http://localhost:11434 or http://localhost:11434/v1). The /v1 suffix will be automatically removed for connection testing. For inference, use the URL with /v1 suffix.
        /// </summary>
        /// <param name="baseUrl">
        /// Base URL of the Ollama instance. May include /v1 suffix which will be automatically removed for connection testing. For inference, use the URL with /v1 suffix for OpenAI-compatible endpoints.<br/>
        /// Example: http://localhost:11434/v1
        /// </param>
        /// <param name="apiKey">
        /// Optional API key for authenticated Ollama instances. If provided, will be sent as Bearer token in Authorization header.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OllamaConnectionTestResponse> TestConnectionAsync(
            string baseUrl,
            string? apiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OllamaInstanceBaseUrlRequest
            {
                BaseUrl = baseUrl,
                ApiKey = apiKey,
            };

            return await TestConnectionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}