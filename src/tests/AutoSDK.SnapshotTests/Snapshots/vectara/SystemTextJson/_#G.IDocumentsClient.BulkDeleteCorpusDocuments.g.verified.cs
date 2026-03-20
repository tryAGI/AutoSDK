//HintName: G.IDocumentsClient.BulkDeleteCorpusDocuments.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {

        /// <summary>
        /// Bulk delete documents from a corpus<br/>
        /// Initiates an asynchronous bulk delete operation for documents in a corpus.<br/>
        /// This operation accepts a metadata filter, a list of specific document IDs, or both.<br/>
        /// **Important**: This is a best-effort operation.<br/>
        /// See the response schema documentation for details on the behavior differences between `metadata_filter` and `document_ids` parameters.<br/>
        /// The operation runs as a background workflow.<br/>
        /// Use the returned `job_id` to track progress via the Jobs API.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="metadataFilter"></param>
        /// <param name="documentIds"></param>
        /// <param name="async">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkDeleteDocumentsResponse> BulkDeleteCorpusDocumentsAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? metadataFilter = default,
            string? documentIds = default,
            bool? async = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}