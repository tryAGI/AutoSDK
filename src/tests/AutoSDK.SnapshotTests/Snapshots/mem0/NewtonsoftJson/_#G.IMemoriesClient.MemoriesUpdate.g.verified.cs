//HintName: G.IMemoriesClient.MemoriesUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Get or Update or delete a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesUpdateResponse> MemoriesUpdateAsync(
            global::System.Guid memoryId,

            global::G.MemoriesUpdateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get or Update or delete a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="text">
        /// The updated text content of the memory
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesUpdateResponse> MemoriesUpdateAsync(
            global::System.Guid memoryId,
            string? text = default,
            object? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}