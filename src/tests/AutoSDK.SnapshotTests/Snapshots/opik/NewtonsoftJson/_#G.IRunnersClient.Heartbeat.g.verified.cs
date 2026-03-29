//HintName: G.IRunnersClient.Heartbeat.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Local runner heartbeat<br/>
        /// Refresh local runner heartbeat
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalRunnerHeartbeatResponse> HeartbeatAsync(
            global::System.Guid runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}