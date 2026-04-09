//HintName: G.IMemoriesClient.MemoriesBatchDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Batch delete multiple memories (up to 1000) in a single API call.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesBatchDeleteResponse> MemoriesBatchDeleteAsync(

            global::G.MemoriesBatchDeleteRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch delete multiple memories (up to 1000) in a single API call.
        /// </summary>
        /// <param name="memoryIds">
        /// Array of memory IDs to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesBatchDeleteResponse> MemoriesBatchDeleteAsync(
            global::System.Collections.Generic.IList<global::System.Guid> memoryIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}