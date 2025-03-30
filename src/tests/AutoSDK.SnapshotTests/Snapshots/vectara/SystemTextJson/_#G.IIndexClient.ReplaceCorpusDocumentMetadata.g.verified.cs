//HintName: G.IIndexClient.ReplaceCorpusDocumentMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface IIndexClient
    {
        /// <summary>
        /// Replace the document metadata.<br/>
        /// Replaces metadata of a document identified by its unique `document_id` <br/>
        /// from a specific corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> ReplaceCorpusDocumentMetadataAsync(
            string corpusKey,
            string documentId,
            global::G.UpdateDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace the document metadata.<br/>
        /// Replaces metadata of a document identified by its unique `document_id` <br/>
        /// from a specific corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="metadata">
        /// The metadata for a document as an arbitrary object. Properties of this object<br/>
        /// can be used by document level filter attributes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> ReplaceCorpusDocumentMetadataAsync(
            string corpusKey,
            string documentId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}