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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkExport> GetBulkExportAsync(
            global::System.Guid bulkExportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}