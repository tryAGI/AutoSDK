//HintName: G.IDocumentAIClient.DocumentParse.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentAIClient
    {
        /// <summary>
        /// Parse document<br/>
        /// Extracts structured content from documents (PDFs, images).<br/>
        /// Returns HTML, Markdown, and plain text representations along with<br/>
        /// individual elements like paragraphs, tables, figures, and headings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentParseResponse> DocumentParseAsync(

            global::G.DocumentParseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse document<br/>
        /// Extracts structured content from documents (PDFs, images).<br/>
        /// Returns HTML, Markdown, and plain text representations along with<br/>
        /// individual elements like paragraphs, tables, figures, and headings.
        /// </summary>
        /// <param name="document">
        /// The document file to parse (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </param>
        /// <param name="documentname">
        /// The document file to parse (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </param>
        /// <param name="model">
        /// The model to use for document parsing.<br/>
        /// Default: document-parse<br/>
        /// Default Value: document-parse
        /// </param>
        /// <param name="ocr">
        /// OCR mode. Set to auto to enable OCR for scanned documents,<br/>
        /// or force to always apply OCR.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="coordinates">
        /// Whether to return bounding box coordinates for elements.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormats">
        /// Comma-separated list of output formats to include.<br/>
        /// Options: html, markdown, text<br/>
        /// Default Value: html,text
        /// </param>
        /// <param name="pageStart">
        /// Start page number (1-indexed). Use to process a page range.
        /// </param>
        /// <param name="pageEnd">
        /// End page number (1-indexed, inclusive). Use to process a page range.
        /// </param>
        /// <param name="modelParams">
        /// JSON string of additional model parameters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentParseResponse> DocumentParseAsync(
            byte[] document,
            string documentname,
            string? model = default,
            global::G.DocumentParseRequestOcr? ocr = default,
            bool? coordinates = default,
            string? outputFormats = default,
            int? pageStart = default,
            int? pageEnd = default,
            string? modelParams = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}