//HintName: G.Models.CrawlStatusResponseObj.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlStatusResponseObj
    {
        /// <summary>
        /// The current status of the crawl. Can be `scraping`, `completed`, or `failed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The total number of pages that were attempted to be crawled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// The number of pages that have been successfully crawled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public int? Completed { get; set; }

        /// <summary>
        /// The number of credits used for the crawl.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditsUsed")]
        public int? CreditsUsed { get; set; }

        /// <summary>
        /// The date and time when the crawl will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The URL to retrieve the next 10MB of data. Returned if the crawl is not completed or if the response is larger than 10MB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The data of the crawl.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.CrawlStatusResponseObjDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlStatusResponseObj" /> class.
        /// </summary>
        /// <param name="status">
        /// The current status of the crawl. Can be `scraping`, `completed`, or `failed`.
        /// </param>
        /// <param name="total">
        /// The total number of pages that were attempted to be crawled.
        /// </param>
        /// <param name="completed">
        /// The number of pages that have been successfully crawled.
        /// </param>
        /// <param name="creditsUsed">
        /// The number of credits used for the crawl.
        /// </param>
        /// <param name="expiresAt">
        /// The date and time when the crawl will expire.
        /// </param>
        /// <param name="next">
        /// The URL to retrieve the next 10MB of data. Returned if the crawl is not completed or if the response is larger than 10MB.
        /// </param>
        /// <param name="data">
        /// The data of the crawl.
        /// </param>
        public CrawlStatusResponseObj(
            string? status,
            int? total,
            int? completed,
            int? creditsUsed,
            global::System.DateTime? expiresAt,
            string? next,
            global::System.Collections.Generic.IList<global::G.CrawlStatusResponseObjDataItem>? data)
        {
            this.Status = status;
            this.Total = total;
            this.Completed = completed;
            this.CreditsUsed = creditsUsed;
            this.ExpiresAt = expiresAt;
            this.Next = next;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlStatusResponseObj" /> class.
        /// </summary>
        public CrawlStatusResponseObj()
        {
        }
    }
}