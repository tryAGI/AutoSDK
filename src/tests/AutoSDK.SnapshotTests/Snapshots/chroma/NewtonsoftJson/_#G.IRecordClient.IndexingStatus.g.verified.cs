//HintName: G.IRecordClient.IndexingStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Get indexing status<br/>
        /// Returns the indexing status of a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const status: IndexingStatus = await collection.getIndexingStatus();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.IndexStatusResponse> IndexingStatusAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}