//HintName: G.IDistributedClient.RemovePeer.g.cs
#nullable enable

namespace G
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Remove peer from the cluster<br/>
        /// Tries to remove peer from the cluster. Will return an error if peer has shards on it.
        /// </summary>
        /// <param name="peerId"></param>
        /// <param name="timeout"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RemovePeerResponse> RemovePeerAsync(
            int peerId,
            int? timeout = default,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}