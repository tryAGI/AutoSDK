//HintName: G.IUploadClient.UploadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IUploadClient
    {
        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload files such as PDFs and Word Documents. Vectara will attempt to automatically extract text and any metadata.<br/>
        /// The File Upload endpoint request expects a `multipart/form-data` request containing the following parts:<br/>
        /// * `metadata` - (Optional) Specifies a JSON object representing any additional metadata to be associated with the extracted document. For example, `'metadata={"key": "value"};type=application/json'`<br/>
        /// * `file` - Specifies the file that you want to upload.<br/>
        /// * `filename` - Specified as part of the file field with the file name that you want to associate with the uploaded file. For a curl example, use the following syntax: `'file=@/path/to/file/file.pdf;filename=desired_filename.pdf'`<br/>
        /// For more detailed information, see this [File Upload API guide.](https://docs.vectara.com/docs/api-reference/indexing-apis/file-upload/file-upload)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> UploadFileAsync(
            string corpusKey,
            global::G.UploadFileRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload files such as PDFs and Word Documents. Vectara will attempt to automatically extract text and any metadata.<br/>
        /// The File Upload endpoint request expects a `multipart/form-data` request containing the following parts:<br/>
        /// * `metadata` - (Optional) Specifies a JSON object representing any additional metadata to be associated with the extracted document. For example, `'metadata={"key": "value"};type=application/json'`<br/>
        /// * `file` - Specifies the file that you want to upload.<br/>
        /// * `filename` - Specified as part of the file field with the file name that you want to associate with the uploaded file. For a curl example, use the following syntax: `'file=@/path/to/file/file.pdf;filename=desired_filename.pdf'`<br/>
        /// For more detailed information, see this [File Upload API guide.](https://docs.vectara.com/docs/api-reference/indexing-apis/file-upload/file-upload)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="metadata">
        /// Arbitrary object that will be attached as document metadata to the extracted document.
        /// </param>
        /// <param name="filename">
        /// Optional multipart section to override the filename.
        /// </param>
        /// <param name="file">
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> UploadFileAsync(
            string corpusKey,
            byte[] file,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            object? metadata = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}