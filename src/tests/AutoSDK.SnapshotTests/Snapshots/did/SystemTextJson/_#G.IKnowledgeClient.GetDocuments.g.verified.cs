//HintName: G.IKnowledgeClient.GetDocuments.g.cs
#nullable enable

namespace G
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get Documents<br/>
        /// Get all documents from knowledge base
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GetDocumentsResponseItem>> GetDocumentsAsync(
            string knowledgeId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}