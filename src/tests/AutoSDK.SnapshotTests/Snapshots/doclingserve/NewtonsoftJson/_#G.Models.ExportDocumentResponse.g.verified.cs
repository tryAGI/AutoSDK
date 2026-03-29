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
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md_content")]
        public string? MdContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_content")]
        public global::G.DoclingDocument? JsonContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_content")]
        public string? HtmlContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_content")]
        public string? TextContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("doctags_content")]
        public string? DoctagsContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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