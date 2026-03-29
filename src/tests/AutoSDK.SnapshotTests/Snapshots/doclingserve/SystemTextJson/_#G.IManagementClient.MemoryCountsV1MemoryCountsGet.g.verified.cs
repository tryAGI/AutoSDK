//HintName: G.IManagementClient.MemoryCountsV1MemoryCountsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IManagementClient
    {
        /// <summary>
        /// Memory Counts
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MemoryCountsV1MemoryCountsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}