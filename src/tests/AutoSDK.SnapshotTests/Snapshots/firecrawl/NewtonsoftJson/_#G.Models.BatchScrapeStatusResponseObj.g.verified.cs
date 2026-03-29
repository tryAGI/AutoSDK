//HintName: G.Models.BatchScrapeStatusResponseObj.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchScrapeStatusResponseObj
    {
        /// <summary>
        /// The current status of the batch scrape. Can be `scraping`, `completed`, or `failed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The total number of pages that were attempted to be scraped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// The number of pages that have been successfully scraped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public int? Completed { get; set; }

        /// <summary>
        /// The number of credits used for the batch scrape.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditsUsed")]
        public int? CreditsUsed { get; set; }

        /// <summary>
        /// The date and time when the batch scrape will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The URL to retrieve the next 10MB of data. Returned if the batch scrape is not completed or if the response is larger than 10MB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The data of the batch scrape.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.BatchScrapeStatusResponseObjDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchScrapeStatusResponseObj" /> class.
        /// </summary>
        /// <param name="status">
        /// The current status of the batch scrape. Can be `scraping`, `completed`, or `failed`.
        /// </param>
        /// <param name="total">
        /// The total number of pages that were attempted to be scraped.
        /// </param>
        /// <param name="completed">
        /// The number of pages that have been successfully scraped.
        /// </param>
        /// <param name="creditsUsed">
        /// The number of credits used for the batch scrape.
        /// </param>
        /// <param name="expiresAt">
        /// The date and time when the batch scrape will expire.
        /// </param>
        /// <param name="next">
        /// The URL to retrieve the next 10MB of data. Returned if the batch scrape is not completed or if the response is larger than 10MB.
        /// </param>
        /// <param name="data">
        /// The data of the batch scrape.
        /// </param>
        public BatchScrapeStatusResponseObj(
            string? status,
            int? total,
            int? completed,
            int? creditsUsed,
            global::System.DateTime? expiresAt,
            string? next,
            global::System.Collections.Generic.IList<global::G.BatchScrapeStatusResponseObjDataItem>? data)
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
        /// Initializes a new instance of the <see cref="BatchScrapeStatusResponseObj" /> class.
        /// </summary>
        public BatchScrapeStatusResponseObj()
        {
        }
    }
}