//HintName: G.IConversationalAIClient.CreateConvaiAgentsByAgentIdAddToKnowledgeBase.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Add To Knowledge Base<br/>
        /// Uploads a file or reference a webpage for the agent to use as part of it's knowledge base
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateConvaiAgentsByAgentIdAddToKnowledgeBaseAsync(
            string agentId,
            global::G.BodyAddToKnowledgeBaseV1ConvaiAgentsAgentIdAddToKnowledgeBasePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add To Knowledge Base<br/>
        /// Uploads a file or reference a webpage for the agent to use as part of it's knowledge base
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="url">
        /// URL to a page of documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="file">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="filename">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateConvaiAgentsByAgentIdAddToKnowledgeBaseAsync(
            string agentId,
            string? xiApiKey = default,
            string? name = default,
            string? url = default,
            byte[]? file = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}