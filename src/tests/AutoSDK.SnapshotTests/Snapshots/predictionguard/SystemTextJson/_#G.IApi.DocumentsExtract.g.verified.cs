//HintName: G.IApi.DocumentsExtract.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Documents Extract<br/>
        /// This endpoint allows you to parse text from documents using OCR.
        /// </summary>
        /// <param name="toxicity"></param>
        /// <param name="pii"></param>
        /// <param name="replaceMethod"></param>
        /// <param name="entityList"></param>
        /// <param name="injection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentsExtractResponse200> DocumentsExtractAsync(

            global::G.DocumentsExtractRequest request,
            bool? toxicity = default,
            string? pii = default,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            bool? injection = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Documents Extract<br/>
        /// This endpoint allows you to parse text from documents using OCR.
        /// </summary>
        /// <param name="toxicity"></param>
        /// <param name="pii"></param>
        /// <param name="replaceMethod"></param>
        /// <param name="entityList"></param>
        /// <param name="injection"></param>
        /// <param name="file">
        /// The document file to upload.
        /// </param>
        /// <param name="filename">
        /// The document file to upload.
        /// </param>
        /// <param name="embedImages">
        /// Whether to embed images from the document.
        /// </param>
        /// <param name="outputFormat">
        /// The output format for the content of the document.
        /// </param>
        /// <param name="chunkDocument">
        /// Whether to separate the document into chunks.
        /// </param>
        /// <param name="chunkSize">
        /// The size of chunks for the documents.
        /// </param>
        /// <param name="enableOCR">
        /// Whether to enable OCR for document parsing.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentsExtractResponse200> DocumentsExtractAsync(
            byte[] file,
            string filename,
            bool? toxicity = default,
            string? pii = default,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            bool? injection = default,
            bool? embedImages = default,
            string? outputFormat = default,
            bool? chunkDocument = default,
            int? chunkSize = default,
            bool? enableOCR = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}