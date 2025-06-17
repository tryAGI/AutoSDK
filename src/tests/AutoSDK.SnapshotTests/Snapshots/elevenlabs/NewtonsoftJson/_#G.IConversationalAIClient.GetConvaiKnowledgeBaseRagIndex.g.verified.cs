//HintName: G.IConversationalAIClient.GetConvaiKnowledgeBaseRagIndex.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get Rag Index Overview.<br/>
        /// Provides total size and other information of RAG indexes used by knowledgebase documents
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RAGIndexOverviewResponseModel> GetConvaiKnowledgeBaseRagIndexAsync(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}