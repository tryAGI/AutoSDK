//HintName: G.Models.ScrapeResponseDataActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results of the actions specified in the `actions` parameter. Only present if the `actions` parameter was provided in the request
    /// </summary>
    public sealed partial class ScrapeResponseDataActions
    {
        /// <summary>
        /// Screenshot URLs, in the same order as the screenshot actions provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("screenshots")]
        public global::System.Collections.Generic.IList<string>? Screenshots { get; set; }

        /// <summary>
        /// Scrape contents, in the same order as the scrape actions provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scrapes")]
        public global::System.Collections.Generic.IList<global::G.ScrapeResponseDataActionsScrape>? Scrapes { get; set; }

        /// <summary>
        /// JavaScript return values, in the same order as the executeJavascript actions provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("javascriptReturns")]
        public global::System.Collections.Generic.IList<global::G.ScrapeResponseDataActionsJavascriptReturn>? JavascriptReturns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataActions" /> class.
        /// </summary>
        /// <param name="screenshots">
        /// Screenshot URLs, in the same order as the screenshot actions provided.
        /// </param>
        /// <param name="scrapes">
        /// Scrape contents, in the same order as the scrape actions provided.
        /// </param>
        /// <param name="javascriptReturns">
        /// JavaScript return values, in the same order as the executeJavascript actions provided.
        /// </param>
        public ScrapeResponseDataActions(
            global::System.Collections.Generic.IList<string>? screenshots,
            global::System.Collections.Generic.IList<global::G.ScrapeResponseDataActionsScrape>? scrapes,
            global::System.Collections.Generic.IList<global::G.ScrapeResponseDataActionsJavascriptReturn>? javascriptReturns)
        {
            this.Screenshots = screenshots;
            this.Scrapes = scrapes;
            this.JavascriptReturns = javascriptReturns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseDataActions" /> class.
        /// </summary>
        public ScrapeResponseDataActions()
        {
        }
    }
}