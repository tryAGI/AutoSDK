//HintName: G.IApi.ChatV3AsStream.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 发起对话<br/>
        /// {"0":{"ops":[{"insert":"调用此接口发起一次对话，支持添加上下文和流式响应。 \n"},{"insert":"会话、对话和消息的概念说明，可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/coze_api_overview#4a288f73\",\"linkId\":\"jvi5a5cm6O\",\"newTab\":true}"},"insert":"基础概念"},{"insert":"。 \n"},{"attributes":{"anchor":"f568d432","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明 \n"},{"insert":"发起对话接口用于向指定智能体发起一次对话，支持在对话时添加对话的上下文消息，以便智能体基于历史消息做出合理的回复。开发者可以按需选择响应方式，即流式或非流式响应，响应方式决定了开发者获取智能体回复的方式。关于获取智能体回复的详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/get_chat_response\",\"linkId\":\"1GyU2WZlc8\",\"newTab\":true}"},"insert":"通过对话接口获取智能体回复"},{"insert":"。 \n"},{"attributes":{"align":"left","lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"流式响应"},{"insert":"：智能体在生成回复的同时，将回复消息以数据流的形式逐条发送给客户端。处理结束后，服务端会返回一条完整的智能体回复。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3#AJThpr1GJe\",\"linkId\":\"82oNHtGHBO\",\"newTab\":true}"},"insert":"流式响应"},{"insert":"。 \n"},{"attributes":{"align":"left","lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"非流式响应"},{"insert":"：无论对话是否处理完毕，立即发送响应消息。开发者可以通过接口"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/retrieve_chat\",\"linkId\":\"m4izZIFI2H\",\"newTab\":true}"},"insert":"查看对话详情"},{"insert":"确认本次对话处理结束后，再调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_chat_messages\",\"linkId\":\"fwlOApLvFd\",\"newTab\":true}"},"insert":"查看对话消息详情"},{"insert":"接口查看模型回复等完整响应内容。详细说明可参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3#337f3d53\",\"linkId\":\"9ec0qe0dYv\",\"newTab\":true}"},"insert":"非流式响应"},{"insert":"。\n"},{"attributes":{"lmkr":"1","align":"left","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"创建会话"},{"insert":" API 和"},{"attributes":{"bold":"true"},"insert":"发起对话"},{"insert":" API 的区别如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"创建会话：\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"主要用于初始化一个新的会话环境。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"一个会话是Bot和用户之间的一段问答交互，可以包含多条消息。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"创建会话时，可以选择携带初始的消息内容。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"发起对话：\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"用于在已经存在的会话中发起一次对话。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"支持添加上下文和流式响应。\n"},{"attributes":{"list":"bullet2","lmkr":"1"},"insert":"*"},{"insert":"可以基于历史消息进行上下文关联，提供更符合语境的回复。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.ChatV3Response2> ChatV3AsStreamAsync(

            global::G.ChatV3Request request,
            string? conversationId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.ChatV3Response2> ChatV3AsStreamAsync(
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
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}