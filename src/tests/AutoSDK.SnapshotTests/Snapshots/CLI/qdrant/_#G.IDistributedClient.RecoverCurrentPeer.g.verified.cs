//HintName: G.IDistributedClient.RecoverCurrentPeer.g.cs
#nullable enable

namespace G
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Tries to recover current peer Raft state.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RecoverCurrentPeerResponse> RecoverCurrentPeerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}