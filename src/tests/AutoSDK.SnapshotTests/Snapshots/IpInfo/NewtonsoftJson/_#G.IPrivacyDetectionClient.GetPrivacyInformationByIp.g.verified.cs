//HintName: G.IPrivacyDetectionClient.GetPrivacyInformationByIp.g.cs
#nullable enable

namespace G
{
    public partial interface IPrivacyDetectionClient
    {
        /// <summary>
        /// Returns privacy information about the selected IP.<br/>
        /// Returns privacy information about the selected IP.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PrivacyResponse> GetPrivacyInformationByIpAsync(
            string ip,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}