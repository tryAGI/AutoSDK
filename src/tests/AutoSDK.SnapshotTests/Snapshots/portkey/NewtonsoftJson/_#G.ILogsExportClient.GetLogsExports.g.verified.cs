//HintName: G.ILogsExportClient.GetLogsExports.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Get all logs exports
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExportListResponse> GetLogsExportsAsync(
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}