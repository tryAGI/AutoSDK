//HintName: G.IAgentSessionsClient.GetSessionArtifact.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// Get session artifact<br/>
        /// Retrieve a specific artifact by its unique `artifact_id`, including metadata and base64-encoded file content.
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
        /// <param name="artifactId">
        /// Example: art_report_pdf_a3f2
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SessionArtifact> GetSessionArtifactAsync(
            string agentKey,
            string sessionKey,
            string artifactId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}