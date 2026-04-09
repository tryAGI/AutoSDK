//HintName: G.IClearClient.ClearResultsV1ClearResultsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IClearClient
    {
        /// <summary>
        /// Clear Results
        /// </summary>
        /// <param name="olderThen">
        /// Default Value: 3600
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClearResponse> ClearResultsV1ClearResultsGetAsync(
            double? olderThen = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}