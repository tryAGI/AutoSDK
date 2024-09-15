//HintName: G.IClusterClient.CreateCluster.g.cs
#nullable enable

namespace G
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// Create Cluster
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateClusterV4ClustersPostResponse> CreateClusterAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}