//HintName: G.IAgentsClient.AgentsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create a new Agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAgent> AgentsCreateAsync(

            global::G.CreateAgent request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAgent> AgentsCreateAsync(
            string agentId,
            string? name = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}