//HintName: G.V2Client.Chat2AsStream.g.cs

#nullable enable

namespace G
{
    public partial class V2Client
    {


        private static readonly global::G.EndPointSecurityRequirement s_Chat2AsStreamSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_Chat2AsStreamSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_Chat2AsStreamSecurityRequirement0,
            };
        partial void PrepareChat2AsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.Chatv2Request request);
        partial void PrepareChat2AsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.Chatv2Request request);
        partial void ProcessChat2AsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Chat V2 API<br/>
        /// Generates a text response to a user message and streams it down, token by token. To learn how to use the Chat API with streaming follow our [Text Generation guides](https://docs.cohere.com/v2/docs/chat-api).<br/>
        /// Follow the [Migration Guide](https://docs.cohere.com/v2/docs/migrating-v1-to-v2) for instructions on moving from API v1 to API v2.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamedChatResponseV2> Chat2AsStreamAsync(

            global::G.Chatv2Request request,
            string? xClientName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::G.Chatv2Request
            {
                Stream = true,
                Model = request.Model,
                Messages = request.Messages,
                ReasoningEffort = request.ReasoningEffort,
                Tools = request.Tools,
                StrictTools = request.StrictTools,
                Documents = request.Documents,
                CitationOptions = request.CitationOptions,
                ResponseFormat = request.ResponseFormat,
                SafetyMode = request.SafetyMode,
                MaxTokens = request.MaxTokens,
                StopSequences = request.StopSequences,
                Temperature = request.Temperature,
                Seed = request.Seed,
                FrequencyPenalty = request.FrequencyPenalty,
                PresencePenalty = request.PresencePenalty,
                K = request.K,
                P = request.P,
                Logprobs = request.Logprobs,
                ToolChoice = request.ToolChoice,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChat2AsStreamArguments(
                httpClient: HttpClient,
                xClientName: ref xClientName,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Chat2AsStreamSecurityRequirements,
                operationName: "Chat2AsStreamAsync");

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
                                path: "/v2/chat",
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

                if (xClientName != default)
                {
                    __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
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
                PrepareChat2AsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xClientName: xClientName,
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
                                operationId: "Chat2AsStream",
                                methodName: "Chat2AsStreamAsync",
                                pathTemplate: "\"/v2/chat\"",
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
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Chat2AsStream",
                                methodName: "Chat2AsStreamAsync",
                                pathTemplate: "\"/v2/chat\"",
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
                                operationId: "Chat2AsStream",
                                methodName: "Chat2AsStreamAsync",
                                pathTemplate: "\"/v2/chat\"",
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
                ProcessChat2AsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Chat2AsStream",
                                methodName: "Chat2AsStreamAsync",
                                pathTemplate: "\"/v2/chat\"",
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
                                operationId: "Chat2AsStream",
                                methodName: "Chat2AsStreamAsync",
                                pathTemplate: "\"/v2/chat\"",
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

                                var __streamedResponse = global::G.StreamedChatResponseV2.FromJson(__content, JsonSerializerOptions) ??
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
        /// Chat V2 API<br/>
        /// Generates a text response to a user message and streams it down, token by token. To learn how to use the Chat API with streaming follow our [Text Generation guides](https://docs.cohere.com/v2/docs/chat-api).<br/>
        /// Follow the [Migration Guide](https://docs.cohere.com/v2/docs/migrating-v1-to-v2) for instructions on moving from API v1 to API v2.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// The name of a compatible [Cohere model](https://docs.cohere.com/v2/docs/models) or the ID of a [fine-tuned](https://docs.cohere.com/v2/docs/chat-fine-tuning) model.
        /// </param>
        /// <param name="messages">
        /// A list of chat messages in chronological order, representing a conversation between the user and the model.<br/>
        /// Messages can be from `User`, `Assistant`, `Tool` and `System` roles. Learn more about messages and roles in [the Chat API guide](https://docs.cohere.com/v2/docs/chat-api).
        /// </param>
        /// <param name="reasoningEffort">
        /// The reasoning effort level of the model. This affects the model's performance and the time it takes to generate a response.
        /// </param>
        /// <param name="tools">
        /// A list of tools (functions) available to the model. The model response may contain 'tool_calls' to the specified tools.<br/>
        /// Learn more in the [Tool Use guide](https://docs.cohere.com/docs/tools).
        /// </param>
        /// <param name="strictTools">
        /// When set to `true`, tool calls in the Assistant message will be forced to follow the tool definition strictly. Learn more in the [Structured Outputs (Tools) guide](https://docs.cohere.com/docs/structured-outputs-json#structured-outputs-tools).<br/>
        /// **Note**: The first few requests with a new set of tools will take longer to process.
        /// </param>
        /// <param name="documents">
        /// A list of relevant documents that the model can cite to generate a more accurate reply. Each document is either a string or document object with content and metadata.
        /// </param>
        /// <param name="citationOptions">
        /// Options for controlling citation generation.
        /// </param>
        /// <param name="responseFormat">
        /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/v2/docs/command-r), [Command R+](https://docs.cohere.com/v2/docs/command-r-plus) and newer models.<br/>
        /// The model can be forced into outputting JSON objects by setting `{ "type": "json_object" }`.<br/>
        /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
        /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
        /// **Note**: When `json_schema` is not specified, the generated object can have up to 5 layers of nesting.<br/>
        /// **Limitation**: The parameter is not supported when used in combinations with the `documents` or `tools` parameters.
        /// </param>
        /// <param name="safetyMode">
        /// Used to select the [safety instruction](https://docs.cohere.com/v2/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
        /// When `OFF` is specified, the safety instruction will be omitted.<br/>
        /// Safety modes are not yet configurable in combination with `tools` and `documents` parameters.<br/>
        /// **Note**: This parameter is only compatible newer Cohere models, starting with [Command R 08-2024](https://docs.cohere.com/docs/command-r#august-2024-release) and [Command R+ 08-2024](https://docs.cohere.com/docs/command-r-plus#august-2024-release).<br/>
        /// **Note**: `command-r7b-12-2024` and newer models only support `"CONTEXTUAL"` and `"STRICT"` modes.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens the model will generate as part of the response.<br/>
        /// **Note**: Setting a low value may result in incomplete generations.
        /// </param>
        /// <param name="stopSequences">
        /// A list of up to 5 strings that the model will use to stop generation. If the model generates a string that matches any of the strings in the list, it will stop generating tokens and return the generated text up to that point not including the stop sequence.
        /// </param>
        /// <param name="temperature">
        /// Defaults to `0.3`.<br/>
        /// A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations, and higher temperatures mean more random generations.<br/>
        /// Randomness can be further maximized by increasing the  value of the `p` parameter.
        /// </param>
        /// <param name="seed">
        /// If specified, the backend will make a best effort to sample tokens<br/>
        /// deterministically, such that repeated requests with the same<br/>
        /// seed and parameters should return the same result. However,<br/>
        /// determinism cannot be totally guaranteed.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.
        /// </param>
        /// <param name="presencePenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.
        /// </param>
        /// <param name="k">
        /// Ensures that only the top `k` most likely tokens are considered for generation at each step. When `k` is set to `0`, k-sampling is disabled.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="p">
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.<br/>
        /// Default Value: 0.75
        /// </param>
        /// <param name="logprobs">
        /// Defaults to `false`. When set to `true`, the log probabilities of the generated tokens will be included in the response.
        /// </param>
        /// <param name="toolChoice">
        /// Used to control whether or not the model will be forced to use a tool when answering. When `REQUIRED` is specified, the model will be forced to use at least one of the user-defined tools, and the `tools` parameter must be passed in the request.<br/>
        /// When `NONE` is specified, the model will be forced **not** to use one of the specified tools, and give a direct response.<br/>
        /// If tool_choice isn't specified, then the model is free to choose whether to use the specified tools or not.<br/>
        /// **Note**: This parameter is only compatible with models [Command-r7b](https://docs.cohere.com/v2/docs/command-r7b) and newer.<br/>
        /// **Note**: The same functionality can be achieved in `/v1/chat` using the `force_single_step` parameter. If `force_single_step=true`, this is equivalent to specifying `REQUIRED`. While if `force_single_step=true` and `tool_results` are passed, this is equivalent to specifying `NONE`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamedChatResponseV2> Chat2AsStreamAsync(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatMessageV2> messages,
            string? xClientName = default,
            global::G.ReasoningEffort? reasoningEffort = default,
            global::System.Collections.Generic.IList<global::G.ToolV2>? tools = default,
            bool? strictTools = default,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.Document>>? documents = default,
            global::G.CitationOptions? citationOptions = default,
            global::G.ResponseFormatV2? responseFormat = default,
            global::G.Chatv2RequestSafetyMode? safetyMode = default,
            int? maxTokens = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            float? temperature = default,
            int? seed = default,
            float? frequencyPenalty = default,
            float? presencePenalty = default,
            int? k = default,
            float? p = default,
            bool? logprobs = default,
            global::G.Chatv2RequestToolChoice? toolChoice = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Chatv2Request
            {
                Stream = true,
                Model = model,
                Messages = messages,
                ReasoningEffort = reasoningEffort,
                Tools = tools,
                StrictTools = strictTools,
                Documents = documents,
                CitationOptions = citationOptions,
                ResponseFormat = responseFormat,
                SafetyMode = safetyMode,
                MaxTokens = maxTokens,
                StopSequences = stopSequences,
                Temperature = temperature,
                Seed = seed,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                K = k,
                P = p,
                Logprobs = logprobs,
                ToolChoice = toolChoice,
            };

            var __enumerable = Chat2AsStreamAsync(
                xClientName: xClientName,
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