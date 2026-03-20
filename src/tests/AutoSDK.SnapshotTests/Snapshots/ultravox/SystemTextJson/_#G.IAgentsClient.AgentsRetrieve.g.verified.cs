//HintName: G.IAgentsClient.AgentsRetrieve.g.cs
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
        global::System.Threading.Tasks.Task<global::G.Agent> AgentsRetrieveAsync(
            global::System.Guid agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}