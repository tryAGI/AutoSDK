//HintName: G.IMemoriesClient.MemoriesBatchUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Batch update multiple memories (up to 1000) in a single API call.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesBatchUpdateResponse> MemoriesBatchUpdateAsync(

            global::G.MemoriesBatchUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update multiple memories (up to 1000) in a single API call.
        /// </summary>
        /// <param name="memories"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesBatchUpdateResponse> MemoriesBatchUpdateAsync(
            global::System.Collections.Generic.IList<global::G.MemoriesBatchUpdateRequestMemorie> memories,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}