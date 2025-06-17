//HintName: G.IConversationalAIClient.CreateConvaiKnowledgeBaseFile.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Create File Document<br/>
        /// Create a knowledge base document generated form the uploaded file.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateConvaiKnowledgeBaseFileAsync(
            global::G.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create File Document<br/>
        /// Create a knowledge base document generated form the uploaded file.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="file">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="filename">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddKnowledgeBaseResponseModel> CreateConvaiKnowledgeBaseFileAsync(
            byte[] file,
            string filename,
            string? xiApiKey = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}