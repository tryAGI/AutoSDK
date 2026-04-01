//HintName: G.LlmClient.ChatCompletion.g.cs

#nullable enable

namespace G
{
    public partial class LlmClient
    {
        partial void PrepareChatCompletionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::G.CreateChatCompletionRequest request);
        partial void PrepareChatCompletionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            global::G.CreateChatCompletionRequest request);
        partial void ProcessChatCompletionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatCompletionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> ChatCompletionAsync(

            global::G.CreateChatCompletionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::G.CreateChatCompletionRequest
            {
                Model = request.Model,
                Messages = request.Messages,
                Stream = false,
                ResponseFormat = request.ResponseFormat,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatCompletionArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/llms/chat/completions",
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatCompletionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatCompletionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Chat completion request was malformed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.BadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.BadRequestError>(
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
            // Permissions do not allow creating a chat completion.
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
                ProcessChatCompletionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateChatCompletionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateChatCompletionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> ChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Stream = false,
                ResponseFormat = responseFormat,
            };

            return await ChatCompletionAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}