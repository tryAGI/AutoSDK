//HintName: G.IDocumentsClient.CreateDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Create Document<br/>
        /// Upload documents to your knowledge base for personas to reference. Supports .pdf, .txt, .docx, .doc, .png, .jpg, .pptx, .csv, .xlsx and URLs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> CreateDocumentAsync(

            global::G.CreateDocumentRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Document<br/>
        /// Upload documents to your knowledge base for personas to reference. Supports .pdf, .txt, .docx, .doc, .png, .jpg, .pptx, .csv, .xlsx and URLs.
        /// </summary>
        /// <param name="documentName"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="documentUrl"></param>
        /// <param name="tags"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="crawl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> CreateDocumentAsync(
            string? documentName = default,
            byte[]? file = default,
            string? filename = default,
            string? documentUrl = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? callbackUrl = default,
            global::G.CrawlConfig? crawl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}