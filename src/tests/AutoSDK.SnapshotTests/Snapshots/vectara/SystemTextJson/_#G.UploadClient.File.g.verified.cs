//HintName: G.UploadClient.File.g.cs

#nullable enable

namespace G
{
    public partial class UploadClient
    {
        partial void PrepareFileArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string corpusKey,
            global::G.UploadFileRequest request);
        partial void PrepareFileRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string corpusKey,
            global::G.UploadFileRequest request);
        partial void ProcessFileResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFileResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.Document> FileAsync(
            string corpusKey,

            global::G.UploadFileRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareFileArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                corpusKey: ref corpusKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/corpora/{corpusKey}/upload_file",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (requestTimeout != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (requestTimeoutMillis != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (requestTimeout != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{requestTimeout}"),
                    name: "\"Request-Timeout\"");
            } 
            if (requestTimeoutMillis != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{requestTimeoutMillis}"),
                    name: "\"Request-Timeout-Millis\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{corpusKey}"),
                name: "\"corpus_key\"");
            if (request.Metadata != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Metadata}"),
                    name: "\"metadata\"");
            } 
            if (request.ChunkingStrategy != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.ChunkingStrategy?.ToString() ?? string.Empty),
                    name: "\"chunking_strategy\"");
            } 
            if (request.TableExtractionConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TableExtractionConfig}"),
                    name: "\"table_extraction_config\"");
            } 
            if (request.Filename != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Filename}"),
                    name: "\"filename\"");
            }
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFileRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFileResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Upload file request was malformed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.BadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.BadRequestError>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Permissions do not allow uploading a file to the corpus.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.Error? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Corpus not found.
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.NotFoundError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.NotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.NotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.NotFoundError>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // The media type of the uploaded file is not supported.
            if ((int)__response.StatusCode == 415)
            {
                string? __content_415 = null;
                global::System.Exception? __exception_415 = null;
                global::G.Error? __value_415 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_415 = global::G.Error.FromJson(__content_415, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_415 = global::G.Error.FromJson(__content_415, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_415 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_415 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_415,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_415,
                    ResponseObject = __value_415,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessFileResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Document.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.Document.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::G.Document> FileAsync(
            string corpusKey,
            byte[] file,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            object? metadata = default,
            global::G.ChunkingStrategy? chunkingStrategy = default,
            global::G.TableExtractionConfig? tableExtractionConfig = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UploadFileRequest
            {
                Metadata = metadata,
                ChunkingStrategy = chunkingStrategy,
                TableExtractionConfig = tableExtractionConfig,
                Filename = filename,
                File = file,
            };

            return await FileAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}