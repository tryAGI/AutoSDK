//HintName: G.IDatasetsClient.SyncIndex.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Sync Index<br/>
        /// Sync an index for a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SyncIndexAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}