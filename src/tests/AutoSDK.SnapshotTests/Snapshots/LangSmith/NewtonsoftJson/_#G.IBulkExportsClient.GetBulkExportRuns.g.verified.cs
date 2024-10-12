//HintName: G.IBulkExportsClient.GetBulkExportRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export Runs<br/>
        /// Get a bulk export's runs
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BulkExportRun>> GetBulkExportRunsAsync(
            global::System.Guid bulkExportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}