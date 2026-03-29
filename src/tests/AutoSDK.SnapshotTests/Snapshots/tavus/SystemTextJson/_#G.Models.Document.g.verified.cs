//HintName: G.Models.Document.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_name")]
        public string? DocumentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl")]
        public global::G.CrawlConfig? Crawl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl_count")]
        public int? CrawlCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_crawled_at")]
        public global::System.DateTime? LastCrawledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="documentName"></param>
        /// <param name="status"></param>
        /// <param name="documentUrl"></param>
        /// <param name="tags"></param>
        /// <param name="crawl"></param>
        /// <param name="crawlCount"></param>
        /// <param name="lastCrawledAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Document(
            string? documentId,
            string? documentName,
            string? status,
            string? documentUrl,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.CrawlConfig? crawl,
            int? crawlCount,
            global::System.DateTime? lastCrawledAt,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.DocumentId = documentId;
            this.DocumentName = documentName;
            this.Status = status;
            this.DocumentUrl = documentUrl;
            this.Tags = tags;
            this.Crawl = crawl;
            this.CrawlCount = crawlCount;
            this.LastCrawledAt = lastCrawledAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        public Document()
        {
        }
    }
}