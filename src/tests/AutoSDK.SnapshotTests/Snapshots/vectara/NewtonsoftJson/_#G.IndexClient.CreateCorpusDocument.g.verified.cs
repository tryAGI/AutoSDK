//HintName: G.IndexClient.CreateCorpusDocument.g.cs

#nullable enable

namespace G
{
    public partial class IndexClient
    {
        partial void PrepareCreateCorpusDocumentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string corpusKey,
            ref global::G.CreateCorpusDocumentWaitFor? waitFor,
            global::G.CreateDocumentRequest request);
        partial void PrepareCreateCorpusDocumentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string corpusKey,
            global::G.CreateCorpusDocumentWaitFor? waitFor,
            global::G.CreateDocumentRequest request);
        partial void ProcessCreateCorpusDocumentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateCorpusDocumentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);


        /// <summary>
        /// Add a document to a corpus<br/>
        /// Add a document to a corpus for indexing, making its content available for search, retrieval, and generation. This endpoint supports two ingestion modes: **structured** documents and **core** documents. These modes offer different levels of control over document structure and chunking.<br/>
        /// Each document becomes part of a corpus. You can use this API directly or with [Vectara Ingest](https://github.com/vectara/vectara-ingest) or the [File Upload API](/docs/rest-api/upload-file).<br/>
        /// ## Structured documents<br/>
        /// Structured documents provide a natural hierarchy where Vectar handles chunking and metadata automatically. Structured documents are ideal when you want to index documents that have logical organization (titles, sections, paragraphs, and optionally tables or images) but prefer Vectara to manage how the content is split into search-optimized units.<br/>
        /// Each structured document contains:<br/>
        /// - A unique `id` and optional `title`, `description`, and `metadata`.<br/>
        /// - An array of `sections`, each with its own title, text, and optional nested sections, tables, or images.<br/>
        /// - Optional `custom_dimensions` that can influence ranking during search.<br/>
        /// When indexed, Vectara partitions the text into document parts automatically using an intelligent sentence- or character-based chunking strategy. This lets you ingest data with minimal pre-processing while maintaining semantic integrity across context boundaries.<br/>
        /// Structured documents are recommended for content with well-defined sections such as reports, articles, FAQs, or documentation.<br/>
        /// ## Core documents<br/>
        /// Core documents offer fine-grained, explicit control of every part of a document that becomes searchable. Instead of providing a hierarchical structure, you specify each **document part** directly as unit that maps 1:1 to a search result or embedding.<br/>
        /// A core document includes:<br/>
        /// - A unique `id` and optional `metadata`.<br/>
        /// - A list of `document_parts`, where each part includes `text`, optional `context`, `metadata`, and `custom_dimensions`.<br/>
        /// - Optional `tables` and `images`, allowing you to represent complex structured data like spreadsheets or charts.<br/>
        /// Core documents are designed for advanced use cases such as precise chunk-level optimization or experimental corpus structures, and applications where metadata-driven retrieval or ranking must be explicitly controlled.<br/>
        /// ## Chunking strategies    <br/>
        /// By default, Vectara uses **sentence-based chunking**, which provides optimal retrieval accuracy for most datasets.<br/>
        /// For larger documents or performance-tuned ingestion, you can explicitly set a `chunking_strategy`:<br/>
        /// - `sentence_chunking_strategy` — creates one chunk per sentence (default).<br/>
        /// - `max_chars_chunking_strategy` — creates larger chunks up to a specified character limit (`max_chars_per_chunk`), balancing retrieval speed with contextual coherence.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="waitFor">
        /// Default Value: searchable
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Document> CreateCorpusDocumentAsync(
            string corpusKey,

            global::G.CreateDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.CreateCorpusDocumentWaitFor? waitFor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateCorpusDocumentArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                corpusKey: ref corpusKey,
                waitFor: ref waitFor,
                request: request);

            var waitForValue = waitFor switch
            {
                global::G.CreateCorpusDocumentWaitFor.Searchable => "searchable",
                global::G.CreateCorpusDocumentWaitFor.Indexed => "indexed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/corpora/{corpusKey}/documents",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("wait_for", waitFor?.ToValueString()) 
                ; 
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

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateCorpusDocumentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                waitFor: waitFor,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateCorpusDocumentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Document creation request was malformed.
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
            // Permissions do not allow adding a document to the corpus.
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
            // The document already exists
            if ((int)__response.StatusCode == 409)
            {
                string? __content_409 = null;
                global::System.Exception? __exception_409 = null;
                global::G.Error? __value_409 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_409 = global::G.Error.FromJson(__content_409, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_409 = global::G.Error.FromJson(__content_409, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_409 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_409,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_409,
                    ResponseObject = __value_409,
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
                ProcessCreateCorpusDocumentResponseContent(
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
        /// Add a document to a corpus<br/>
        /// Add a document to a corpus for indexing, making its content available for search, retrieval, and generation. This endpoint supports two ingestion modes: **structured** documents and **core** documents. These modes offer different levels of control over document structure and chunking.<br/>
        /// Each document becomes part of a corpus. You can use this API directly or with [Vectara Ingest](https://github.com/vectara/vectara-ingest) or the [File Upload API](/docs/rest-api/upload-file).<br/>
        /// ## Structured documents<br/>
        /// Structured documents provide a natural hierarchy where Vectar handles chunking and metadata automatically. Structured documents are ideal when you want to index documents that have logical organization (titles, sections, paragraphs, and optionally tables or images) but prefer Vectara to manage how the content is split into search-optimized units.<br/>
        /// Each structured document contains:<br/>
        /// - A unique `id` and optional `title`, `description`, and `metadata`.<br/>
        /// - An array of `sections`, each with its own title, text, and optional nested sections, tables, or images.<br/>
        /// - Optional `custom_dimensions` that can influence ranking during search.<br/>
        /// When indexed, Vectara partitions the text into document parts automatically using an intelligent sentence- or character-based chunking strategy. This lets you ingest data with minimal pre-processing while maintaining semantic integrity across context boundaries.<br/>
        /// Structured documents are recommended for content with well-defined sections such as reports, articles, FAQs, or documentation.<br/>
        /// ## Core documents<br/>
        /// Core documents offer fine-grained, explicit control of every part of a document that becomes searchable. Instead of providing a hierarchical structure, you specify each **document part** directly as unit that maps 1:1 to a search result or embedding.<br/>
        /// A core document includes:<br/>
        /// - A unique `id` and optional `metadata`.<br/>
        /// - A list of `document_parts`, where each part includes `text`, optional `context`, `metadata`, and `custom_dimensions`.<br/>
        /// - Optional `tables` and `images`, allowing you to represent complex structured data like spreadsheets or charts.<br/>
        /// Core documents are designed for advanced use cases such as precise chunk-level optimization or experimental corpus structures, and applications where metadata-driven retrieval or ranking must be explicitly controlled.<br/>
        /// ## Chunking strategies    <br/>
        /// By default, Vectara uses **sentence-based chunking**, which provides optimal retrieval accuracy for most datasets.<br/>
        /// For larger documents or performance-tuned ingestion, you can explicitly set a `chunking_strategy`:<br/>
        /// - `sentence_chunking_strategy` — creates one chunk per sentence (default).<br/>
        /// - `max_chars_chunking_strategy` — creates larger chunks up to a specified character limit (`max_chars_per_chunk`), balancing retrieval speed with contextual coherence.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="waitFor">
        /// Default Value: searchable
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Document> CreateCorpusDocumentAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.CreateCorpusDocumentWaitFor? waitFor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateDocumentRequest
            {
            };

            return await CreateCorpusDocumentAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                waitFor: waitFor,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}