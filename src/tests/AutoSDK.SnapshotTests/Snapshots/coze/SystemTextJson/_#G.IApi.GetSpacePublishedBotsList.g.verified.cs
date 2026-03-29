//HintName: G.IApi.GetSpacePublishedBotsList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查看已发布智能体列表（即将下线）<br/>
        /// {"0":{"ops":[{"insert":"查看指定空间发布到 Agent as API 渠道的智能体列表。\n"},{"attributes":{"zoneId":"w0MmatIlz8","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"EeLsXPEEtQ":{"ops":[{"insert":"\n"}],"zoneId":"EeLsXPEEtQ","zoneType":"Z"},"w0MmatIlz8":{"ops":[{"insert":"此接口仅支持查看已发布为 API 服务的智能体列表。对于创建后从未发布到 API 渠道的 Bot，可以在"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/\",\"linkId\":\"YmbZl6YtEr\",\"newTab\":true}"},"insert":"扣子平台"},{"insert":"中查看列表及配置。\n"}],"zoneId":"w0MmatIlz8","zoneType":"Z"}}
        /// </summary>
        /// <param name="spaceId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetSpacePublishedBotsListResponse> GetSpacePublishedBotsListAsync(
            string spaceId,
            int? pageIndex = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}