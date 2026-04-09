//HintName: G.ICollectionOperationsV2Client.CreateVectordbCollectionsGetLoadState.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionOperationsV2Client
    {
        /// <summary>
        /// Get Collection Load State<br/>
        /// This operation returns the load status of a specific collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbCollectionsGetLoadStateAsync(

            global::G.CreateVectordbCollectionsGetLoadStateRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Collection Load State<br/>
        /// This operation returns the load status of a specific collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of a database to which the collection belongs.
        /// </param>
        /// <param name="collectionName">
        /// The name of a collection.
        /// </param>
        /// <param name="partitionNames">
        /// A list of partition names. If any partition names are specified, releasing any of these partitions results in the return of a NotLoad state.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbCollectionsGetLoadStateAsync(
            string collectionName,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            string? partitionNames = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}