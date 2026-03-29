//HintName: G.IDistributedClient.UpdateCollectionCluster.g.cs
#nullable enable

namespace G
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Update collection cluster setup
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCollectionClusterResponse> UpdateCollectionClusterAsync(
            string collectionName,

            global::G.ClusterOperations request,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection cluster setup
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCollectionClusterResponse> UpdateCollectionClusterAsync(
            string collectionName,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}