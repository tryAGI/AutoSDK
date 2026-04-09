//HintName: G.Models.DocumentParserResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of document parsing operation.
    /// </summary>
    public sealed partial class DocumentParserResult
    {
        /// <summary>
        /// The strategy used for chunking the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunking_strategy")]
        public global::G.ChunkingStrategy ChunkingStrategy { get; set; }

        /// <summary>
        /// The format of the returned content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReturnFormat ReturnFormat { get; set; } = default!;

        /// <summary>
        /// The types of elements extracted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("element_types", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ElementType> ElementTypes { get; set; } = default!;

        /// <summary>
        /// List of extracted chunks from the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Chunk> Chunks { get; set; } = default!;

        /// <summary>
        /// List of (width, height) tuples for each page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_sizes")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? PageSizes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParserResult" /> class.
        /// </summary>
        /// <param name="returnFormat">
        /// The format of the returned content
        /// </param>
        /// <param name="elementTypes">
        /// The types of elements extracted
        /// </param>
        /// <param name="chunks">
        /// List of extracted chunks from the document
        /// </param>
        /// <param name="chunkingStrategy">
        /// The strategy used for chunking the document
        /// </param>
        /// <param name="pageSizes">
        /// List of (width, height) tuples for each page
        /// </param>
        public DocumentParserResult(
            global::G.ReturnFormat returnFormat,
            global::System.Collections.Generic.IList<global::G.ElementType> elementTypes,
            global::System.Collections.Generic.IList<global::G.Chunk> chunks,
            global::G.ChunkingStrategy chunkingStrategy,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? pageSizes)
        {
            this.ChunkingStrategy = chunkingStrategy;
            this.ReturnFormat = returnFormat;
            this.ElementTypes = elementTypes ?? throw new global::System.ArgumentNullException(nameof(elementTypes));
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
            this.PageSizes = pageSizes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParserResult" /> class.
        /// </summary>
        public DocumentParserResult()
        {
        }
    }
}