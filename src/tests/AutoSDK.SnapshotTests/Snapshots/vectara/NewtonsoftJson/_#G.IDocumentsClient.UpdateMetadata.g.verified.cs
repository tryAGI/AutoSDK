//HintName: G.IDocumentsClient.UpdateMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Replace the document metadata.<br/>
        /// Replaces metadata of a document identified by its unique `document_id` from a specific corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> UpdateMetadataAsync(
            string corpusKey,
            string documentId,

            global::G.UpdateDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the document metadata.<br/>
        /// Replaces metadata of a document identified by its unique `document_id` from a specific corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="metadata">
        /// The metadata for a document as an arbitrary object. Properties of this object can be used by document level filter attributes.<br/>
        /// Example: {"title":"2024 ESG Annual Report \u2013 EuroBank","region":"EU","industry":"banking","year":2024}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> UpdateMetadataAsync(
            string corpusKey,
            string documentId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            object? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}