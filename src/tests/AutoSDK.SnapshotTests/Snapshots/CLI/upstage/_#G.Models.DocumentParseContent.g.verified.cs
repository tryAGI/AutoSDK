//HintName: G.Models.DocumentParseContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentParseContent
    {
        /// <summary>
        /// The parsed document content in HTML format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// The parsed document content in Markdown format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// The parsed document content in plain text format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Individual elements extracted from the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::G.DocumentElement>? Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParseContent" /> class.
        /// </summary>
        /// <param name="html">
        /// The parsed document content in HTML format.
        /// </param>
        /// <param name="markdown">
        /// The parsed document content in Markdown format.
        /// </param>
        /// <param name="text">
        /// The parsed document content in plain text format.
        /// </param>
        /// <param name="elements">
        /// Individual elements extracted from the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentParseContent(
            string? html,
            string? markdown,
            string? text,
            global::System.Collections.Generic.IList<global::G.DocumentElement>? elements)
        {
            this.Html = html;
            this.Markdown = markdown;
            this.Text = text;
            this.Elements = elements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParseContent" /> class.
        /// </summary>
        public DocumentParseContent()
        {
        }
    }
}