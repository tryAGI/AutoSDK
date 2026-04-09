//HintName: G.IRecordClient.CollectionGet.g.cs
#nullable enable

namespace G
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Get records<br/>
        /// Returns records from a collection by ID or metadata filter.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const results = await collection.get({ ids: ['id1', 'id2'] });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GetResponse> CollectionGetAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.GetRequestPayload request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get records<br/>
        /// Returns records from a collection by ID or metadata filter.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetResponse> CollectionGetAsync(
            string tenant,
            string database,
            string collectionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}