//HintName: G.IRecordClient.CollectionAdd.g.cs
#nullable enable

namespace G
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Add records<br/>
        /// Adds records to a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// await collection.add({ ids: ['id1', 'id2'], embeddings: [[0.1, 0.2], [0.3, 0.4]], documents: ['doc1', 'doc2'] });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.AddCollectionRecordsResponse> CollectionAddAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.AddCollectionRecordsPayload request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add records<br/>
        /// Adds records to a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="documents"></param>
        /// <param name="embeddings">
        /// Embeddings for each record. Can contain the raw f32 arrays or base64 encoded strings.
        /// </param>
        /// <param name="ids">
        /// Unique identifiers for each record.
        /// </param>
        /// <param name="metadatas"></param>
        /// <param name="uris"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddCollectionRecordsResponse> CollectionAddAsync(
            string tenant,
            string database,
            string collectionId,
            global::G.EmbeddingsPayload embeddings,
            global::System.Collections.Generic.IList<string> ids,
            global::System.Collections.Generic.IList<string>? documents = default,
            global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>? metadatas = default,
            global::System.Collections.Generic.IList<string>? uris = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}