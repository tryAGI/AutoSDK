//HintName: G.IAgentsClient.AgentsDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AgentsDestroyAsync(
            global::System.Guid agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}