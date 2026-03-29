//HintName: G.IDistributedClient.ClusterStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Get cluster status info<br/>
        /// Get information about the current state and composition of the cluster
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClusterStatusResponse> ClusterStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}