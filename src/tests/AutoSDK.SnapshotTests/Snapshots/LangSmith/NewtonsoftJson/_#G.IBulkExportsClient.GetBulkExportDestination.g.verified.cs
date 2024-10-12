//HintName: G.IBulkExportsClient.GetBulkExportDestination.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export Destination<br/>
        /// Get a single bulk export destination by ID
        /// </summary>
        /// <param name="destinationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkExportDestination> GetBulkExportDestinationAsync(
            global::System.Guid destinationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}