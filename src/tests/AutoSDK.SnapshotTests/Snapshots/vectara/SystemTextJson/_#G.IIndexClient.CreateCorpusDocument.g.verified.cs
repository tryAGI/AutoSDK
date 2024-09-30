//HintName: G.IIndexClient.CreateCorpusDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IIndexClient
    {
        /// <summary>
        /// Add a document to a corpus<br/>
        /// Add a document to a corpus. You can add documents that are either in a typical structured format,<br/>
        /// or in a format that explicitly specifies each document part that becomes a search result.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> CreateCorpusDocumentAsync(
            string corpusKey,
            global::G.CreateDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a document to a corpus<br/>
        /// Add a document to a corpus. You can add documents that are either in a typical structured format,<br/>
        /// or in a format that explicitly specifies each document part that becomes a search result.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> CreateCorpusDocumentAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}