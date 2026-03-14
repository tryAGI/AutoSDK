//HintName: G.IDocumentsClient.ListCorpusDocuments.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// List the documents in the corpus<br/>
        /// The List Documents API enables you to retrieve a list of documents stored in a specific corpus. This endpoint provides an overview of document metadata, including document IDs, tables (if table extraction is enabled), and pagination details. <br/>
        /// Use this API for viewing documents indexed so far and helping you decide to remove documents that are no longer needed. It helps you manage the document lifecycle in your environment.<br/>
        /// This information enables you to catalog and inventory large amounts of data while also retrieving lists of documents for further analysis. For example, developers can utilize the metadata to to build custom search and filtering capabilities into their applications. If you enabled tabled extraction, this endpoint also returns the tables that this document contains.<br/>
        /// Currently Document Admin APIs do not allow you to access the text of your documents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="metadataFilter"></param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDocumentsResponse> ListCorpusDocumentsAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            string? metadataFilter = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}