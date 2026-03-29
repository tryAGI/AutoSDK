//HintName: G.ILogsExportClient.GetLogsExportsByExportId.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Get a specific logs export
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExportItem> GetLogsExportsByExportIdAsync(
            string exportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}