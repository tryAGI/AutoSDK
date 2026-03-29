//HintName: G.Models.RecrawlDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecrawlDocumentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crawl")]
        public global::G.CrawlConfig? Crawl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecrawlDocumentRequest" /> class.
        /// </summary>
        /// <param name="crawl"></param>
        public RecrawlDocumentRequest(
            global::G.CrawlConfig? crawl)
        {
            this.Crawl = crawl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecrawlDocumentRequest" /> class.
        /// </summary>
        public RecrawlDocumentRequest()
        {
        }
    }
}