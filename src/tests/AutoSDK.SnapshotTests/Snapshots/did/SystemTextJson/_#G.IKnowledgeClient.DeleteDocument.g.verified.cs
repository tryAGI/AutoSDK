//HintName: G.IKnowledgeClient.DeleteDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Delete a Document<br/>
        /// Delete document from knowledge base
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DeleteDocumentResponseItem>> DeleteDocumentAsync(
            string knowledgeId,
            string documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}