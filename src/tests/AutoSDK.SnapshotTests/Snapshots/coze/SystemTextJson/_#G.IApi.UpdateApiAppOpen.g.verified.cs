//HintName: G.IApi.UpdateApiAppOpen.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 修改回调应用<br/>
        /// {"0":{"ops":[{"insert":"修改回调应用的名称和回调地址。\n"},{"attributes":{"anchor":"949284f6","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子个人版中，仅支持修改本人创建的回调应用。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子企业版中，仅超级管理员和管理员可修改回调应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="apiAppId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateApiAppOpenResponse> UpdateApiAppOpenAsync(
            string apiAppId,

            global::G.UpdateApiAppOpenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 修改回调应用<br/>
        /// {"0":{"ops":[{"insert":"修改回调应用的名称和回调地址。\n"},{"attributes":{"anchor":"949284f6","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子个人版中，仅支持修改本人创建的回调应用。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"扣子企业版中，仅超级管理员和管理员可修改回调应用。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="apiAppId"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateApiAppOpenResponse> UpdateApiAppOpenAsync(
            string apiAppId,
            string? callbackUrl = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}