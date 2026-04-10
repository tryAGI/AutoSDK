//HintName: G.ILogsExportClient.CreateLogsExportsByExportIdCancel.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsExportClient
    {
        /// <summary>
        /// Cancel log export
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExportTaskResponse> CreateLogsExportsByExportIdCancelAsync(
            string exportId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}