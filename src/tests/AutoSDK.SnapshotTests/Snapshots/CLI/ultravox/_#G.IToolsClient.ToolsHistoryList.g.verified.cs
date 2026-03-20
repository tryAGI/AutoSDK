//HintName: G.IToolsClient.ToolsHistoryList.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="toolId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedToolHistoryList> ToolsHistoryListAsync(
            global::System.Guid toolId,
            string? cursor = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}