//HintName: G.IBulkExportsClient.GetBulkExports.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Exports<br/>
        /// Get the current workspace's bulk exports
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BulkExport>> GetBulkExportsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}