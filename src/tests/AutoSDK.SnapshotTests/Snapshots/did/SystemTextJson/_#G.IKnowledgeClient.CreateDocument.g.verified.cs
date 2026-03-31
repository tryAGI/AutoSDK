//HintName: G.IKnowledgeClient.CreateDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Create a Document<br/>
        /// Add document to knowledge base<br/>
        /// Here you could add any document of supported type to become knowledge for your agent.<br/>
        /// Agent will use this documents to answer for user questions.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDocumentResponse> CreateDocumentAsync(
            string knowledgeId,

            global::G.AllOf<global::G.CreateDocumentRequestVariant1, global::G.CreateDocumentRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Document<br/>
        /// Add document to knowledge base<br/>
        /// Here you could add any document of supported type to become knowledge for your agent.<br/>
        /// Agent will use this documents to answer for user questions.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDocumentResponse> CreateDocumentAsync(
            string knowledgeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}