//HintName: G.IApi.StopAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Stop an agent<br/>
        /// Stop a running cloud agent. This pauses the agent's execution without deleting it. Stopped agents cannot be resumed.
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StopAgentResponse> StopAgentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}