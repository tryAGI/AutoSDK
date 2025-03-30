//HintName: G.IConversationalAIClient.CreateConvaiKnowledgeBase.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Add To Knowledge Base<br/>
        /// Uploads a file or reference a webpage to use as part of the shared knowledge base
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateConvaiKnowledgeBaseAsync(
            global::G.BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add To Knowledge Base<br/>
        /// Uploads a file or reference a webpage to use as part of the shared knowledge base
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateConvaiKnowledgeBaseAsync(
            string? xiApiKey = default,
            string? name = default,
            string? url = default,
            byte[]? file = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}