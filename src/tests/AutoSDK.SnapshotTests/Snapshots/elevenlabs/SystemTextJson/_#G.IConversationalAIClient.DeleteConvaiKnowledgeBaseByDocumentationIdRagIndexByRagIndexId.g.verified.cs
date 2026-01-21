//HintName: G.IConversationalAIClient.DeleteConvaiKnowledgeBaseByDocumentationIdRagIndexByRagIndexId.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Delete Rag Index.<br/>
        /// Delete RAG index for the knowledgebase document.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="ragIndexId">
        /// The id of RAG index of document from the knowledge base.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RAGDocumentIndexResponseModel> DeleteConvaiKnowledgeBaseByDocumentationIdRagIndexByRagIndexIdAsync(
            string documentationId,
            string ragIndexId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}