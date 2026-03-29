//HintName: G.Models.MarkdownResultPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkdownResultPage
    {
        /// <summary>
        /// Page number of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNumber { get; set; }

        /// <summary>
        /// Markdown content of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Header of the page in markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        public string? Header { get; set; }

        /// <summary>
        /// Footer of the page in markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("footer")]
        public string? Footer { get; set; }

        /// <summary>
        /// Success indicator
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownResultPage" /> class.
        /// </summary>
        /// <param name="pageNumber">
        /// Page number of the document
        /// </param>
        /// <param name="markdown">
        /// Markdown content of the page
        /// </param>
        /// <param name="header">
        /// Header of the page in markdown
        /// </param>
        /// <param name="footer">
        /// Footer of the page in markdown
        /// </param>
        /// <param name="success">
        /// Success indicator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkdownResultPage(
            int pageNumber,
            string markdown,
            string? header,
            string? footer,
            bool success = true)
        {
            this.PageNumber = pageNumber;
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
            this.Header = header;
            this.Footer = footer;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownResultPage" /> class.
        /// </summary>
        public MarkdownResultPage()
        {
        }
    }
}