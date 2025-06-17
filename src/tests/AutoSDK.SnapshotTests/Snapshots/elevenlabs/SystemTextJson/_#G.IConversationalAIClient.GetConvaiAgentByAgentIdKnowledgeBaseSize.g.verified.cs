//HintName: G.IConversationalAIClient.GetConvaiAgentByAgentIdKnowledgeBaseSize.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Returns The Size Of The Agent'S Knowledge Base<br/>
        /// Returns the number of pages in the agent's knowledge base.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAgentKnowledgebaseSizeResponseModel> GetConvaiAgentByAgentIdKnowledgeBaseSizeAsync(
            string agentId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}