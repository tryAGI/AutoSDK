//HintName: G.IApi.DeleteMessageApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 删除消息<br/>
        /// {"0":{"ops":[{"insert":"调用接口在指定会话中删除消息。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"v6nQBLqsXK","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"v6nQBLqsXK":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"暂不支持批量操作，需要逐条删除。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"删除指定 message id 对应的消息。如果消息 type=answer，会同步删除与之相关的 verbose、function_call 等中间态消息，但不支持仅删除某一条中间态消息。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"删除消息后，无法通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_message\",\"linkId\":\"8vaZzdw9TA\",\"newTab\":true}"},"insert":"查看消息列表"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_chat_messages\",\"linkId\":\"sSbxfg7Kwi\",\"newTab\":true}"},"insert":"查看对话消息详情"},{"insert":"接口查看已删除的这些消息。\n"}],"zoneId":"v6nQBLqsXK","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteMessageApiResponse> DeleteMessageApiAsync(
            string conversationId,
            string messageId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 删除消息<br/>
        /// {"0":{"ops":[{"insert":"调用接口在指定会话中删除消息。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"v6nQBLqsXK","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"v6nQBLqsXK":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"暂不支持批量操作，需要逐条删除。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"删除指定 message id 对应的消息。如果消息 type=answer，会同步删除与之相关的 verbose、function_call 等中间态消息，但不支持仅删除某一条中间态消息。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"删除消息后，无法通过"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_message\",\"linkId\":\"8vaZzdw9TA\",\"newTab\":true}"},"insert":"查看消息列表"},{"insert":"或"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/docs/developer_guides/list_chat_messages\",\"linkId\":\"sSbxfg7Kwi\",\"newTab\":true}"},"insert":"查看对话消息详情"},{"insert":"接口查看已删除的这些消息。\n"}],"zoneId":"v6nQBLqsXK","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteMessageApiResponse> DeleteMessageApiAsync(
            string conversationId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}