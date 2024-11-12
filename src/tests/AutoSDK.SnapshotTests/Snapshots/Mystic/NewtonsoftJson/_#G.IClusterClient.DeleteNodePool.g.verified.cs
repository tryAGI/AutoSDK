//HintName: G.IClusterClient.DeleteNodePool.g.cs
#nullable enable

namespace G
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// Delete Node Pool
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="nodePoolName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteNodePoolAsync(
            string clusterId,
            string nodePoolName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}