//HintName: G.IApi.SubscribeApiAppEventOpen.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 订阅回调事件<br/>
        /// {"0":{"ops":[{"insert":"订阅回调事件。\n"},{"attributes":{"anchor":"7ade3f98","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"扣子当前支持的回调事件和使用限制请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/dev_how_to_guides/add_callback#e63c85cc\",\"linkId\":\"ifXNuKa0nw\",\"newTab\":true}"},"insert":"回调事件"},{"insert":"。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="apiAppId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SubscribeApiAppEventOpenResponse> SubscribeApiAppEventOpenAsync(
            string apiAppId,

            global::G.SubscribeApiAppEventOpenRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 订阅回调事件<br/>
        /// {"0":{"ops":[{"insert":"订阅回调事件。\n"},{"attributes":{"anchor":"7ade3f98","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"扣子当前支持的回调事件和使用限制请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/dev_how_to_guides/add_callback#e63c85cc\",\"linkId\":\"ifXNuKa0nw\",\"newTab\":true}"},"insert":"回调事件"},{"insert":"。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="apiAppId"></param>
        /// <param name="eventTypes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SubscribeApiAppEventOpenResponse> SubscribeApiAppEventOpenAsync(
            string apiAppId,
            global::System.Collections.Generic.IList<string> eventTypes,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}