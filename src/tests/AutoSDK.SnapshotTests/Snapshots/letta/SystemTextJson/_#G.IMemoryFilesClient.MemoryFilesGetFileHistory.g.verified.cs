//HintName: G.IMemoryFilesClient.MemoryFilesGetFileHistory.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoryFilesClient
    {
        /// <summary>
        /// Get File History<br/>
        /// Get commit history for a specific file in the agent memory repo.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="filePath"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoryFilesGetFileHistoryResponse> MemoryFilesGetFileHistoryAsync(
            string agentId,
            string filePath,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}