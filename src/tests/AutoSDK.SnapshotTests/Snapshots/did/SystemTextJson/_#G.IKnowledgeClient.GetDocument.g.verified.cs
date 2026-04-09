//HintName: G.IKnowledgeClient.GetDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get a Document<br/>
        /// Get document by id from knowledge base
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="documentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDocumentResponse> GetDocumentAsync(
            string knowledgeId,
            string documentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}