//HintName: G.IDocuments2Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IDocuments2Client
    {
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
        global::System.Threading.Tasks.Task<global::G.Document> CreateAsync(
            string corpusKey,

            global::G.CreateDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.CreateCorpusDocumentWaitFor? waitFor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::G.Document> CreateAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.CreateCorpusDocumentWaitFor? waitFor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}