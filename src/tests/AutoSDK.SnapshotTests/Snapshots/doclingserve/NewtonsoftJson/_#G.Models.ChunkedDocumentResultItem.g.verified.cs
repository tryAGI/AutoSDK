//HintName: G.Models.ChunkedDocumentResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single chunk of a document with its metadata and content.
    /// </summary>
    public sealed partial class ChunkedDocumentResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkIndex { get; set; } = default!;

        /// <summary>
        /// The chunk text with structural context (headers, formatting)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Raw chunk text without additional formatting or context
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_text")]
        public string? RawText { get; set; }

        /// <summary>
        /// Number of tokens in the text, if the chunker is aware of tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens")]
        public int? NumTokens { get; set; }

        /// <summary>
        /// List of headings for this chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headings")]
        public global::System.Collections.Generic.IList<string>? Headings { get; set; }

        /// <summary>
        /// List of captions for this chunk (e.g. for pictures and tables)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("captions")]
        public global::System.Collections.Generic.IList<string>? Captions { get; set; }

        /// <summary>
        /// List of doc items references
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("doc_items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DocItems { get; set; } = default!;

        /// <summary>
        /// Page numbers where this chunk content appears
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_numbers")]
        public global::System.Collections.Generic.IList<int>? PageNumbers { get; set; }

        /// <summary>
        /// Additional metadata associated with this chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedDocumentResultItem" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="chunkIndex"></param>
        /// <param name="text">
        /// The chunk text with structural context (headers, formatting)
        /// </param>
        /// <param name="docItems">
        /// List of doc items references
        /// </param>
        /// <param name="rawText">
        /// Raw chunk text without additional formatting or context
        /// </param>
        /// <param name="numTokens">
        /// Number of tokens in the text, if the chunker is aware of tokens
        /// </param>
        /// <param name="headings">
        /// List of headings for this chunk
        /// </param>
        /// <param name="captions">
        /// List of captions for this chunk (e.g. for pictures and tables)
        /// </param>
        /// <param name="pageNumbers">
        /// Page numbers where this chunk content appears
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with this chunk
        /// </param>
        public ChunkedDocumentResultItem(
            string filename,
            int chunkIndex,
            string text,
            global::System.Collections.Generic.IList<string> docItems,
            string? rawText,
            int? numTokens,
            global::System.Collections.Generic.IList<string>? headings,
            global::System.Collections.Generic.IList<string>? captions,
            global::System.Collections.Generic.IList<int>? pageNumbers,
            object? metadata)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ChunkIndex = chunkIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.RawText = rawText;
            this.NumTokens = numTokens;
            this.Headings = headings;
            this.Captions = captions;
            this.DocItems = docItems ?? throw new global::System.ArgumentNullException(nameof(docItems));
            this.PageNumbers = pageNumbers;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedDocumentResultItem" /> class.
        /// </summary>
        public ChunkedDocumentResultItem()
        {
        }
    }
}