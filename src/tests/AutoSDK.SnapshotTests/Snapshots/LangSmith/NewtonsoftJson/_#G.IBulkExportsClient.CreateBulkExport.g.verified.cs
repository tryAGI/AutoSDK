//HintName: G.IBulkExportsClient.CreateBulkExport.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Create Bulk Export<br/>
        /// Create a new bulk export
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkExport> CreateBulkExportAsync(
            global::G.BulkExportCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Bulk Export<br/>
        /// Create a new bulk export
        /// </summary>
        /// <param name="bulkExportDestinationId"></param>
        /// <param name="sessionId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="format"></param>
        /// <param name="compression"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkExport> CreateBulkExportAsync(
            global::System.Guid bulkExportDestinationId,
            global::System.Guid sessionId,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::G.BulkExportFormat? format = default,
            global::G.BulkExportCompression? compression = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}