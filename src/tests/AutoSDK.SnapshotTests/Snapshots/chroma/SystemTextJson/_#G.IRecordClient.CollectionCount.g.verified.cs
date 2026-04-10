//HintName: G.IRecordClient.CollectionCount.g.cs
#nullable enable

namespace G
{
    public partial interface IRecordClient
    {
        /// <summary>
        /// Get number of records<br/>
        /// Returns the number of records in a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="readLevel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const count = await collection.count();
        /// </remarks>
        global::System.Threading.Tasks.Task<int> CollectionCountAsync(
            string tenant,
            string database,
            string collectionId,
            global::G.ReadLevel? readLevel = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}