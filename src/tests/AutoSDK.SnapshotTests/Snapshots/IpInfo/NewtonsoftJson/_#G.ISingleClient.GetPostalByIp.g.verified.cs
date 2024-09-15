//HintName: G.ISingleClient.GetPostalByIp.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns a postal for the selected IP.<br/>
        /// Returns a postal for the selected IP.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetPostalByIpAsync(
            string ip,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}