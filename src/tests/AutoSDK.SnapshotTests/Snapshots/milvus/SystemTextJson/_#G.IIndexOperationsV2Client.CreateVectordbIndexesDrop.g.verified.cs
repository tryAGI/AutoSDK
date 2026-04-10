//HintName: G.IIndexOperationsV2Client.CreateVectordbIndexesDrop.g.cs
#nullable enable

namespace G
{
    public partial interface IIndexOperationsV2Client
    {
        /// <summary>
        /// Drop Index<br/>
        /// This operation deletes index from a specified collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbIndexesDropAsync(

            global::G.IndexName request,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Drop Index<br/>
        /// This operation deletes index from a specified collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="indexName1">
        /// The name fo the target index.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbIndexesDropAsync(
            string collectionName,
            string indexName1,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}