//HintName: G.IGeneralClient.GetInformationByIp.g.cs
#nullable enable

namespace G
{
    public partial interface IGeneralClient
    {
        /// <summary>
        /// Returns information about the selected IP.<br/>
        /// Returns information about the selected IP.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FullResponse> GetInformationByIpAsync(
            string ip,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}