//HintName: G.ISingleClient.GetIpByIp.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns a ip for the selected IP. Yes, I know this is a pointless method.<br/>
        /// Returns a ip for the selected IP. Yes, I know this is a pointless method.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetIpByIpAsync(
            string ip,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}