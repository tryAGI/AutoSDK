//HintName: G.IMemoriesClient.DeleteMemory.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Delete Memory<br/>
        /// Delete a single memory from a memory store.
        /// </summary>
        /// <param name="memoryStore"></param>
        /// <param name="memoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteMemoryAsync(
            string memoryStore,
            string memoryId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}