//HintName: G.Models.ScrapeAndExtractFromUrlsRequestWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A webhook specification object.
    /// </summary>
    public sealed partial class ScrapeAndExtractFromUrlsRequestWebhook
    {
        /// <summary>
        /// The URL to send the webhook to. This will trigger for batch scrape started (batch_scrape.started), every page scraped (batch_scrape.page) and when the batch scrape is completed (batch_scrape.completed or batch_scrape.failed). The response will be the same as the `/scrape` endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Headers to send to the webhook URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Custom metadata that will be included in all webhook payloads for this crawl
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Type of events that should be sent to the webhook URL. (default: all)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.ScrapeAndExtractFromUrlsRequestWebhookEvent>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeAndExtractFromUrlsRequestWebhook" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to send the webhook to. This will trigger for batch scrape started (batch_scrape.started), every page scraped (batch_scrape.page) and when the batch scrape is completed (batch_scrape.completed or batch_scrape.failed). The response will be the same as the `/scrape` endpoint.
        /// </param>
        /// <param name="headers">
        /// Headers to send to the webhook URL.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata that will be included in all webhook payloads for this crawl
        /// </param>
        /// <param name="events">
        /// Type of events that should be sent to the webhook URL. (default: all)
        /// </param>
        public ScrapeAndExtractFromUrlsRequestWebhook(
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? metadata,
            global::System.Collections.Generic.IList<global::G.ScrapeAndExtractFromUrlsRequestWebhookEvent>? events)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Metadata = metadata;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeAndExtractFromUrlsRequestWebhook" /> class.
        /// </summary>
        public ScrapeAndExtractFromUrlsRequestWebhook()
        {
        }
    }
}