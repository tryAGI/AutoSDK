//HintName: G.ICollectionClient.ListCollections.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// List collections<br/>
        /// Lists all collections in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const collections = await client.listCollections({ limit: 10, offset: 0 });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.VecItem>> ListCollectionsAsync(
            string tenant,
            string database,
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}