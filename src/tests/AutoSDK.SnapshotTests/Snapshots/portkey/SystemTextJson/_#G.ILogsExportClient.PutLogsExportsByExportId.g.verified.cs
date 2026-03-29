//HintName: G.ILogsExportClient.PutLogsExportsByExportId.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Update a logs export
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateExportResponse> PutLogsExportsByExportIdAsync(
            string exportId,

            global::G.PutLogsExportsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a logs export
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="filters"></param>
        /// <param name="requestedData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateExportResponse> PutLogsExportsByExportIdAsync(
            string exportId,
            global::G.GenerationsFilterSchema filters,
            string? workspaceId = default,
            global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem>? requestedData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}