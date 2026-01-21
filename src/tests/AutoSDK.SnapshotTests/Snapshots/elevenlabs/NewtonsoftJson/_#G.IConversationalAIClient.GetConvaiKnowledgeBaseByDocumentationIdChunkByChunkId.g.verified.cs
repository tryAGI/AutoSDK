//HintName: G.IConversationalAIClient.GetConvaiKnowledgeBaseByDocumentationIdChunkByChunkId.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get Documentation Chunk From Knowledge Base<br/>
        /// Get details about a specific documentation part used by RAG.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="chunkId">
        /// The id of a document RAG chunk from the knowledge base.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.KnowledgeBaseDocumentChunkResponseModel> GetConvaiKnowledgeBaseByDocumentationIdChunkByChunkIdAsync(
            string documentationId,
            string chunkId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}