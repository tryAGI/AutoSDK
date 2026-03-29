//HintName: G.IRecordClient.CollectionQuery.g.cs
#nullable enable

namespace G
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Query collection<br/>
        /// Queries a collection using dense vector search with metadata and full-text search filtering.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const results = await collection.query({ queryEmbeddings: [[0.1, 0.2, 0.3]], nResults: 10 });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.QueryResponse> CollectionQueryAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.QueryRequestPayload request,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query collection<br/>
        /// Queries a collection using dense vector search with metadata and full-text search filtering.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryResponse> CollectionQueryAsync(
            string tenant,
            string database,
            string collectionId,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}