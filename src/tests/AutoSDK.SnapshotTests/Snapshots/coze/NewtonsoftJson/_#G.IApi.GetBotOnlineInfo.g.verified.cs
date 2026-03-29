//HintName: G.IApi.GetBotOnlineInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 获取已发布智能体配置（即将下线）<br/>
        /// {"0":{"ops":[{"insert":"获取指定智能体的配置信息，此智能体必须已发布到 Agent as API 渠道中。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口仅支持查看已发布为 API 服务的智能体。对于创建后从未发布到 API 渠道的智能体，可以在"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/\",\"linkId\":\"ydU42Zi43J\",\"newTab\":true}"},"insert":"扣子平台"},{"insert":"中查看列表及配置。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetBotOnlineInfoResponse> GetBotOnlineInfoAsync(
            string botId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}