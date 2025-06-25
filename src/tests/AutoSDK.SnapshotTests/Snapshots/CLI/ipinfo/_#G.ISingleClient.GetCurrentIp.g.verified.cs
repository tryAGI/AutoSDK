//HintName: G.ISingleClient.GetCurrentIp.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current IP.<br/>
        /// Returns the current IP.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentIpAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}