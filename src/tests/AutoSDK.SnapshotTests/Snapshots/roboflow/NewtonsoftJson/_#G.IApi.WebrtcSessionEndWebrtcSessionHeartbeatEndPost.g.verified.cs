//HintName: G.IApi.WebrtcSessionEndWebrtcSessionHeartbeatEndPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// End WebRTC session<br/>
        /// End a WebRTC session and immediately free the quota slot.<br/>
        /// Requires api_key for authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> WebrtcSessionEndWebrtcSessionHeartbeatEndPostAsync(

            global::G.WebRTCSessionHeartbeatRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// End WebRTC session<br/>
        /// End a WebRTC session and immediately free the quota slot.<br/>
        /// Requires api_key for authentication.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="apiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> WebrtcSessionEndWebrtcSessionHeartbeatEndPostAsync(
            string sessionId,
            string apiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}