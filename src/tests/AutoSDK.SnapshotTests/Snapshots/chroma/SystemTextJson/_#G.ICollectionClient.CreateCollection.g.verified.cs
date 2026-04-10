//HintName: G.ICollectionClient.CreateCollection.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Create collection<br/>
        /// Creates a new collection in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const collection = await client.createCollection({ name: 'my_collection' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Collection> CreateCollectionAsync(
            string tenant,
            string database,

            global::G.CreateCollectionPayload request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create collection<br/>
        /// Creates a new collection in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="configuration"></param>
        /// <param name="getOrCreate"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="schema"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Collection> CreateCollectionAsync(
            string tenant,
            string database,
            string name,
            global::G.OneOf<object, global::G.CollectionConfiguration>? configuration = default,
            bool? getOrCreate = default,
            global::G.OneOf<object, global::G.HashMap>? metadata = default,
            global::G.OneOf<object, global::G.Schema3>? schema = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}