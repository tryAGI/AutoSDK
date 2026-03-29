//HintName: G.IApi.OpenAPIBindConnectorUserConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 绑定设备<br/>
        /// {"0":{"ops":[{"insert":"将设备与自定义渠道绑定。\n"},{"attributes":{"anchor":"64fdb87a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1","ol-id":"spQ23ygY"},"insert":"*"},{"insert":"硬件厂商可以调用本 API 将企业内的硬件设备与企业的自定义渠道绑定，当开发者发布智能体到该自定义渠道时，在发布配置页面的设备列表中选择对应的设备，即可快速发布到对应设备。\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1","ol-id":"spQ23ygY"},"insert":"*"},{"insert":"支持批量绑定多台设备。\n"},{"attributes":{"zoneId":"DVGaiNBO1Q","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"DVGaiNBO1Q":{"ops":[{"insert":"创建自定义渠道后，默认未开启 API 绑定设备的能力，如果需要调用本 API，你需要将自定义渠道的渠道 ID 提供给扣子商务经理，申请开通渠道设备绑定的能力，并由商务经理配置设备绑定的 key。\n"}],"zoneId":"DVGaiNBO1Q","zoneType":"Z"}}
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIBindConnectorUserConfigResponse> OpenAPIBindConnectorUserConfigAsync(
            string connectorId,

            global::G.OpenAPIBindConnectorUserConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 绑定设备<br/>
        /// {"0":{"ops":[{"insert":"将设备与自定义渠道绑定。\n"},{"attributes":{"anchor":"64fdb87a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1","ol-id":"spQ23ygY"},"insert":"*"},{"insert":"硬件厂商可以调用本 API 将企业内的硬件设备与企业的自定义渠道绑定，当开发者发布智能体到该自定义渠道时，在发布配置页面的设备列表中选择对应的设备，即可快速发布到对应设备。\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1","ol-id":"spQ23ygY"},"insert":"*"},{"insert":"支持批量绑定多台设备。\n"},{"attributes":{"zoneId":"DVGaiNBO1Q","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"DVGaiNBO1Q":{"ops":[{"insert":"创建自定义渠道后，默认未开启 API 绑定设备的能力，如果需要调用本 API，你需要将自定义渠道的渠道 ID 提供给扣子商务经理，申请开通渠道设备绑定的能力，并由商务经理配置设备绑定的 key。\n"}],"zoneId":"DVGaiNBO1Q","zoneType":"Z"}}
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="configs"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAPIBindConnectorUserConfigResponse> OpenAPIBindConnectorUserConfigAsync(
            string connectorId,
            global::System.Collections.Generic.IList<global::G.UserConfig> configs,
            string? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}