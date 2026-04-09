//HintName: G.INumbersClient.GetInboundNumber.g.cs
#nullable enable

namespace G
{
    public partial interface INumbersClient
    {
        /// <summary>
        /// Number Details<br/>
        /// Retrieve configuration details for a specific inbound number.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InboundNumber> GetInboundNumberAsync(
            string phoneNumber,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}