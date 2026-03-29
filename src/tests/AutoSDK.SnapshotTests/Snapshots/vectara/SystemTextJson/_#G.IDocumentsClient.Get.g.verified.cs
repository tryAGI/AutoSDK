//HintName: G.IDocumentsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Retrieve a document<br/>
        /// The Retrieve Document API enables you to fetch the content and metadata of a specific document from a corpus, identified by its unique `document_id` from a specific corpus. Use this endpoint to view the full details of a document, including its text, metadata, and associated tables, if table extraction is enabled.<br/>
        /// This information is particularly useful when you need to analyze the details of a specific document or integrate document content into your application workflows.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> GetAsync(
            string corpusKey,
            string documentId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}