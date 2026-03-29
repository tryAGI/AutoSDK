//HintName: G.Models.LlamaParseInputOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Input format-specific parsing options.<br/>
    /// These options only apply when parsing documents of the corresponding format.<br/>
    /// LlamaParse automatically detects the input format based on file extension and content.
    /// </summary>
    public sealed partial class LlamaParseInputOptions
    {
        /// <summary>
        /// HTML/web page parsing options (applies to .html, .htm files)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public global::G.LlamaParseHtmlOptions? Html { get; set; }

        /// <summary>
        /// PDF-specific parsing options (applies to .pdf files)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf")]
        public global::G.LlamaParsePdfOptions? Pdf { get; set; }

        /// <summary>
        /// Spreadsheet parsing options (applies to .xlsx, .xls, .csv, .ods files)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet")]
        public global::G.LlamaParseSpreadsheetOptions? Spreadsheet { get; set; }

        /// <summary>
        /// Presentation parsing options (applies to .pptx, .ppt, .odp, .key files)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        public global::G.LlamaParsePresentationOptions? Presentation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseInputOptions" /> class.
        /// </summary>
        /// <param name="html">
        /// HTML/web page parsing options (applies to .html, .htm files)
        /// </param>
        /// <param name="pdf">
        /// PDF-specific parsing options (applies to .pdf files)
        /// </param>
        /// <param name="spreadsheet">
        /// Spreadsheet parsing options (applies to .xlsx, .xls, .csv, .ods files)
        /// </param>
        /// <param name="presentation">
        /// Presentation parsing options (applies to .pptx, .ppt, .odp, .key files)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseInputOptions(
            global::G.LlamaParseHtmlOptions? html,
            global::G.LlamaParsePdfOptions? pdf,
            global::G.LlamaParseSpreadsheetOptions? spreadsheet,
            global::G.LlamaParsePresentationOptions? presentation)
        {
            this.Html = html;
            this.Pdf = pdf;
            this.Spreadsheet = spreadsheet;
            this.Presentation = presentation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseInputOptions" /> class.
        /// </summary>
        public LlamaParseInputOptions()
        {
        }
    }
}