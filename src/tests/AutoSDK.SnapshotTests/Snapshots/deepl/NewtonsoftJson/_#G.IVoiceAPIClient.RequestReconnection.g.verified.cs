//HintName: G.IVoiceAPIClient.RequestReconnection.g.cs
#nullable enable

namespace G
{
    public partial interface IVoiceAPIClient
    {
        /// <summary>
        /// Request Reconnection
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceStreamingResponse> RequestReconnectionAsync(
            string token,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Reconnection
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.VoiceStreamingResponse>> RequestReconnectionAsResponseAsync(
            string token,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}