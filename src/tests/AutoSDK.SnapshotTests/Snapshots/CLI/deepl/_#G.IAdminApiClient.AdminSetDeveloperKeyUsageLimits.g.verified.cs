//HintName: G.IAdminApiClient.AdminSetDeveloperKeyUsageLimits.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminApiClient
    {
        /// <summary>
        /// Set developer key usage limits as an admin
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> AdminSetDeveloperKeyUsageLimitsAsync(

            global::G.AdminSetDeveloperKeyUsageLimitsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set developer key usage limits as an admin
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.ApiKey>> AdminSetDeveloperKeyUsageLimitsAsResponseAsync(

            global::G.AdminSetDeveloperKeyUsageLimitsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set developer key usage limits as an admin
        /// </summary>
        /// <param name="keyId">
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </param>
        /// <param name="characters">
        /// Restricts the number of total characters (across text translation, document translation, and text improvement) that can be consumed by an API key in a one-month usage period.<br/>
        /// Setting the limit to `0` means the API key will not be able to consume characters.<br/>
        /// Setting the limit to `null` disables the limit, effectively allowing unlimited usage.<br/>
        /// Example: 5000
        /// </param>
        /// <param name="speechToTextMilliseconds">
        /// Restricts the number of milliseconds of speech-to-text that can be consumed by an API key in a one-month usage period.<br/>
        /// Setting the limit to `0` means the API key will not be able to consume speech-to-text milliseconds.<br/>
        /// Setting the limit to `null` disables the limit, effectively allowing unlimited usage.<br/>
        /// Example: 3600000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> AdminSetDeveloperKeyUsageLimitsAsync(
            string keyId,
            double? characters = default,
            double? speechToTextMilliseconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}