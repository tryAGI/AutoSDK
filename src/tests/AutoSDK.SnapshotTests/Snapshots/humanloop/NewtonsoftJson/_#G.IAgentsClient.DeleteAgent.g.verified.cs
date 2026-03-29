//HintName: G.IAgentsClient.DeleteAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete Agent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}