//HintName: G.ICollectionClient.UpdateCollection.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Update collection<br/>
        /// Updates an existing collection's name or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// await collection.modify({ name: 'new_name', metadata: { key: 'value' } });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.UpdateCollectionResponse> UpdateCollectionAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.UpdateCollectionPayload request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection<br/>
        /// Updates an existing collection's name or metadata.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="newConfiguration"></param>
        /// <param name="newMetadata"></param>
        /// <param name="newName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCollectionResponse> UpdateCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            global::G.OneOf<object, global::G.UpdateCollectionConfiguration>? newConfiguration = default,
            global::G.OneOf<object, global::G.HashMap>? newMetadata = default,
            string? newName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}