//HintName: G.IAgentsPlatformClient.GetAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Dependent Agents List<br/>
        /// Get a list of agents depending on this knowledge base document
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="dependentType">
        /// Type of dependent agents to return.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetKnowledgeBaseDependentAgentsResponseModel> GetAgentsAsync(
            string documentationId,
            global::G.KnowledgeBaseDependentType? dependentType = default,
            int? pageSize = default,
            string? cursor = default,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}