//HintName: G.Models.HierarchicalChunkerOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for the HierarchicalChunker.
    /// </summary>
    public sealed partial class HierarchicalChunkerOptions
    {
        /// <summary>
        /// Default Value: hierarchical
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker")]
        public string? Chunker { get; set; }

        /// <summary>
        /// Use markdown table format instead of triplets for table serialization.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_markdown_tables")]
        public bool? UseMarkdownTables { get; set; }

        /// <summary>
        /// Include both raw_text and text (contextualized) in response. If False, only text is included.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_raw_text")]
        public bool? IncludeRawText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchicalChunkerOptions" /> class.
        /// </summary>
        /// <param name="chunker">
        /// Default Value: hierarchical
        /// </param>
        /// <param name="useMarkdownTables">
        /// Use markdown table format instead of triplets for table serialization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRawText">
        /// Include both raw_text and text (contextualized) in response. If False, only text is included.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HierarchicalChunkerOptions(
            string? chunker,
            bool? useMarkdownTables,
            bool? includeRawText)
        {
            this.Chunker = chunker;
            this.UseMarkdownTables = useMarkdownTables;
            this.IncludeRawText = includeRawText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchicalChunkerOptions" /> class.
        /// </summary>
        public HierarchicalChunkerOptions()
        {
        }
    }
}