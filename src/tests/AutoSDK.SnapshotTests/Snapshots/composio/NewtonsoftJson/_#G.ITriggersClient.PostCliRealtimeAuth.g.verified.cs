//HintName: G.ITriggersClient.PostCliRealtimeAuth.g.cs
#nullable enable

namespace G
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Authenticate CLI Pusher channel access<br/>
        /// Authenticate CLI client access to a private-cli-{nanoId} Pusher channel
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostCliRealtimeAuthResponse> PostCliRealtimeAuthAsync(

            global::G.PostCliRealtimeAuthRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authenticate CLI Pusher channel access<br/>
        /// Authenticate CLI client access to a private-cli-{nanoId} Pusher channel
        /// </summary>
        /// <param name="channelName">
        /// The channel name to authenticate for
        /// </param>
        /// <param name="socketId">
        /// The socket ID for Pusher authentication
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostCliRealtimeAuthResponse> PostCliRealtimeAuthAsync(
            string channelName,
            string socketId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}