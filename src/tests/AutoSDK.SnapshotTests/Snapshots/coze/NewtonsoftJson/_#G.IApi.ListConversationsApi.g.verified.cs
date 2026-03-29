//HintName: G.IApi.ListConversationsApi.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看会话列表<br/>
        /// {"0":{"ops":[{"insert":"查看指定智能体的会话列表。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"Aktz8YUb9o","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"Aktz8YUb9o":{"ops":[{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"调用此 API 之前，应确认当前使用的访问密钥拥有智能体所在工作空间的权限。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"仅支持通过此 API 查看智能体在 API 或 Chat SDK 渠道产生的会话。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"仅支持查询本人创建的会话。\n"}],"zoneId":"Aktz8YUb9o","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortOrder"></param>
        /// <param name="connectorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListConversationsApiResponse> ListConversationsApiAsync(
            string botId,
            int? pageNum = default,
            int? pageSize = default,
            string? sortOrder = default,
            string? connectorId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}