//HintName: G.IListsClient.V2Voices.g.cs
#nullable enable

namespace G
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v2/voices<br/>
        /// v2/voices
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2VoicesAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}