//HintName: G.IRunnersClient.ConnectRunner.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Connect a local runner<br/>
        /// Exchange a pairing code or API key for local runner credentials
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalRunnerConnectResponse> ConnectRunnerAsync(

            global::G.LocalRunnerConnectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect a local runner<br/>
        /// Exchange a pairing code or API key for local runner credentials
        /// </summary>
        /// <param name="pairingCode"></param>
        /// <param name="runnerName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalRunnerConnectResponse> ConnectRunnerAsync(
            string pairingCode,
            string runnerName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}