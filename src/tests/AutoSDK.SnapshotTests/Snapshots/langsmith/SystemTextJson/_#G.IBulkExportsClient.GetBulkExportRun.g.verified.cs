//HintName: G.IBulkExportsClient.GetBulkExportRun.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export Run<br/>
        /// Get a single bulk export's run by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkExportRun> GetBulkExportRunAsync(
            global::System.Guid bulkExportId,
            global::System.Guid runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}