//HintName: G.IDocumentsClient.RecrawlDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Recrawl Document<br/>
        /// Trigger a recrawl of a website document to fetch fresh content.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> RecrawlDocumentAsync(
            string documentId,

            global::G.RecrawlDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recrawl Document<br/>
        /// Trigger a recrawl of a website document to fetch fresh content.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="crawl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> RecrawlDocumentAsync(
            string documentId,
            global::G.CrawlConfig? crawl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}