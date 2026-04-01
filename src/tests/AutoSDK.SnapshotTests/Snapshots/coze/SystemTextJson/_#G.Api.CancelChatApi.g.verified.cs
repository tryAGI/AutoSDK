//HintName: G.Api.CancelChatApi.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCancelChatApiArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CancelChatApiRequest request);
        partial void PrepareCancelChatApiRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CancelChatApiRequest request);
        partial void ProcessCancelChatApiResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCancelChatApiResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 取消进行中的对话<br/>
        /// {"0":{"ops":[{"insert":"调用此接口取消进行中的对话。\n"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3\",\"linkId\":\"Ozh0uO9L9t\",\"newTab\":true}"},"insert":"发起对话"},{"insert":"接口时，如果对话触发了复杂的工作流、图像流，或模型处理数据量大时，对话可能耗时较久。对话进行中时，用户无法在此会话中发起新的对话。此时可以调用此接口取消正在进行中的对话，取消后，对话转为已取消状态（status=canceled），你可以在会话中创建新的对话。\n"},{"attributes":{"anchor":"b692ec97","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"注意事项\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"调用取消对话 API 仅切换对话状态，不会中断 chat API 的流式回复，同时根据完整回复内容来计算消耗的模型 Token。如需中断流式回复、停止打印机效果，可以在调用此 API 之后主动中断客户端连接，例如调用浏览器 Web API "},{"attributes":{"inlineCode":"true"},"insert":"AbortController"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"取消对话后，本轮用户的 Query 和智能体的回复不会记录为对话的上下文。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"不支持取消以下状态的对话。你可以通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/retrieve_chat\",\"linkId\":\"hXgz4ZLQsf\",\"newTab\":true}"},"insert":"查看对话详情"},{"insert":"接口的 status 字段查看对话状态。\n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"completed：会话结束。 \n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"failed：会话失败。 \n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"requires_action：会话中断。\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"对话过程中的状态流转：\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"image":"true","width":"430","height":"216","scale":"0.5023255813953489","src":"https://p9-arcosite.byteimg.com/obj/tos-cn-i-goo7wpa0wc/d7c3509b18454159ab3cfb89e7e7b222","uuid":"dOrIGLj7","tmpId":"aHxdF1it3"},"insert":" "},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CancelChatApiResponse> CancelChatApiAsync(

            global::G.CancelChatApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCancelChatApiArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v3/chat/cancel",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCancelChatApiRequest(
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
            ProcessCancelChatApiResponse(
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
                ProcessCancelChatApiResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CancelChatApiResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CancelChatApiResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 取消进行中的对话<br/>
        /// {"0":{"ops":[{"insert":"调用此接口取消进行中的对话。\n"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3\",\"linkId\":\"Ozh0uO9L9t\",\"newTab\":true}"},"insert":"发起对话"},{"insert":"接口时，如果对话触发了复杂的工作流、图像流，或模型处理数据量大时，对话可能耗时较久。对话进行中时，用户无法在此会话中发起新的对话。此时可以调用此接口取消正在进行中的对话，取消后，对话转为已取消状态（status=canceled），你可以在会话中创建新的对话。\n"},{"attributes":{"anchor":"b692ec97","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"注意事项\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"调用取消对话 API 仅切换对话状态，不会中断 chat API 的流式回复，同时根据完整回复内容来计算消耗的模型 Token。如需中断流式回复、停止打印机效果，可以在调用此 API 之后主动中断客户端连接，例如调用浏览器 Web API "},{"attributes":{"inlineCode":"true"},"insert":"AbortController"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"取消对话后，本轮用户的 Query 和智能体的回复不会记录为对话的上下文。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"不支持取消以下状态的对话。你可以通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/retrieve_chat\",\"linkId\":\"hXgz4ZLQsf\",\"newTab\":true}"},"insert":"查看对话详情"},{"insert":"接口的 status 字段查看对话状态。\n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"completed：会话结束。 \n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"failed：会话失败。 \n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"requires_action：会话中断。\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"对话过程中的状态流转：\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"image":"true","width":"430","height":"216","scale":"0.5023255813953489","src":"https://p9-arcosite.byteimg.com/obj/tos-cn-i-goo7wpa0wc/d7c3509b18454159ab3cfb89e7e7b222","uuid":"dOrIGLj7","tmpId":"aHxdF1it3"},"insert":" "},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CancelChatApiResponse> CancelChatApiAsync(
            string chatId,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CancelChatApiRequest
            {
                ChatId = chatId,
                ConversationId = conversationId,
            };

            return await CancelChatApiAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}