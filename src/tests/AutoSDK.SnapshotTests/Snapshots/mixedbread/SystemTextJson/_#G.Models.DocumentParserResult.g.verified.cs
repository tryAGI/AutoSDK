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
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChunkingStrategyJsonConverter))]
        public global::G.ChunkingStrategy ChunkingStrategy { get; set; }

        /// <summary>
        /// The format of the returned content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReturnFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReturnFormat ReturnFormat { get; set; }

        /// <summary>
        /// The types of elements extracted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("element_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ElementType> ElementTypes { get; set; }

        /// <summary>
        /// List of extracted chunks from the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Chunk> Chunks { get; set; }

        /// <summary>
        /// List of (width, height) tuples for each page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_sizes")]
        public global::System.Collections.Generic.IList<byte[]>? PageSizes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentParserResult(
            global::G.ReturnFormat returnFormat,
            global::System.Collections.Generic.IList<global::G.ElementType> elementTypes,
            global::System.Collections.Generic.IList<global::G.Chunk> chunks,
            global::G.ChunkingStrategy chunkingStrategy,
            global::System.Collections.Generic.IList<byte[]>? pageSizes)
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