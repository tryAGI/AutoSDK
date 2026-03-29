//HintName: G.Models.DocumentElementContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content of the element.
    /// </summary>
    public sealed partial class DocumentElementContent
    {
        /// <summary>
        /// HTML representation of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Markdown representation of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Plain text representation of the element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentElementContent" /> class.
        /// </summary>
        /// <param name="html">
        /// HTML representation of the element.
        /// </param>
        /// <param name="markdown">
        /// Markdown representation of the element.
        /// </param>
        /// <param name="text">
        /// Plain text representation of the element.
        /// </param>
        public DocumentElementContent(
            string? html,
            string? markdown,
            string? text)
        {
            this.Html = html;
            this.Markdown = markdown;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentElementContent" /> class.
        /// </summary>
        public DocumentElementContent()
        {
        }
    }
}