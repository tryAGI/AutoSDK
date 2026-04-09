//HintName: G.ICollectionClient.DeleteCollection.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Delete collection<br/>
        /// Deletes a collection in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// await client.deleteCollection({ name: 'my_collection' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.DeleteCollectionResponse> DeleteCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}