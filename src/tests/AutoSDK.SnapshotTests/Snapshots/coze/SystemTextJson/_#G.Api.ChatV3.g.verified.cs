//HintName: G.Api.ChatV3.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_ChatV3SecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Token",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ChatV3SecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ChatV3SecurityRequirement0,
            };
        partial void PrepareChatV3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? conversationId,
            global::G.ChatV3Request request);
        partial void PrepareChatV3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? conversationId,
            global::G.ChatV3Request request);
        partial void ProcessChatV3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatV3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 发起对话<br/>
        /// {"0":{"ops":[{"insert":"调用此接口发起一次对话，支持添加上下文和流式响应。 \n"},{"insert":"会话、对话和消息的概念说明，可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73\",\"linkId\":\"jvi5a5cm6O\",\"newTab\":true}"},"insert":"基础概念"},{"insert":"。 \n"},{"attributes":{"anchor":"f568d432","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明 \n"},{"insert":"发起对话接口用于向指定智能体发起一次对话，支持在对话时添加对话的上下文消息，以便智能体基于历史消息做出合理的回复。开发者可以按需选择响应方式，即流式或非流式响应，响应方式决定了开发者获取智能体回复的方式。关于获取智能体回复的详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/get_chat_response\",\"linkId\":\"1GyU2WZlc8\",\"newTab\":true}"},"insert":"通过对话接口获取智能体回复"},{"insert":"。 \n"},{"attributes":{"align":"left","lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"流式响应"},{"insert":"：智能体在生成回复的同时，将回复消息以数据流的形式逐条发送给客户端。处理结束后，服务端会返回一条完整的智能体回复。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3#AJThpr1GJe\",\"linkId\":\"82oNHtGHBO\",\"newTab\":true}"},"insert":"流式响应"},{"insert":"。 \n"},{"attributes":{"align":"left","lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"非流式响应"},{"insert":"：无论对话是否处理完毕，立即发送响应消息。开发者可以通过接口"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/retrieve_chat\",\"linkId\":\"m4izZIFI2H\",\"newTab\":true}"},"insert":"查看对话详情"},{"insert":"确认本次对话处理结束后，再调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_chat_messages\",\"linkId\":\"fwlOApLvFd\",\"newTab\":true}"},"insert":"查看对话消息详情"},{"insert":"接口查看模型回复等完整响应内容。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3#337f3d53\",\"linkId\":\"9ec0qe0dYv\",\"newTab\":true}"},"insert":"非流式响应"},{"insert":"。\n"},{"attributes":{"lmkr":"1","align":"left","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"创建会话"},{"insert":" API 和"},{"attributes":{"bold":"true"},"insert":"发起对话"},{"insert":" API 的区别如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"创建会话：\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"主要用于初始化一个新的会话环境。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"一个会话是Bot和用户之间的一段问答交互，可以包含多条消息。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"创建会话时，可以选择携带初始的消息内容。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"发起对话：\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"用于在已经存在的会话中发起一次对话。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"支持添加上下文和流式响应。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"可以基于历史消息进行上下文关联，提供更符合语境的回复。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ChatV3Response> ChatV3Async(

            global::G.ChatV3Request request,
            string? conversationId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::G.ChatV3Request
            {
                AdditionalMessages = request.AdditionalMessages,
                AutoSaveHistory = request.AutoSaveHistory,
                BotId = request.BotId,
                BotVersion = request.BotVersion,
                CustomVariables = request.CustomVariables,
                EnableCard = request.EnableCard,
                ExtraParams = request.ExtraParams,
                MetaData = request.MetaData,
                Parameters = request.Parameters,
                PublishStatus = request.PublishStatus,
                ShortcutCommand = request.ShortcutCommand,
                Stream = false,
                UserId = request.UserId,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatV3Arguments(
                httpClient: HttpClient,
                conversationId: ref conversationId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatV3SecurityRequirements,
                operationName: "ChatV3Async");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v3/chat",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("conversation_id", conversationId) 
                ; 
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
            PrepareChatV3Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                conversationId: conversationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatV3Response(
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
                ProcessChatV3ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ChatV3Response.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ChatV3Response.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 发起对话<br/>
        /// {"0":{"ops":[{"insert":"调用此接口发起一次对话，支持添加上下文和流式响应。 \n"},{"insert":"会话、对话和消息的概念说明，可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73\",\"linkId\":\"jvi5a5cm6O\",\"newTab\":true}"},"insert":"基础概念"},{"insert":"。 \n"},{"attributes":{"anchor":"f568d432","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明 \n"},{"insert":"发起对话接口用于向指定智能体发起一次对话，支持在对话时添加对话的上下文消息，以便智能体基于历史消息做出合理的回复。开发者可以按需选择响应方式，即流式或非流式响应，响应方式决定了开发者获取智能体回复的方式。关于获取智能体回复的详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/get_chat_response\",\"linkId\":\"1GyU2WZlc8\",\"newTab\":true}"},"insert":"通过对话接口获取智能体回复"},{"insert":"。 \n"},{"attributes":{"align":"left","lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"流式响应"},{"insert":"：智能体在生成回复的同时，将回复消息以数据流的形式逐条发送给客户端。处理结束后，服务端会返回一条完整的智能体回复。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3#AJThpr1GJe\",\"linkId\":\"82oNHtGHBO\",\"newTab\":true}"},"insert":"流式响应"},{"insert":"。 \n"},{"attributes":{"align":"left","lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"非流式响应"},{"insert":"：无论对话是否处理完毕，立即发送响应消息。开发者可以通过接口"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/retrieve_chat\",\"linkId\":\"m4izZIFI2H\",\"newTab\":true}"},"insert":"查看对话详情"},{"insert":"确认本次对话处理结束后，再调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_chat_messages\",\"linkId\":\"fwlOApLvFd\",\"newTab\":true}"},"insert":"查看对话消息详情"},{"insert":"接口查看模型回复等完整响应内容。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3#337f3d53\",\"linkId\":\"9ec0qe0dYv\",\"newTab\":true}"},"insert":"非流式响应"},{"insert":"。\n"},{"attributes":{"lmkr":"1","align":"left","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"创建会话"},{"insert":" API 和"},{"attributes":{"bold":"true"},"insert":"发起对话"},{"insert":" API 的区别如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"创建会话：\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"主要用于初始化一个新的会话环境。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"一个会话是Bot和用户之间的一段问答交互，可以包含多条消息。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"创建会话时，可以选择携带初始的消息内容。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"发起对话：\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"用于在已经存在的会话中发起一次对话。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"支持添加上下文和流式响应。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"可以基于历史消息进行上下文关联，提供更符合语境的回复。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="additionalMessages"></param>
        /// <param name="autoSaveHistory"></param>
        /// <param name="botId"></param>
        /// <param name="botVersion">
        /// 指定 bot 版本；不传取最新版本；publish_status=unpublished_draft 时此参数无效
        /// </param>
        /// <param name="customVariables"></param>
        /// <param name="enableCard"></param>
        /// <param name="extraParams">
        /// 透传参数到 plugin/workflow 等下游
        /// </param>
        /// <param name="metaData"></param>
        /// <param name="parameters">
        /// key=参数名 value=值 传递给 workflows parameters 参数
        /// </param>
        /// <param name="publishStatus">
        /// 发布状态：published_online / unpublished_draft。默认 published_online；不传等同 published_online
        /// </param>
        /// <param name="shortcutCommand"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ChatV3Response> ChatV3Async(
            string botId,
            string userId,
            string? conversationId = default,
            global::System.Collections.Generic.IList<global::G.EnterMessage2>? additionalMessages = default,
            bool? autoSaveHistory = default,
            string? botVersion = default,
            global::System.Collections.Generic.Dictionary<string, string>? customVariables = default,
            bool? enableCard = default,
            global::System.Collections.Generic.Dictionary<string, string>? extraParams = default,
            global::System.Collections.Generic.Dictionary<string, string>? metaData = default,
            object? parameters = default,
            global::G.ChatV3RequestPublishStatus? publishStatus = default,
            global::G.ShortcutCommandDetail? shortcutCommand = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ChatV3Request
            {
                AdditionalMessages = additionalMessages,
                AutoSaveHistory = autoSaveHistory,
                BotId = botId,
                BotVersion = botVersion,
                CustomVariables = customVariables,
                EnableCard = enableCard,
                ExtraParams = extraParams,
                MetaData = metaData,
                Parameters = parameters,
                PublishStatus = publishStatus,
                ShortcutCommand = shortcutCommand,
                Stream = false,
                UserId = userId,
            };

            return await ChatV3Async(
                conversationId: conversationId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}