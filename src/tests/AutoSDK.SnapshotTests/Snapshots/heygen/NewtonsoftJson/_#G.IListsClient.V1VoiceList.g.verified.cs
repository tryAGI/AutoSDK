//HintName: G.IListsClient.V1VoiceList.g.cs
#nullable enable

namespace G
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v1/voice.list<br/>
        /// v1/voice.list
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1VoiceListAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}