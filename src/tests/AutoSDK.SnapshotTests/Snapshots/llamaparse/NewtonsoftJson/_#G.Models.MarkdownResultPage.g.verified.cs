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
        [global::Newtonsoft.Json.JsonProperty("page_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageNumber { get; set; } = default!;

        /// <summary>
        /// Markdown content of the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown", Required = global::Newtonsoft.Json.Required.Always)]
        public string Markdown { get; set; } = default!;

        /// <summary>
        /// Header of the page in markdown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("header")]
        public string? Header { get; set; }

        /// <summary>
        /// Footer of the page in markdown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("footer")]
        public string? Footer { get; set; }

        /// <summary>
        /// Success indicator
        /// </summary>
        /// <default>true</default>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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