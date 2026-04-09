//HintName: G.RequestClient.LogRequest.g.cs

#nullable enable

namespace G
{
    public partial class RequestClient
    {
        partial void PrepareLogRequestArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.LogRequest request);
        partial void PrepareLogRequestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.LogRequest request);
        partial void ProcessLogRequestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessLogRequestResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Log Request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LogRequestResponse> LogRequestAsync(

            global::G.LogRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareLogRequestArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/log-request",
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
            PrepareLogRequestRequest(
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
            ProcessLogRequestResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.AnyOf<global::G.BadRequestError, global::G.ValidationError>? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.AnyOf<global::G.BadRequestError, global::G.ValidationError>.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.AnyOf<global::G.BadRequestError, global::G.ValidationError>.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.AnyOf<global::G.BadRequestError, global::G.ValidationError>?>(
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
            // Not Found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.BadRequestError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.BadRequestError.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.BadRequestError.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.BadRequestError>(
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
                ProcessLogRequestResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.LogRequestResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.LogRequestResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Log Request
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="requestStartTime"></param>
        /// <param name="requestEndTime"></param>
        /// <param name="parameters">
        /// Model parameters including temperature, max_tokens, etc. Can also include structured output configuration via response_format.json_schema. See documentation for structured output examples.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="tags">
        /// Default Value: []
        /// </param>
        /// <param name="metadata">
        /// Custom key-value pairs for tracking additional request information. Keys are limited to 1024 characters.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="promptName">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promptId">
        /// The ID of the prompt template used for this request. This is useful for tracking which prompt was used in the request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promptVersionNumber">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promptInputVariables">
        /// Default Value: {}
        /// </param>
        /// <param name="inputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="outputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="price">
        /// Default Value: 0F
        /// </param>
        /// <param name="functionName"></param>
        /// <param name="score">
        /// Default Value: 0
        /// </param>
        /// <param name="apiType">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="status">
        /// Request status.<br/>
        /// | Value | Description |<br/>
        /// |-------|-------------|<br/>
        /// | `SUCCESS` | Request completed successfully (default) |<br/>
        /// | `WARNING` | Request succeeded but had issues (e.g., retries, degraded response) |<br/>
        /// | `ERROR` | Request failed |<br/>
        /// Default Value: SUCCESS
        /// </param>
        /// <param name="errorType">
        /// Categorized error type.<br/>
        /// | Value | Description | Allowed Statuses |<br/>
        /// |-------|-------------|------------------|<br/>
        /// | `PROVIDER_RATE_LIMIT` | Rate limit hit on provider API | WARNING, ERROR |<br/>
        /// | `PROVIDER_QUOTA_LIMIT` | Account quota or spending limit exceeded | WARNING, ERROR |<br/>
        /// | `VARIABLE_MISSING_OR_EMPTY` | Required template variable was missing or empty | WARNING |<br/>
        /// | `PROVIDER_TIMEOUT` | Request timed out | ERROR |<br/>
        /// | `PROVIDER_AUTH_ERROR` | Authentication failed with provider | ERROR |<br/>
        /// | `PROVIDER_ERROR` | General provider-side error | ERROR |<br/>
        /// | `TEMPLATE_RENDER_ERROR` | Failed to render prompt template | ERROR |<br/>
        /// | `UNKNOWN_ERROR` | Uncategorized error | WARNING, ERROR |<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="errorMessage">
        /// Detailed error message describing what went wrong. Maximum 1024 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LogRequestResponse> LogRequestAsync(
            string provider,
            string model,
            global::G.Input input,
            global::G.Output output,
            global::System.DateTime requestStartTime,
            global::System.DateTime requestEndTime,
            object? parameters = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? promptName = default,
            int? promptId = default,
            int? promptVersionNumber = default,
            object? promptInputVariables = default,
            int? inputTokens = default,
            int? outputTokens = default,
            double? price = default,
            string? functionName = default,
            int? score = default,
            string? apiType = default,
            global::G.LogRequestStatus? status = default,
            global::G.LogRequestErrorType2? errorType = default,
            string? errorMessage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.LogRequest
            {
                Provider = provider,
                Model = model,
                Input = input,
                Output = output,
                RequestStartTime = requestStartTime,
                RequestEndTime = requestEndTime,
                Parameters = parameters,
                Tags = tags,
                Metadata = metadata,
                PromptName = promptName,
                PromptId = promptId,
                PromptVersionNumber = promptVersionNumber,
                PromptInputVariables = promptInputVariables,
                InputTokens = inputTokens,
                OutputTokens = outputTokens,
                Price = price,
                FunctionName = functionName,
                Score = score,
                ApiType = apiType,
                Status = status,
                ErrorType = errorType,
                ErrorMessage = errorMessage,
            };

            return await LogRequestAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}