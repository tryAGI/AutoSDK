//HintName: G.IRagEngineClient.V1LibraryManagement.g.cs
#nullable enable

namespace G
{
    public partial interface IRagEngineClient
    {
        /// <summary>
        /// Generate Documents Signed Url
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1LibraryManagementAsync(
            global::System.Guid fileId,
            int? requestStartTime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}