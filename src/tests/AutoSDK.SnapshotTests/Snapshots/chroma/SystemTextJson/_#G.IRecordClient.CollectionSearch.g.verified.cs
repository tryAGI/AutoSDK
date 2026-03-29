//HintName: G.IRecordClient.CollectionSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Search records<br/>
        /// Searches records from a collection with dense, sparse, or hybrid vector search.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// import { Search, K, Knn } from 'chromadb';<br/>
        /// const results = await collection.search(new Search().rank(Knn({ query: [0.1, 0.2, 0.3], limit: 10 })));
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.SearchResponse> CollectionSearchAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.SearchRequestPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search records<br/>
        /// Searches records from a collection with dense, sparse, or hybrid vector search.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="readLevel">
        /// Specifies whether to include unindexed data in the search results.
        /// </param>
        /// <param name="searches"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchResponse> CollectionSearchAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Collections.Generic.IList<global::G.SearchPayload> searches,
            global::G.ReadLevel? readLevel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}