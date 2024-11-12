//HintName: G.ISingleClient.GetTimezoneByIp.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns a timezone for the selected IP.<br/>
        /// Returns a timezone for the selected IP.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetTimezoneByIpAsync(
            string ip,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}