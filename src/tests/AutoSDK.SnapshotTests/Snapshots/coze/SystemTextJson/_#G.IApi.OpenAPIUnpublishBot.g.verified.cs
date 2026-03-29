//HintName: G.IApi.OpenAPIUnpublishBot.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 下架智能体<br/>
        /// {"0":{"ops":[{"insert":"智能体发布后，你可以调用本 API 从扣子官方渠道及自定义渠道下架智能体。\n"},{"attributes":{"anchor":"cf8d7b10","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"仅智能体所有者可以下架智能体。\n"},{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"暂不支持调用本 API 下架豆包渠道的智能体。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIUnpublishBotResponse> OpenAPIUnpublishBotAsync(
            string botId,

            global::G.OpenAPIUnpublishBotRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 下架智能体<br/>
        /// {"0":{"ops":[{"insert":"智能体发布后，你可以调用本 API 从扣子官方渠道及自定义渠道下架智能体。\n"},{"attributes":{"anchor":"cf8d7b10","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口限制\n"},{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"仅智能体所有者可以下架智能体。\n"},{"insert":"*","attributes":{"list":"bullet1","lmkr":"1"}},{"insert":"暂不支持调用本 API 下架豆包渠道的智能体。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="connectorId"></param>
        /// <param name="unpublishReason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIUnpublishBotResponse> OpenAPIUnpublishBotAsync(
            string botId,
            string connectorId,
            string? unpublishReason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}