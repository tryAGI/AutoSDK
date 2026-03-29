//HintName: G.Models.BatchScrapeStatusResponseObjDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchScrapeStatusResponseObjDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// HTML version of the content on page if `includeHtml`  is true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Raw HTML content of the page if `includeRawHtml`  is true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rawHtml")]
        public string? RawHtml { get; set; }

        /// <summary>
        /// List of links on the page if `includeLinks` is true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::System.Collections.Generic.IList<string>? Links { get; set; }

        /// <summary>
        /// Screenshot of the page if `includeScreenshot` is true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("screenshot")]
        public string? Screenshot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.BatchScrapeStatusResponseObjDataItemMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchScrapeStatusResponseObjDataItem" /> class.
        /// </summary>
        /// <param name="markdown"></param>
        /// <param name="html">
        /// HTML version of the content on page if `includeHtml`  is true
        /// </param>
        /// <param name="rawHtml">
        /// Raw HTML content of the page if `includeRawHtml`  is true
        /// </param>
        /// <param name="links">
        /// List of links on the page if `includeLinks` is true
        /// </param>
        /// <param name="screenshot">
        /// Screenshot of the page if `includeScreenshot` is true
        /// </param>
        /// <param name="metadata"></param>
        public BatchScrapeStatusResponseObjDataItem(
            string? markdown,
            string? html,
            string? rawHtml,
            global::System.Collections.Generic.IList<string>? links,
            string? screenshot,
            global::G.BatchScrapeStatusResponseObjDataItemMetadata? metadata)
        {
            this.Markdown = markdown;
            this.Html = html;
            this.RawHtml = rawHtml;
            this.Links = links;
            this.Screenshot = screenshot;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchScrapeStatusResponseObjDataItem" /> class.
        /// </summary>
        public BatchScrapeStatusResponseObjDataItem()
        {
        }
    }
}