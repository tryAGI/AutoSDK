//HintName: G.IApi.RetrieveConversationApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看会话消息<br/>
        /// {"0":{"ops":[{"attributes":{"lmkr":"1","align":"left"},"insert":"*"},{"insert":"通过会话 ID 查看会话信息。\n"},{"attributes":{"anchor":"8da2c40b","heading":"h2","lmkr":"1","align":"left"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","align":"left"},"insert":"*"},{"insert":"仅支持查询本人创建的会话。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetrieveConversationApiResponse> RetrieveConversationApiAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}