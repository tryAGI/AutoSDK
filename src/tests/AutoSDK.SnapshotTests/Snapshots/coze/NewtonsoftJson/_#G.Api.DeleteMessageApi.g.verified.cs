//HintName: G.Api.DeleteMessageApi.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareDeleteMessageApiArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string conversationId,
            ref string messageId,
            object request);
        partial void PrepareDeleteMessageApiRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string conversationId,
            string messageId,
            object request);
        partial void ProcessDeleteMessageApiResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteMessageApiResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 删除消息<br/>
        /// {"0":{"ops":[{"insert":"调用接口在指定会话中删除消息。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"v6nQBLqsXK","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"v6nQBLqsXK":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"暂不支持批量操作，需要逐条删除。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"删除指定 message id 对应的消息。如果消息 type=answer，会同步删除与之相关的 verbose、function_call 等中间态消息，但不支持仅删除某一条中间态消息。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"删除消息后，无法通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_message\",\"linkId\":\"8vaZzdw9TA\",\"newTab\":true}"},"insert":"查看消息列表"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_chat_messages\",\"linkId\":\"sSbxfg7Kwi\",\"newTab\":true}"},"insert":"查看对话消息详情"},{"insert":"接口查看已删除的这些消息。\n"}],"zoneId":"v6nQBLqsXK","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeleteMessageApiResponse> DeleteMessageApiAsync(
            string conversationId,
            string messageId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDeleteMessageApiArguments(
                httpClient: HttpClient,
                conversationId: ref conversationId,
                messageId: ref messageId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/conversation/message/delete",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("conversation_id", conversationId)
                .AddRequiredParameter("message_id", messageId) 
                ; 
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
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDeleteMessageApiRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                conversationId: conversationId,
                messageId: messageId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeleteMessageApiResponse(
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
                ProcessDeleteMessageApiResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DeleteMessageApiResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.DeleteMessageApiResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 删除消息<br/>
        /// {"0":{"ops":[{"insert":"调用接口在指定会话中删除消息。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"v6nQBLqsXK","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"v6nQBLqsXK":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"暂不支持批量操作，需要逐条删除。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"删除指定 message id 对应的消息。如果消息 type=answer，会同步删除与之相关的 verbose、function_call 等中间态消息，但不支持仅删除某一条中间态消息。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"删除消息后，无法通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_message\",\"linkId\":\"8vaZzdw9TA\",\"newTab\":true}"},"insert":"查看消息列表"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_chat_messages\",\"linkId\":\"sSbxfg7Kwi\",\"newTab\":true}"},"insert":"查看对话消息详情"},{"insert":"接口查看已删除的这些消息。\n"}],"zoneId":"v6nQBLqsXK","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeleteMessageApiResponse> DeleteMessageApiAsync(
            string conversationId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new object
            {
            };

            return await DeleteMessageApiAsync(
                conversationId: conversationId,
                messageId: messageId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}