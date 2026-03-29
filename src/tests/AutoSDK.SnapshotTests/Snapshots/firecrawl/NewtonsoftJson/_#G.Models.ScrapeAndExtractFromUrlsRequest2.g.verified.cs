//HintName: G.Models.ScrapeAndExtractFromUrlsRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeAndExtractFromUrlsRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Urls { get; set; } = default!;

        /// <summary>
        /// A webhook specification object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public global::G.ScrapeAndExtractFromUrlsRequestWebhook? Webhook { get; set; }

        /// <summary>
        /// If invalid URLs are specified in the urls array, they will be ignored. Instead of them failing the entire request, a batch scrape using the remaining valid URLs will be created, and the invalid URLs will be returned in the invalidURLs field of the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignoreInvalidURLs")]
        public bool? IgnoreInvalidURLs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeAndExtractFromUrlsRequest2" /> class.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="webhook">
        /// A webhook specification object.
        /// </param>
        /// <param name="ignoreInvalidURLs">
        /// If invalid URLs are specified in the urls array, they will be ignored. Instead of them failing the entire request, a batch scrape using the remaining valid URLs will be created, and the invalid URLs will be returned in the invalidURLs field of the response.<br/>
        /// Default Value: false
        /// </param>
        public ScrapeAndExtractFromUrlsRequest2(
            global::System.Collections.Generic.IList<string> urls,
            global::G.ScrapeAndExtractFromUrlsRequestWebhook? webhook,
            bool? ignoreInvalidURLs)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.Webhook = webhook;
            this.IgnoreInvalidURLs = ignoreInvalidURLs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeAndExtractFromUrlsRequest2" /> class.
        /// </summary>
        public ScrapeAndExtractFromUrlsRequest2()
        {
        }
    }
}