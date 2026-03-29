//HintName: G.IUploadClient.File.g.cs
#nullable enable

namespace G
{
    public partial interface IUploadClient
    {
        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload a file to a corpus for automatic text extraction, chunking, and indexing. This endpoint is designed for unstructured documents where you want Vectara to handle parsing for you. Each uploaded file can be up to **10 MB**.<br/>
        /// Supported file types include:<br/>
        /// - Markdown (`.md`)<br/>
        /// - PDF/A (`.pdf`)<br/>
        /// - OpenOffice documents (`.odt`)<br/>
        /// - Microsoft Word (`.doc`, `.docx`)<br/>
        /// - Microsoft PowerPoint (`.ppt`, `.pptx`)<br/>
        /// - Plain text (`.txt`)<br/>
        /// - HTML (`.html`)<br/>
        /// - LXML (`.lxml`)<br/>
        /// - RTF (`.rtf`)<br/>
        /// - EPUB (`.epub`)<br/>
        /// - Email files (RFC 822)   <br/>
        /// :::note<br/>
        /// For semi-structured documents that require more control over fields or metadata, use the [**Create Corpus Document API**](/docs/rest-api/create-corpus-document) instead.<br/>
        /// :::<br/>
        /// ## Additional format support through Vectara Ingest<br/>
        /// If you need to ingest additional file types or data sources, you can use the open-source [**Vectara Ingest**](https://github.com/vectara/vectara-ingest) Python framework. It supports connectors for websites, RSS feeds, CSV, Confluence, HubSpot, ServiceNow, Jira, Notion, Slack, MediaWiki, GitHub, SharePoint, Twitter/X, YouTube, and more.<br/>
        /// :::caution<br/>
        /// Vectara Ingest is provided as an open-source example and is not officially supported.<br/>
        /// :::<br/>
        /// ## Multipart form fields<br/>
        /// This endpoint expects a `multipart/form-data` request with the following fields:<br/>
        /// - **metadata** (optional): JSON metadata to attach to the parsed document.  <br/>
        ///   Example: `metadata={"key":"value"}`<br/>
        /// - **chunking_strategy** (optional): Controls how extracted text is chunked.  <br/>
        ///   Defaults to sentence-based chunking (one chunk per sentence).  <br/>
        ///   Example: `{"type":"sentence_chunking_strategy"}`. <br/>
        ///   Example for max character chunking: `{"type":"max_chars_chunking_strategy","max_chars_per_chunk":512}`<br/>
        /// - **table_extraction_config** (optional): Enables extraction of tables from supported file types such as PDFs.  <br/>
        ///   Example: `{"extract_tables": true}`<br/>
        /// - **file** (required): The file to upload.<br/>
        /// - **filename** (required): The desired document ID, specified within the file upload field.<br/>
        /// Apart from these parameters, the servers expect a valid JWT Token in the HTTP headers:<br/>
        /// ```curl<br/>
        /// \$ curl -L -X POST 'https://api.vectara.io/v2/corpora/:corpus_key/upload_file' \<br/>
        /// -H 'Content-Type: multipart/form-data' \<br/>
        /// -H 'Accept: application/json' \<br/>
        /// -H 'x-api-key: zwt_123456' \<br/>
        /// -F 'metadata=\{"key": "value"\};type=application/json' \<br/>
        /// -F 'file=@/path/to/file/file.pdf;filename=desired_filename.pdf'<br/>
        /// ```<br/>
        /// ## Filenames with non-ASCII characters<br/>
        /// When uploading files with non-ASCII (non-English) characters, such as Russian or Chinese, ensure that the filename is URL encoded. The Vectara REST API follows web standards which require URL-encoded file names.<br/>
        /// ## Set the document ID<br/>
        ///   <br/>
        /// To set a custom Document ID, pass it as the filename in the `Content-Disposition` header:<br/>
        /// `Content-Disposition: form-data; name="file"; filename="your_document_id"`<br/>
        /// For more information about Content-Disposition, see the [Mozilla documentation on headers](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Disposition).<br/>
        /// ## Attach additional metadata<br/>
        /// You can attach additional metadata to the file by specifying a metadata form field, which can contain a JSON string:<br/>
        /// `{ "filesize": 1234 }`<br/>
        /// ## Tabular data extraction and summarization<br/>
        /// Setting `table_extraction_config.extract_tables = true` enables extraction of tabular data (such as financial filings such as 10-K, 10-Q, S-1). You can also apply custom prompt templates to summarize table content during upload.<br/>
        /// :::caution<br/>
        /// Table extraction does not support scanned images of tables.<br/>
        /// :::<br/>
        /// ## Custom table summarization with prompt templates<br/>
        /// Vectara supports [table summarization using custom prompt templates](https://docs.vectara.com/docs/build/working-with-tables#summarize-tables-with-custom-prompts) during document upload. This lets you define custom prompt templates that control how the LLM interprets and summarizes table data during extraction. By customizing the prompt_template, you can tailor summaries for domain-specific language, analytical perspectives, or formatting preferences.<br/>
        /// ## Image support<br/>
        /// You can include images in structured documents using the [Indexing API](/docs/rest-api/create-corpus-document) with Base64 encoding. You cannot send images directly with individual query requests. If you want to retrieve a specific image that is embedded within a document, use the [Retrieve image API](/docs/rest-api/get-image)
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
        global::System.Threading.Tasks.Task<global::G.Document> FileAsync(
            string corpusKey,

            global::G.UploadFileRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file to the corpus<br/>
        /// Upload a file to a corpus for automatic text extraction, chunking, and indexing. This endpoint is designed for unstructured documents where you want Vectara to handle parsing for you. Each uploaded file can be up to **10 MB**.<br/>
        /// Supported file types include:<br/>
        /// - Markdown (`.md`)<br/>
        /// - PDF/A (`.pdf`)<br/>
        /// - OpenOffice documents (`.odt`)<br/>
        /// - Microsoft Word (`.doc`, `.docx`)<br/>
        /// - Microsoft PowerPoint (`.ppt`, `.pptx`)<br/>
        /// - Plain text (`.txt`)<br/>
        /// - HTML (`.html`)<br/>
        /// - LXML (`.lxml`)<br/>
        /// - RTF (`.rtf`)<br/>
        /// - EPUB (`.epub`)<br/>
        /// - Email files (RFC 822)   <br/>
        /// :::note<br/>
        /// For semi-structured documents that require more control over fields or metadata, use the [**Create Corpus Document API**](/docs/rest-api/create-corpus-document) instead.<br/>
        /// :::<br/>
        /// ## Additional format support through Vectara Ingest<br/>
        /// If you need to ingest additional file types or data sources, you can use the open-source [**Vectara Ingest**](https://github.com/vectara/vectara-ingest) Python framework. It supports connectors for websites, RSS feeds, CSV, Confluence, HubSpot, ServiceNow, Jira, Notion, Slack, MediaWiki, GitHub, SharePoint, Twitter/X, YouTube, and more.<br/>
        /// :::caution<br/>
        /// Vectara Ingest is provided as an open-source example and is not officially supported.<br/>
        /// :::<br/>
        /// ## Multipart form fields<br/>
        /// This endpoint expects a `multipart/form-data` request with the following fields:<br/>
        /// - **metadata** (optional): JSON metadata to attach to the parsed document.  <br/>
        ///   Example: `metadata={"key":"value"}`<br/>
        /// - **chunking_strategy** (optional): Controls how extracted text is chunked.  <br/>
        ///   Defaults to sentence-based chunking (one chunk per sentence).  <br/>
        ///   Example: `{"type":"sentence_chunking_strategy"}`. <br/>
        ///   Example for max character chunking: `{"type":"max_chars_chunking_strategy","max_chars_per_chunk":512}`<br/>
        /// - **table_extraction_config** (optional): Enables extraction of tables from supported file types such as PDFs.  <br/>
        ///   Example: `{"extract_tables": true}`<br/>
        /// - **file** (required): The file to upload.<br/>
        /// - **filename** (required): The desired document ID, specified within the file upload field.<br/>
        /// Apart from these parameters, the servers expect a valid JWT Token in the HTTP headers:<br/>
        /// ```curl<br/>
        /// \$ curl -L -X POST 'https://api.vectara.io/v2/corpora/:corpus_key/upload_file' \<br/>
        /// -H 'Content-Type: multipart/form-data' \<br/>
        /// -H 'Accept: application/json' \<br/>
        /// -H 'x-api-key: zwt_123456' \<br/>
        /// -F 'metadata=\{"key": "value"\};type=application/json' \<br/>
        /// -F 'file=@/path/to/file/file.pdf;filename=desired_filename.pdf'<br/>
        /// ```<br/>
        /// ## Filenames with non-ASCII characters<br/>
        /// When uploading files with non-ASCII (non-English) characters, such as Russian or Chinese, ensure that the filename is URL encoded. The Vectara REST API follows web standards which require URL-encoded file names.<br/>
        /// ## Set the document ID<br/>
        ///   <br/>
        /// To set a custom Document ID, pass it as the filename in the `Content-Disposition` header:<br/>
        /// `Content-Disposition: form-data; name="file"; filename="your_document_id"`<br/>
        /// For more information about Content-Disposition, see the [Mozilla documentation on headers](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Disposition).<br/>
        /// ## Attach additional metadata<br/>
        /// You can attach additional metadata to the file by specifying a metadata form field, which can contain a JSON string:<br/>
        /// `{ "filesize": 1234 }`<br/>
        /// ## Tabular data extraction and summarization<br/>
        /// Setting `table_extraction_config.extract_tables = true` enables extraction of tabular data (such as financial filings such as 10-K, 10-Q, S-1). You can also apply custom prompt templates to summarize table content during upload.<br/>
        /// :::caution<br/>
        /// Table extraction does not support scanned images of tables.<br/>
        /// :::<br/>
        /// ## Custom table summarization with prompt templates<br/>
        /// Vectara supports [table summarization using custom prompt templates](https://docs.vectara.com/docs/build/working-with-tables#summarize-tables-with-custom-prompts) during document upload. This lets you define custom prompt templates that control how the LLM interprets and summarizes table data during extraction. By customizing the prompt_template, you can tailor summaries for domain-specific language, analytical perspectives, or formatting preferences.<br/>
        /// ## Image support<br/>
        /// You can include images in structured documents using the [Indexing API](/docs/rest-api/create-corpus-document) with Base64 encoding. You cannot send images directly with individual query requests. If you want to retrieve a specific image that is embedded within a document, use the [Retrieve image API](/docs/rest-api/get-image)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="metadata">
        /// Arbitrary object that will be attached as document metadata to the extracted document.<br/>
        /// Example: {"department":"engineering","doc_type\u0022":"architecture_diagram"}
        /// </param>
        /// <param name="chunkingStrategy">
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy, the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </param>
        /// <param name="tableExtractionConfig">
        /// Configuration for table extraction from the document. This is optional and if not provided, the platform does not extract tables from PDF files.
        /// </param>
        /// <param name="filename">
        /// Optional multipart section to override the filename.<br/>
        /// Example: system_design_v1.pdf
        /// </param>
        /// <param name="file">
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> FileAsync(
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