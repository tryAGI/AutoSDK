//HintName: G.IApi.ListChatMessageApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看对话消息详情<br/>
        /// {"0":{"ops":[{"insert":"查看指定对话中除 Query 以外的其他消息，包括模型回复、智能体执行的中间结果等消息。\n"},{"attributes":{"anchor":"9ac1522a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"bold":"true"},"insert":"查看消息列表"},{"insert":" API 与"},{"attributes":{"bold":"true"},"insert":"查看对话消息详情"},{"insert":" API 的区别在于：\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"查看消息列表"},{"insert":" API 用于查询指定会话（conversation）中的消息记录，不仅包括开发者在会话中手动插入的每一条消息和用户发送的 Query，也包括调用"},{"attributes":{"bold":"true"},"insert":"发起对话"},{"insert":" API 得到的 type=answer 的智能体回复，但不包括 type=function_call、tool_response 和 follow-up 类型的对话中间态消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1","start":"1","origin-start":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"查看对话消息详情"},{"insert":" API 通常用于非流式对话场景中，查看某次对话（chat）中 type=answer 的智能体回复及 type=function_call、tool_response 和 follow-up 类型类型的对话中间态消息。不包括用户发送的 Query。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"PfQgT9cfTe","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"PfQgT9cfTe":{"ops":[{"insert":"调用此 API 之前，建议先以每秒最多 1 次的频率轮询 "},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/retrieve_chat\",\"linkId\":\"Zzo0n2aRpo\",\"newTab\":true}"},"insert":"查看对话详情"},{"insert":" API 确认本轮对话已结束（status=completed），否则调用此 API 时获取到的消息内容可能不完整。\n"}],"zoneId":"PfQgT9cfTe","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="chatId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListChatMessageApiResponse> ListChatMessageApiAsync(
            string conversationId,
            string chatId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}