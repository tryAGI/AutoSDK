//HintName: G.IAgentSessionsClient.ListSessionArtifacts.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// List session artifacts<br/>
        /// List all artifacts stored in a specific agent session, with cursor-based pagination. Artifacts are files either uploaded by the user, or generated within a session. This endpoint shows you what files exist in a session, but does not include the file content.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="orderBy">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListSessionArtifactsResponse> ListSessionArtifactsAsync(
            string agentKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? pageKey = default,
            global::G.ListSessionArtifactsSortBy? sortBy = default,
            global::G.ListSessionArtifactsOrderBy? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}