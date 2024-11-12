//HintName: G.IClusterClient.DeleteCluster.g.cs
#nullable enable

namespace G
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// Delete Cluster
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteClusterAsync(
            string clusterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}