//HintName: G.Api.SubmitToolOutputsAsStream.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_SubmitToolOutputsAsStreamSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_SubmitToolOutputsAsStreamSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_SubmitToolOutputsAsStreamSecurityRequirement0,
            };
        partial void PrepareSubmitToolOutputsAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string conversationId,
            ref string chatId,
            global::G.SubmitToolOutputsRequest request);
        partial void PrepareSubmitToolOutputsAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string conversationId,
            string chatId,
            global::G.SubmitToolOutputsRequest request);
        partial void ProcessSubmitToolOutputsAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// 提交工具执行结果<br/>
        /// {"0":{"ops":[{"insert":"调用此接口提交工具执行的结果。\n"},{"attributes":{"heading":"h2","anchor":"422f2e9b","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以将需要客户端执行的操作定义为插件，对话中如果触发这个插件，流式 event 响应信息会提示“conversation.chat.requires_action”，此时需要执行客户端的操作后，通过此接口提交插件执行后的结果。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"v2D2o9fWV1","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"v2D2o9fWV1":{"ops":[{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/chat_v3\",\"linkId\":\"W80ifqcYZs\",\"newTab\":true}"},"insert":"发起对话"},{"insert":" API 时，"},{"attributes":{"inlineCode":"true"},"insert":"auto_save_history"},{"insert":" 参数需要设置为 "},{"attributes":{"inlineCode":"true"},"insert":"true"},{"insert":"，否则调用本 API 提交工具执行结果时会提示 5000 错误。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"仅触发了端插件的对话需要调用此接口提交执行结果。端插件是非扣子服务端执行的插件，需要开发者自行执行任务后提交结果，通常用于 IoT 等设备控制场景。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/guides/use_local_plugin\",\"linkId\":\"BZmIXIYmwW\",\"newTab\":true}"},"insert":"通过 API 使用端插件"},{"insert":"。\n"}],"zoneId":"v2D2o9fWV1","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.SubmitToolOutputsResponse2> SubmitToolOutputsAsStreamAsync(
            string conversationId,
            string chatId,

            global::G.SubmitToolOutputsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::G.SubmitToolOutputsRequest
            {
                Stream = true,
                ToolOutputs = request.ToolOutputs,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareSubmitToolOutputsAsStreamArguments(
                httpClient: HttpClient,
                conversationId: ref conversationId,
                chatId: ref chatId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SubmitToolOutputsAsStreamSecurityRequirements,
                operationName: "SubmitToolOutputsAsStreamAsync");

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
                                path: "/v3/chat/submit_tool_outputs",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddRequiredParameter("conversation_id", conversationId)
                                .AddRequiredParameter("chat_id", chatId) 
                                ;
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
                PrepareSubmitToolOutputsAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    conversationId: conversationId,
                    chatId: chatId,
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
                                operationId: "SubmitToolOutputsAsStream",
                                methodName: "SubmitToolOutputsAsStreamAsync",
                                pathTemplate: "\"/v3/chat/submit_tool_outputs\"",
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
                                operationId: "SubmitToolOutputsAsStream",
                                methodName: "SubmitToolOutputsAsStreamAsync",
                                pathTemplate: "\"/v3/chat/submit_tool_outputs\"",
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
                                operationId: "SubmitToolOutputsAsStream",
                                methodName: "SubmitToolOutputsAsStreamAsync",
                                pathTemplate: "\"/v3/chat/submit_tool_outputs\"",
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
                ProcessSubmitToolOutputsAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SubmitToolOutputsAsStream",
                                methodName: "SubmitToolOutputsAsStreamAsync",
                                pathTemplate: "\"/v3/chat/submit_tool_outputs\"",
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
                                operationId: "SubmitToolOutputsAsStream",
                                methodName: "SubmitToolOutputsAsStreamAsync",
                                pathTemplate: "\"/v3/chat/submit_tool_outputs\"",
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

                                var __streamedResponse = global::G.SubmitToolOutputsResponse2.FromJson(__content, JsonSerializerOptions) ??
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
        /// 提交工具执行结果<br/>
        /// {"0":{"ops":[{"insert":"调用此接口提交工具执行的结果。\n"},{"attributes":{"heading":"h2","anchor":"422f2e9b","lmkr":"1"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以将需要客户端执行的操作定义为插件，对话中如果触发这个插件，流式 event 响应信息会提示“conversation.chat.requires_action”，此时需要执行客户端的操作后，通过此接口提交插件执行后的结果。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"v2D2o9fWV1","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"v2D2o9fWV1":{"ops":[{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/chat_v3\",\"linkId\":\"W80ifqcYZs\",\"newTab\":true}"},"insert":"发起对话"},{"insert":" API 时，"},{"attributes":{"inlineCode":"true"},"insert":"auto_save_history"},{"insert":" 参数需要设置为 "},{"attributes":{"inlineCode":"true"},"insert":"true"},{"insert":"，否则调用本 API 提交工具执行结果时会提示 5000 错误。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"仅触发了端插件的对话需要调用此接口提交执行结果。端插件是非扣子服务端执行的插件，需要开发者自行执行任务后提交结果，通常用于 IoT 等设备控制场景。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/guides/use_local_plugin\",\"linkId\":\"BZmIXIYmwW\",\"newTab\":true}"},"insert":"通过 API 使用端插件"},{"insert":"。\n"}],"zoneId":"v2D2o9fWV1","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="chatId"></param>
        /// <param name="toolOutputs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.SubmitToolOutputsResponse2> SubmitToolOutputsAsStreamAsync(
            string conversationId,
            string chatId,
            global::System.Collections.Generic.IList<global::G.ToolOutput> toolOutputs,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SubmitToolOutputsRequest
            {
                Stream = true,
                ToolOutputs = toolOutputs,
            };

            var __enumerable = SubmitToolOutputsAsStreamAsync(
                conversationId: conversationId,
                chatId: chatId,
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