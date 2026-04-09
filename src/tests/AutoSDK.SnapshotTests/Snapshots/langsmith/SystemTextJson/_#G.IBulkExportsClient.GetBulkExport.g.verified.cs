//HintName: G.IBulkExportsClient.GetBulkExport.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export<br/>
        /// Get a single bulk export by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkExport> GetBulkExportAsync(
            global::System.Guid bulkExportId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}