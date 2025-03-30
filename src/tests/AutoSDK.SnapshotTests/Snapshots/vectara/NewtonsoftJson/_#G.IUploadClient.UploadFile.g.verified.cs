//HintName: G.IUploadClient.UploadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IUploadClient
    {
        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload files such as PDFs and Word Documents for automatic text extraction and metadata parsing.<br/>
        /// The request expects a `multipart/form-data` format containing the following parts:<br/>
        /// * `metadata` - (Optional) Specifies a JSON object representing any additional metadata to be associated with the extracted document. For example, `'metadata={"key": "value"};type=application/json'`<br/>
        /// * `chunking_strategy` - (Optional) Specifies the chunking strategy for the platform to use. If you do not set this option, the platform uses the default strategy, which creates one chunk per sentence. You can explicitly set sentence chunking with `'chunking_strategy={"type":"sentence_chunking_strategy"};type=application/json'` or use max chars chunking with `'chunking_strategy={"type":"max_chars_chunking_strategy","max_chars_per_chunk":200};type=application/json'`<br/>
        /// * `table_extraction_config` - (Optional) Specifies whether to extract table data from the uploaded file. If you do not set this option, the platform does not extract tables from PDF files. Example config, `'table_extraction_config={"extract_tables":true};type=application/json'`<br/>
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
        /// Upload files such as PDFs and Word Documents for automatic text extraction and metadata parsing.<br/>
        /// The request expects a `multipart/form-data` format containing the following parts:<br/>
        /// * `metadata` - (Optional) Specifies a JSON object representing any additional metadata to be associated with the extracted document. For example, `'metadata={"key": "value"};type=application/json'`<br/>
        /// * `chunking_strategy` - (Optional) Specifies the chunking strategy for the platform to use. If you do not set this option, the platform uses the default strategy, which creates one chunk per sentence. You can explicitly set sentence chunking with `'chunking_strategy={"type":"sentence_chunking_strategy"};type=application/json'` or use max chars chunking with `'chunking_strategy={"type":"max_chars_chunking_strategy","max_chars_per_chunk":200};type=application/json'`<br/>
        /// * `table_extraction_config` - (Optional) Specifies whether to extract table data from the uploaded file. If you do not set this option, the platform does not extract tables from PDF files. Example config, `'table_extraction_config={"extract_tables":true};type=application/json'`<br/>
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
        /// <param name="chunkingStrategy">
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy,<br/>
        /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </param>
        /// <param name="tableExtractionConfig">
        /// Configuration for table extraction from the document. This is optional and if not provided, default table extraction behavior will be used.
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
            global::G.ChunkingStrategy? chunkingStrategy = default,
            global::G.TableExtractionConfig? tableExtractionConfig = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}