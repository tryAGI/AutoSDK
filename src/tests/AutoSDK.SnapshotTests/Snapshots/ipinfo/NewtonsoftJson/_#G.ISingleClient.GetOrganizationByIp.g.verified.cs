//HintName: G.ISingleClient.GetOrganizationByIp.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns a organization for the selected IP.<br/>
        /// Returns a organization for the selected IP.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetOrganizationByIpAsync(
            string ip,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}