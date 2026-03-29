//HintName: G.Models.LlamaParseOutputOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output formatting and content extraction options.<br/>
    /// Controls how parsed content is formatted and what additional data is extracted.
    /// </summary>
    public sealed partial class LlamaParseOutputOptions
    {
        /// <summary>
        /// Markdown formatting options including table styles and link annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public global::G.LlamaParseMarkdownOptions? Markdown { get; set; }

        /// <summary>
        /// Spatial text output options for preserving document layout structure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spatial_text")]
        public global::G.LlamaParseSpatialTextOptions? SpatialText { get; set; }

        /// <summary>
        /// Options for exporting tables as XLSX spreadsheets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables_as_spreadsheet")]
        public global::G.LlamaParseTablesAsSpreadsheetOptions? TablesAsSpreadsheet { get; set; }

        /// <summary>
        /// Extract the printed page number as it appears in the document (e.g., 'Page 5 of 10', 'v', 'A-3'). Useful for referencing original page numbers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_printed_page_number")]
        public bool? ExtractPrintedPageNumber { get; set; }

        /// <summary>
        /// Image categories to extract and save. Options: 'screenshot' (full page renders useful for visual QA), 'embedded' (images found within the document), 'layout' (cropped regions from layout detection like figures and diagrams). Empty list saves no images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images_to_save")]
        public global::System.Collections.Generic.IList<global::G.LlamaParseOutputOptionsImagesToSaveItem>? ImagesToSave { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseOutputOptions" /> class.
        /// </summary>
        /// <param name="markdown">
        /// Markdown formatting options including table styles and link annotations
        /// </param>
        /// <param name="spatialText">
        /// Spatial text output options for preserving document layout structure
        /// </param>
        /// <param name="tablesAsSpreadsheet">
        /// Options for exporting tables as XLSX spreadsheets
        /// </param>
        /// <param name="extractPrintedPageNumber">
        /// Extract the printed page number as it appears in the document (e.g., 'Page 5 of 10', 'v', 'A-3'). Useful for referencing original page numbers
        /// </param>
        /// <param name="imagesToSave">
        /// Image categories to extract and save. Options: 'screenshot' (full page renders useful for visual QA), 'embedded' (images found within the document), 'layout' (cropped regions from layout detection like figures and diagrams). Empty list saves no images
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseOutputOptions(
            global::G.LlamaParseMarkdownOptions? markdown,
            global::G.LlamaParseSpatialTextOptions? spatialText,
            global::G.LlamaParseTablesAsSpreadsheetOptions? tablesAsSpreadsheet,
            bool? extractPrintedPageNumber,
            global::System.Collections.Generic.IList<global::G.LlamaParseOutputOptionsImagesToSaveItem>? imagesToSave)
        {
            this.Markdown = markdown;
            this.SpatialText = spatialText;
            this.TablesAsSpreadsheet = tablesAsSpreadsheet;
            this.ExtractPrintedPageNumber = extractPrintedPageNumber;
            this.ImagesToSave = imagesToSave;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseOutputOptions" /> class.
        /// </summary>
        public LlamaParseOutputOptions()
        {
        }
    }
}