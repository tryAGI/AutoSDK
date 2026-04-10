//HintName: G.IPartitionOperationsV2Client.CreateVectordbPartitionsHas.g.cs
#nullable enable

namespace G
{
    public partial interface IPartitionOperationsV2Client
    {
        /// <summary>
        /// Has Partition<br/>
        /// This operation checks whether a partition exists.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Has> CreateVectordbPartitionsHasAsync(

            global::G.CreateVectordbPartitionsHasRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Has Partition<br/>
        /// This operation checks whether a partition exists.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of an existing database. The value defaults to __default__.
        /// </param>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
        /// <param name="partitionName">
        /// The name of the partition to test.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Has> CreateVectordbPartitionsHasAsync(
            string collectionName,
            string partitionName,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}