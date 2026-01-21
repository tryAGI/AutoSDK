//HintName: G.IConversationalAIClient.GetConvaiKnowledgeBaseByDocumentationIdRagIndex.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get Rag Indexes Of The Specified Knowledgebase Document.<br/>
        /// Provides information about all RAG indexes of the specified knowledgebase document.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RAGDocumentIndexesResponseModel> GetConvaiKnowledgeBaseByDocumentationIdRagIndexAsync(
            string documentationId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}