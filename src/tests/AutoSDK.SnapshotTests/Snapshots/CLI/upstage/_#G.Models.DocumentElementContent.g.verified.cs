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
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Markdown representation of the element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Plain text representation of the element.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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