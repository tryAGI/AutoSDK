//HintName: G.IClusterClient.CreateNodePool.g.cs
#nullable enable

namespace G
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// Create Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNodePoolV4ClustersClusterIdNodePoolsPostResponse> CreateNodePoolAsync(
            string clusterId,
            global::G.NodePoolCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="accelerators"></param>
        /// <param name="spot">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNodePoolV4ClustersClusterIdNodePoolsPostResponse> CreateNodePoolAsync(
            string clusterId,
            global::System.Collections.Generic.IList<global::G.Accelerator> accelerators,
            bool? spot = true,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}