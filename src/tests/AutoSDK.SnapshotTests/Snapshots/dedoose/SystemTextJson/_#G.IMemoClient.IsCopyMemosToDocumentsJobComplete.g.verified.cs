//HintName: G.IMemoClient.IsCopyMemosToDocumentsJobComplete.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// IsCopyMemosToDocumentsJobComplete<br/>
        /// IsCopyMemosToDocumentsJobComplete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> IsCopyMemosToDocumentsJobCompleteAsync(

            global::G.IsCopyMemosToDocumentsJobCompleteRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// IsCopyMemosToDocumentsJobComplete<br/>
        /// IsCopyMemosToDocumentsJobComplete
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> IsCopyMemosToDocumentsJobCompleteAsync(
            string jobId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}