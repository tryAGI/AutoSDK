//HintName: G.ILogsExportClient.CreateLogsExports.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Create log export
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateExportResponse> CreateLogsExportsAsync(

            global::G.CreateLogsExportsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create log export
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="filters"></param>
        /// <param name="requestedData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateExportResponse> CreateLogsExportsAsync(
            global::G.GenerationsFilterSchema filters,
            global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem> requestedData,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}