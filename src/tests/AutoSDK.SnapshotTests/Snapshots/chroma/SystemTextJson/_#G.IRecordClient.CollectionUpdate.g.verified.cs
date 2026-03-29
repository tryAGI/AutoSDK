//HintName: G.IRecordClient.CollectionUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Update records<br/>
        /// Updates records in a collection by ID.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// await collection.update({ ids: ['id1'], documents: ['updated doc'], metadatas: [{ key: 'value' }] });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.UpdateCollectionRecordsResponse> CollectionUpdateAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.UpdateCollectionRecordsPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update records<br/>
        /// Updates records in a collection by ID.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="documents"></param>
        /// <param name="embeddings"></param>
        /// <param name="ids"></param>
        /// <param name="metadatas"></param>
        /// <param name="uris"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCollectionRecordsResponse> CollectionUpdateAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Collections.Generic.IList<string> ids,
            global::System.Collections.Generic.IList<string>? documents = default,
            global::G.OneOf<object, global::G.UpdateEmbeddingsPayload?>? embeddings = default,
            global::System.Collections.Generic.IList<global::G.OneOf<object, global::G.HashMap>>? metadatas = default,
            global::System.Collections.Generic.IList<string>? uris = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}