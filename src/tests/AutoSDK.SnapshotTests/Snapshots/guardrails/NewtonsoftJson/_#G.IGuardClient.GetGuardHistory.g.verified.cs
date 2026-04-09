//HintName: G.IGuardClient.GetGuardHistory.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardClient
    {
        /// <summary>
        /// Fetches the history for a specific Guard execution by using the id for the most recent Call
        /// </summary>
        /// <param name="guardName"></param>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Call>> GetGuardHistoryAsync(
            string guardName,
            string callId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}