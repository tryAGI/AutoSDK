//HintName: G.LlmClient.ChatCompletionAsStream.g.cs

#nullable enable

namespace G
{
    public partial class LlmClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ChatCompletionAsStreamSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_ChatCompletionAsStreamSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "OAuth2",
                        Location = "Header",
                        Name = "",
                        FriendlyName = "OAuth2",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ChatCompletionAsStreamSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ChatCompletionAsStreamSecurityRequirement0,
                s_ChatCompletionAsStreamSecurityRequirement1,
            };
        partial void PrepareChatCompletionAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::G.CreateChatCompletionRequest request);
        partial void PrepareChatCompletionAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            global::G.CreateChatCompletionRequest request);
        partial void ProcessChatCompletionAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Creates a model response for the given chat conversation<br/>
        /// The Chat Completions API provides an OpenAI-compatible interface for generating model responses in multi-turn chat conversations. This API enables you to integrate our language models directly into applications designed to work with the OpenAI Chat Completions format, making it easy to leverage Vectara capabilities with minimal changes to existing tools or code.<br/>
        /// Use this API to enable interactive chat experiences that support context-aware responses, streaming output, and token usage tracking.<br/>
        /// The request includes a series of chat messages and optional parameters that control the behavior and structure of the model response. The request body must include the `messages` parameter, an array of message objects (role, content) representing the full conversation so far.<br/>
        /// ### Streaming responses<br/>
        /// If the `stream` parameter is set to `true`, the response appears as a series of text/event-stream parts (also known as chunks). Each chunk includes a `delta` field showing the incremental message update.<br/>
        /// ### Example request<br/>
        /// This example sends a simple chat conversation to the API, asking the assistant for the capital of France. The request includes a system prompt, a user message, and a temperature setting for response variability.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "model": "chat-model-001","messages": [{ "role": "system", "content": "You are a helpful assistant." },<br/>
        ///   { "role": "user", "content": "What is the capital of France?" }<br/>
        /// ],<br/>
        /// "temperature": 0.7,<br/>
        /// "stream": false<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes a generated reply from the assistant, along with token usage statistics. In this example, the model returns a direct answer to a user question.<br/>
        /// ```json<br/>
        /// {<br/>
        /// "id": "chatcmpl-abc123",}<br/>
        /// "object": "chat.completion",<br/>
        /// "created": 1712454830,<br/>
        /// "model": "chat-model-001",<br/>
        /// "choices": [<br/>
        ///   {<br/>
        ///     "index": 0,<br/>
        ///     "message": {<br/>
        ///       "role": "assistant",<br/>
        ///       "content": "The capital of France is Paris."<br/>
        ///   },<br/>
        ///     "finish_reason": "stop"<br/>
        ///   }<br/>
        /// ],<br/>
        /// "usage": {<br/>
        ///   "prompt_tokens": 21,<br/>
        ///   "completion_tokens": 9,<br/>
        ///   "total_tokens": 30<br/>
        ///   } <br/>
        /// } <br/>
        /// ```<br/>
        /// If the input summary is accurate, the `corrected_summary` matches the `original_summary`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.CreateChatCompletionStreamResponse> ChatCompletionAsStreamAsync(

            global::G.CreateChatCompletionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::G.CreateChatCompletionRequest
            {
                Model = request.Model,
                Messages = request.Messages,
                Stream = true,
                ResponseFormat = request.ResponseFormat,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatCompletionAsStreamArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatCompletionAsStreamSecurityRequirements,
                operationName: "ChatCompletionAsStreamAsync");

            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::G.PathBuilder(
                                path: "/v2/llms/chat/completions",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                foreach (var __authorization in __authorizations)
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

                if (requestTimeout != default)
                {
                    __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
                }
                if (requestTimeoutMillis != default)
                {
                    __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
                }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareChatCompletionAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    requestTimeout: requestTimeout,
                    requestTimeoutMillis: requestTimeoutMillis,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionAsStream",
                                methodName: "ChatCompletionAsStreamAsync",
                                pathTemplate: "\"/v2/llms/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await global::G.Api.AutoSDKOAuth2Helpers.SendAsync(
                httpClient: HttpClient,
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                authorizations: __authorizations,
                oAuth2Coordinator: AutoSDKOAuth2State,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionAsStream",
                                methodName: "ChatCompletionAsStreamAsync",
                                pathTemplate: "\"/v2/llms/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionAsStream",
                                methodName: "ChatCompletionAsStreamAsync",
                                pathTemplate: "\"/v2/llms/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessChatCompletionAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionAsStream",
                                methodName: "ChatCompletionAsStreamAsync",
                                pathTemplate: "\"/v2/llms/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatCompletionAsStream",
                                methodName: "ChatCompletionAsStreamAsync",
                                pathTemplate: "\"/v2/llms/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::G.CreateChatCompletionStreamResponse.FromJson(__content, JsonSerializerOptions) ??
                                                       throw new global::G.ApiException(
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           statusCode: __response.StatusCode)
                                                       {
                                                           ResponseBody = __content,
                                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value),
                                                       };

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Creates a model response for the given chat conversation<br/>
        /// The Chat Completions API provides an OpenAI-compatible interface for generating model responses in multi-turn chat conversations. This API enables you to integrate our language models directly into applications designed to work with the OpenAI Chat Completions format, making it easy to leverage Vectara capabilities with minimal changes to existing tools or code.<br/>
        /// Use this API to enable interactive chat experiences that support context-aware responses, streaming output, and token usage tracking.<br/>
        /// The request includes a series of chat messages and optional parameters that control the behavior and structure of the model response. The request body must include the `messages` parameter, an array of message objects (role, content) representing the full conversation so far.<br/>
        /// ### Streaming responses<br/>
        /// If the `stream` parameter is set to `true`, the response appears as a series of text/event-stream parts (also known as chunks). Each chunk includes a `delta` field showing the incremental message update.<br/>
        /// ### Example request<br/>
        /// This example sends a simple chat conversation to the API, asking the assistant for the capital of France. The request includes a system prompt, a user message, and a temperature setting for response variability.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "model": "chat-model-001","messages": [{ "role": "system", "content": "You are a helpful assistant." },<br/>
        ///   { "role": "user", "content": "What is the capital of France?" }<br/>
        /// ],<br/>
        /// "temperature": 0.7,<br/>
        /// "stream": false<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes a generated reply from the assistant, along with token usage statistics. In this example, the model returns a direct answer to a user question.<br/>
        /// ```json<br/>
        /// {<br/>
        /// "id": "chatcmpl-abc123",}<br/>
        /// "object": "chat.completion",<br/>
        /// "created": 1712454830,<br/>
        /// "model": "chat-model-001",<br/>
        /// "choices": [<br/>
        ///   {<br/>
        ///     "index": 0,<br/>
        ///     "message": {<br/>
        ///       "role": "assistant",<br/>
        ///       "content": "The capital of France is Paris."<br/>
        ///   },<br/>
        ///     "finish_reason": "stop"<br/>
        ///   }<br/>
        /// ],<br/>
        /// "usage": {<br/>
        ///   "prompt_tokens": 21,<br/>
        ///   "completion_tokens": 9,<br/>
        ///   "total_tokens": 30<br/>
        ///   } <br/>
        /// } <br/>
        /// ```<br/>
        /// If the input summary is accurate, the `corrected_summary` matches the `original_summary`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="model">
        /// The ID of the model to use. This field is required.
        /// </param>
        /// <param name="messages">
        /// An ordered array of messages that represent the full context of the conversation to date. Each message includes a `role` and `content`.
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format the model must output.<br/>
        /// - `text`: Plain text responses (default).<br/>
        /// - `json_object`: Ensures the response is valid JSON.<br/>
        /// - `json_schema`: Ensures the response conforms to the provided JSON schema.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.CreateChatCompletionStreamResponse> ChatCompletionAsStreamAsync(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.ResponseFormat? responseFormat = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Stream = true,
                ResponseFormat = responseFormat,
            };

            var __enumerable = ChatCompletionAsStreamAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}