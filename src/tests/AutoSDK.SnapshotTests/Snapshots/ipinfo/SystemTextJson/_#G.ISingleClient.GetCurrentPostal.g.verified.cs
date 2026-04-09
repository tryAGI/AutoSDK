//HintName: G.ISingleClient.GetCurrentPostal.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current postal.<br/>
        /// Returns the current postal.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentPostalAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}