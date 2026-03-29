//HintName: G.Models.CrawlUrlsRequestWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A webhook specification object.
    /// </summary>
    public sealed partial class CrawlUrlsRequestWebhook
    {
        /// <summary>
        /// The URL to send the webhook to. This will trigger for crawl started (crawl.started), every page crawled (crawl.page) and when the crawl is completed (crawl.completed or crawl.failed). The response will be the same as the `/scrape` endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Headers to send to the webhook URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Custom metadata that will be included in all webhook payloads for this crawl
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Type of events that should be sent to the webhook URL. (default: all)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.CrawlUrlsRequestWebhookEvent>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlUrlsRequestWebhook" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to send the webhook to. This will trigger for crawl started (crawl.started), every page crawled (crawl.page) and when the crawl is completed (crawl.completed or crawl.failed). The response will be the same as the `/scrape` endpoint.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrawlUrlsRequestWebhook(
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? metadata,
            global::System.Collections.Generic.IList<global::G.CrawlUrlsRequestWebhookEvent>? events)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Metadata = metadata;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlUrlsRequestWebhook" /> class.
        /// </summary>
        public CrawlUrlsRequestWebhook()
        {
        }
    }
}