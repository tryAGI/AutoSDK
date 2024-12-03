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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateClusterAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}