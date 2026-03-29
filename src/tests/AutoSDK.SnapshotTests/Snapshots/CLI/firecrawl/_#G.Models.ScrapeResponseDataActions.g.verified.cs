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
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshots")]
        public global::System.Collections.Generic.IList<string>? Screenshots { get; set; }

        /// <summary>
        /// Scrape contents, in the same order as the scrape actions provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scrapes")]
        public global::System.Collections.Generic.IList<global::G.ScrapeResponseDataActionsScrape>? Scrapes { get; set; }

        /// <summary>
        /// JavaScript return values, in the same order as the executeJavascript actions provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("javascriptReturns")]
        public global::System.Collections.Generic.IList<global::G.ScrapeResponseDataActionsJavascriptReturn>? JavascriptReturns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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