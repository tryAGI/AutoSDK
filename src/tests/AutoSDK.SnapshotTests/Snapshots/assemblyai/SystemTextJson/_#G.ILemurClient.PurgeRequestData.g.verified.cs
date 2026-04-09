//HintName: G.ILemurClient.PurgeRequestData.g.cs
#nullable enable

namespace G
{
    public partial interface ILemurClient
    {
        /// <summary>
        /// Purge LeMUR request data<br/>
        /// Delete the data for a previously submitted LeMUR request.<br/>
        /// The LLM response data, as well as any context provided in the original request will be removed.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PurgeLemurRequestDataResponse> PurgeRequestDataAsync(
            string requestId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}