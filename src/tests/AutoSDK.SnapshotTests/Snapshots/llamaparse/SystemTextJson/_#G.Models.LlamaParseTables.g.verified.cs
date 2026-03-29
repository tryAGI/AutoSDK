//HintName: G.Models.LlamaParseTables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Table formatting options for markdown output.
    /// </summary>
    public sealed partial class LlamaParseTables
    {
        /// <summary>
        /// Remove extra whitespace padding in markdown table cells for more compact output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_markdown_tables")]
        public bool? CompactMarkdownTables { get; set; }

        /// <summary>
        /// Output tables as markdown pipe tables instead of HTML &lt;table&gt; tags. Markdown tables are simpler but cannot represent complex structures like merged cells
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tables_as_markdown")]
        public bool? OutputTablesAsMarkdown { get; set; }

        /// <summary>
        /// Separator string for multiline cell content in markdown tables. Example: '' to preserve line breaks, ' ' to join with spaces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_table_multiline_separator")]
        public string? MarkdownTableMultilineSeparator { get; set; }

        /// <summary>
        /// Automatically merge tables that span multiple pages into a single table. The merged table appears on the first page with merged_from_pages metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_continued_tables")]
        public bool? MergeContinuedTables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseTables" /> class.
        /// </summary>
        /// <param name="compactMarkdownTables">
        /// Remove extra whitespace padding in markdown table cells for more compact output
        /// </param>
        /// <param name="outputTablesAsMarkdown">
        /// Output tables as markdown pipe tables instead of HTML &lt;table&gt; tags. Markdown tables are simpler but cannot represent complex structures like merged cells
        /// </param>
        /// <param name="markdownTableMultilineSeparator">
        /// Separator string for multiline cell content in markdown tables. Example: '' to preserve line breaks, ' ' to join with spaces
        /// </param>
        /// <param name="mergeContinuedTables">
        /// Automatically merge tables that span multiple pages into a single table. The merged table appears on the first page with merged_from_pages metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseTables(
            bool? compactMarkdownTables,
            bool? outputTablesAsMarkdown,
            string? markdownTableMultilineSeparator,
            bool? mergeContinuedTables)
        {
            this.CompactMarkdownTables = compactMarkdownTables;
            this.OutputTablesAsMarkdown = outputTablesAsMarkdown;
            this.MarkdownTableMultilineSeparator = markdownTableMultilineSeparator;
            this.MergeContinuedTables = mergeContinuedTables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseTables" /> class.
        /// </summary>
        public LlamaParseTables()
        {
        }
    }
}