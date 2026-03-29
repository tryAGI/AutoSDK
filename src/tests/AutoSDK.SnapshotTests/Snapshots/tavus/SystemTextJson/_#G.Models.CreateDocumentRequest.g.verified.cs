//HintName: G.Models.CreateDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDocumentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_name")]
        public string? DocumentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        public string? DocumentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl")]
        public global::G.CrawlConfig? Crawl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequest" /> class.
        /// </summary>
        /// <param name="documentName"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="documentUrl"></param>
        /// <param name="tags"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="crawl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDocumentRequest(
            string? documentName,
            byte[]? file,
            string? filename,
            string? documentUrl,
            global::System.Collections.Generic.IList<string>? tags,
            string? callbackUrl,
            global::G.CrawlConfig? crawl)
        {
            this.DocumentName = documentName;
            this.File = file;
            this.Filename = filename;
            this.DocumentUrl = documentUrl;
            this.Tags = tags;
            this.CallbackUrl = callbackUrl;
            this.Crawl = crawl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequest" /> class.
        /// </summary>
        public CreateDocumentRequest()
        {
        }
    }
}