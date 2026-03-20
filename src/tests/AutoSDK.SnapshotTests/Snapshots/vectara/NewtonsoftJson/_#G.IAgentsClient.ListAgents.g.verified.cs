//HintName: G.IAgentsClient.ListAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List agents<br/>
        /// The List Agents API enables you to retrieve a paginated list of all agents available to the authenticated user. This is useful for managing and monitoring agent deployments across use cases and environments.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter">
        /// Example: support.*
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListAgentsResponse> ListAgentsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            bool? enabled = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}