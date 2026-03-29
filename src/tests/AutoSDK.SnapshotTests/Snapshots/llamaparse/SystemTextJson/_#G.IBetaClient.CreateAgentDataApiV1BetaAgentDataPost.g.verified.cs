//HintName: G.IBetaClient.CreateAgentDataApiV1BetaAgentDataPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Create Agent Data<br/>
        /// Create new agent data.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentData> CreateAgentDataApiV1BetaAgentDataPostAsync(

            global::G.AgentDataCreate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Data<br/>
        /// Create new agent data.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="deploymentName"></param>
        /// <param name="collection">
        /// Default Value: default
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentData> CreateAgentDataApiV1BetaAgentDataPostAsync(
            string deploymentName,
            object data,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? collection = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}