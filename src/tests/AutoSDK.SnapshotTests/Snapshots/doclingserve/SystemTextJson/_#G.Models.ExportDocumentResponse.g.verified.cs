//HintName: G.Models.ExportDocumentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportDocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md_content")]
        public string? MdContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_content")]
        public global::G.DoclingDocument? JsonContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_content")]
        public string? HtmlContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_content")]
        public string? TextContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doctags_content")]
        public string? DoctagsContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDocumentResponse" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="mdContent"></param>
        /// <param name="jsonContent"></param>
        /// <param name="htmlContent"></param>
        /// <param name="textContent"></param>
        /// <param name="doctagsContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportDocumentResponse(
            string filename,
            string? mdContent,
            global::G.DoclingDocument? jsonContent,
            string? htmlContent,
            string? textContent,
            string? doctagsContent)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.MdContent = mdContent;
            this.JsonContent = jsonContent;
            this.HtmlContent = htmlContent;
            this.TextContent = textContent;
            this.DoctagsContent = doctagsContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDocumentResponse" /> class.
        /// </summary>
        public ExportDocumentResponse()
        {
        }
    }
}