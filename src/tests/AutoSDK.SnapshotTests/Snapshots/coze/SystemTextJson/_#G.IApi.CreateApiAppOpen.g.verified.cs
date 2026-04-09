//HintName: G.IApi.CreateApiAppOpen.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 创建回调应用<br/>
        /// {"0":{"ops":[{"insert":"本 API 用于创建回调应用，支持创建普通回调应用和渠道回调应用。订阅扣子编程回调功能时需要创建回调应用。\n"},{"attributes":{"anchor":"c9eedd03","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/add_callback\",\"linkId\":\"UX5fAx4fb2\",\"newTab\":true}"},"insert":"订阅回调"},{"insert":"功能支持开发者通过配置回调应用实时获取扣子编程的事件通知。当"},{"attributes":{"bold":"true"},"insert":"智能体发布"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"智能体删除"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"账单生成"},{"insert":"等关键业务事件被触发时，扣子编程将向开发者指定的服务器地址发送回调消息。\n"},{"attributes":{"lmkr":"1","text-indent":"true"},"insert":"*"},{"insert":"回调分为普通回调和渠道回调，具体说明如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"普通回调应用：开发者在扣子编程中创建回调应用，用于接收扣子编程触发的事件通知。当订阅的事件被触发时，扣子编程会向该回调地址推送回调消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"渠道回调应用：当渠道入驻扣子编程后，开发者可以在该渠道中创建回调应用，用于接收该渠道中触发的事件通知。当订阅的事件被触发时，扣子编程会向渠道指定的回调地址推送回调消息。\n"},{"attributes":{"anchor":"9d5a797a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子个人版中，任何用户均可以创建普通回调应用。仅渠道创建者支持创建对应渠道的回调应用，统一接收该渠道中的回调消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"扣子企业版（企业标准版、企业旗舰版）中，仅超级管理员和管理员可创建回调应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateApiAppOpenResponse> CreateApiAppOpenAsync(

            global::G.CreateApiAppOpenRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 创建回调应用<br/>
        /// {"0":{"ops":[{"insert":"本 API 用于创建回调应用，支持创建普通回调应用和渠道回调应用。订阅扣子编程回调功能时需要创建回调应用。\n"},{"attributes":{"anchor":"c9eedd03","lmkr":"1","heading":"h2"},"insert":"*"},{"insert":"接口说明\n"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/dev_how_to_guides/add_callback\",\"linkId\":\"UX5fAx4fb2\",\"newTab\":true}"},"insert":"订阅回调"},{"insert":"功能支持开发者通过配置回调应用实时获取扣子编程的事件通知。当"},{"attributes":{"bold":"true"},"insert":"智能体发布"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"智能体删除"},{"insert":"、"},{"attributes":{"bold":"true"},"insert":"账单生成"},{"insert":"等关键业务事件被触发时，扣子编程将向开发者指定的服务器地址发送回调消息。\n"},{"attributes":{"lmkr":"1","text-indent":"true"},"insert":"*"},{"insert":"回调分为普通回调和渠道回调，具体说明如下：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"普通回调应用：开发者在扣子编程中创建回调应用，用于接收扣子编程触发的事件通知。当订阅的事件被触发时，扣子编程会向该回调地址推送回调消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"渠道回调应用：当渠道入驻扣子编程后，开发者可以在该渠道中创建回调应用，用于接收该渠道中触发的事件通知。当订阅的事件被触发时，扣子编程会向渠道指定的回调地址推送回调消息。\n"},{"attributes":{"anchor":"9d5a797a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子个人版中，任何用户均可以创建普通回调应用。仅渠道创建者支持创建对应渠道的回调应用，统一接收该渠道中的回调消息。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"扣子企业版（企业标准版、企业旗舰版）中，仅超级管理员和管理员可创建回调应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="appType">
        /// 必填
        /// </param>
        /// <param name="connectorId">
        /// app_type=connector 时必传
        /// </param>
        /// <param name="name">
        /// 回调应用的名称， app_type=normal 时必传
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateApiAppOpenResponse> CreateApiAppOpenAsync(
            global::G.CreateApiAppOpenRequestAppType appType,
            string? connectorId = default,
            string? name = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}