//HintName: G.IMemoriesClient.MemoriesRead2.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Get a memory.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesReadResponse> MemoriesRead2Async(
            global::System.Guid memoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}