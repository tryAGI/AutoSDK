//HintName: G.IMemoriesClient.MemoriesDelete2.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Get or Update or delete a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesDeleteResponse2> MemoriesDelete2Async(
            global::System.Guid memoryId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}