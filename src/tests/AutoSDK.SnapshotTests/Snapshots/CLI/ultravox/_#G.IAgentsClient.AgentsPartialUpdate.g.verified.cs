//HintName: G.IAgentsClient.AgentsPartialUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Agent> AgentsPartialUpdateAsync(
            global::System.Guid agentId,
            global::G.PatchedAgent request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="callTemplate">
        /// A CallTemplate that can be used to create Ultravox calls with shared properties.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Agent> AgentsPartialUpdateAsync(
            global::System.Guid agentId,
            string? name = default,
            global::G.UltravoxV1CallTemplate? callTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}