//HintName: recraft.IrecraftClient.GetPing.g.cs
#nullable enable

namespace recraft
{
    public partial interface IrecraftClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task GetPingAsync(
            global::recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}