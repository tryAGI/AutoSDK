//HintName: G.IRecordClient.CollectionDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Delete records<br/>
        /// Deletes records in a collection. Can filter by IDs or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// await collection.delete({ ids: ['id1', 'id2'] });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.DeleteCollectionRecordsResponse> CollectionDeleteAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.DeleteCollectionRecordsPayload request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete records<br/>
        /// Deletes records in a collection. Can filter by IDs or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteCollectionRecordsResponse> CollectionDeleteAsync(
            string tenant,
            string database,
            string collectionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}