//HintName: G.ICallsClient.StopCall.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Stop Active Call<br/>
        /// Terminates a specific active call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StatusResponse> StopCallAsync(
            string callId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}