//HintName: G.IToolsApiClient.CreateToolsPdfParserByFileId.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsApiClient
    {
        /// <summary>
        /// Parse PDF<br/>
        /// Parse PDF to other formats.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/tools/pdf-parser/{file_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"format":"text"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.ParsePdfResponse> CreateToolsPdfParserByFileIdAsync(
            string fileId,

            global::G.ParsePdfRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse PDF<br/>
        /// Parse PDF to other formats.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="format">
        /// The format into which the PDF content should be converted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsePdfResponse> CreateToolsPdfParserByFileIdAsync(
            string fileId,
            global::G.PdfConversionFormat format,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}