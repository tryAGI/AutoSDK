//HintName: G.IConversationalAIClient.CreateConvaiKnowledgeBaseText.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Create Text Document<br/>
        /// Create a knowledge base document containing the provided text.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateConvaiKnowledgeBaseTextAsync(
            global::G.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Text Document<br/>
        /// Create a knowledge base document containing the provided text.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="text">
        /// Text content to be added to the knowledge base.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateConvaiKnowledgeBaseTextAsync(
            string text,
            string? xiApiKey = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}