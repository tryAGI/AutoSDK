//HintName: G.IApi.CancelChatApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 取消进行中的对话<br/>
        /// {"0":{"ops":[{"insert":"调用此接口取消进行中的对话。\n"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3\",\"linkId\":\"Ozh0uO9L9t\",\"newTab\":true}"},"insert":"发起对话"},{"insert":"接口时，如果对话触发了复杂的工作流、图像流，或模型处理数据量大时，对话可能耗时较久。对话进行中时，用户无法在此会话中发起新的对话。此时可以调用此接口取消正在进行中的对话，取消后，对话转为已取消状态（status=canceled），你可以在会话中创建新的对话。\n"},{"attributes":{"anchor":"b692ec97","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"注意事项\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"调用取消对话 API 仅切换对话状态，不会中断 chat API 的流式回复，同时根据完整回复内容来计算消耗的模型 Token。如需中断流式回复、停止打印机效果，可以在调用此 API 之后主动中断客户端连接，例如调用浏览器 Web API "},{"attributes":{"inlineCode":"true"},"insert":"AbortController"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"取消对话后，本轮用户的 Query 和智能体的回复不会记录为对话的上下文。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"不支持取消以下状态的对话。你可以通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/retrieve_chat\",\"linkId\":\"hXgz4ZLQsf\",\"newTab\":true}"},"insert":"查看对话详情"},{"insert":"接口的 status 字段查看对话状态。\n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"completed：会话结束。 \n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"failed：会话失败。 \n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"requires_action：会话中断。\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"对话过程中的状态流转：\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"image":"true","width":"430","height":"216","scale":"0.5023255813953489","src":"https://p9-arcosite.byteimg.com/obj/tos-cn-i-goo7wpa0wc/d7c3509b18454159ab3cfb89e7e7b222","uuid":"dOrIGLj7","tmpId":"aHxdF1it3"},"insert":" "},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CancelChatApiResponse> CancelChatApiAsync(

            global::G.CancelChatApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 取消进行中的对话<br/>
        /// {"0":{"ops":[{"insert":"调用此接口取消进行中的对话。\n"},{"insert":"调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/chat_v3\",\"linkId\":\"Ozh0uO9L9t\",\"newTab\":true}"},"insert":"发起对话"},{"insert":"接口时，如果对话触发了复杂的工作流、图像流，或模型处理数据量大时，对话可能耗时较久。对话进行中时，用户无法在此会话中发起新的对话。此时可以调用此接口取消正在进行中的对话，取消后，对话转为已取消状态（status=canceled），你可以在会话中创建新的对话。\n"},{"attributes":{"anchor":"b692ec97","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"注意事项\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"调用取消对话 API 仅切换对话状态，不会中断 chat API 的流式回复，同时根据完整回复内容来计算消耗的模型 Token。如需中断流式回复、停止打印机效果，可以在调用此 API 之后主动中断客户端连接，例如调用浏览器 Web API "},{"attributes":{"inlineCode":"true"},"insert":"AbortController"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"取消对话后，本轮用户的 Query 和智能体的回复不会记录为对话的上下文。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"不支持取消以下状态的对话。你可以通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/retrieve_chat\",\"linkId\":\"hXgz4ZLQsf\",\"newTab\":true}"},"insert":"查看对话详情"},{"insert":"接口的 status 字段查看对话状态。\n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"completed：会话结束。 \n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"failed：会话失败。 \n"},{"attributes":{"lmkr":"1","list":"bullet2","start":"1","origin-start":"1"},"insert":"*"},{"insert":"requires_action：会话中断。\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1"},"insert":"*"},{"insert":"对话过程中的状态流转：\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"image":"true","width":"430","height":"216","scale":"0.5023255813953489","src":"https://p9-arcosite.byteimg.com/obj/tos-cn-i-goo7wpa0wc/d7c3509b18454159ab3cfb89e7e7b222","uuid":"dOrIGLj7","tmpId":"aHxdF1it3"},"insert":" "},{"insert":"\n"},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CancelChatApiResponse> CancelChatApiAsync(
            string chatId,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}