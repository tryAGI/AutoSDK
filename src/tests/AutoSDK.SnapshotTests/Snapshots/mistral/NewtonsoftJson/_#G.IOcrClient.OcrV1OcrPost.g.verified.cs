//HintName: G.IOcrClient.OcrV1OcrPost.g.cs
#nullable enable

namespace G
{
    public partial interface IOcrClient
    {
        /// <summary>
        /// OCR
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OCRResponse> OcrV1OcrPostAsync(
            global::G.OCRRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// OCR
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <param name="document">
        /// Document to run OCR on
        /// </param>
        /// <param name="pages">
        /// Specific pages user wants to process in various formats: single number, range, or list of both. Starts from 0
        /// </param>
        /// <param name="includeImageBase64">
        /// Include image URLs in response
        /// </param>
        /// <param name="imageLimit">
        /// Max images to extract
        /// </param>
        /// <param name="imageMinSize">
        /// Minimum height and width of image to extract
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OCRResponse> OcrV1OcrPostAsync(
            string? model,
            global::G.AnyOf<global::G.DocumentURLChunk, global::G.ImageURLChunk> document,
            string? id = default,
            global::System.Collections.Generic.IList<int>? pages = default,
            bool? includeImageBase64 = default,
            int? imageLimit = default,
            int? imageMinSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}