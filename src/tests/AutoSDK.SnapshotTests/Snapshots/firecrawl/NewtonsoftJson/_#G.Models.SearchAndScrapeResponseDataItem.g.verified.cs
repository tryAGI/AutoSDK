//HintName: G.Models.SearchAndScrapeResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchAndScrapeResponseDataItem
    {
        /// <summary>
        /// Title from search result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description from search result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the search result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Markdown content if scraping was requested
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// HTML content if requested in formats
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Raw HTML content if requested in formats
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rawHtml")]
        public string? RawHtml { get; set; }

        /// <summary>
        /// Links found if requested in formats
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::System.Collections.Generic.IList<string>? Links { get; set; }

        /// <summary>
        /// Screenshot URL if requested in formats
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("screenshot")]
        public string? Screenshot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.SearchAndScrapeResponseDataItemMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeResponseDataItem" /> class.
        /// </summary>
        /// <param name="title">
        /// Title from search result
        /// </param>
        /// <param name="description">
        /// Description from search result
        /// </param>
        /// <param name="url">
        /// URL of the search result
        /// </param>
        /// <param name="markdown">
        /// Markdown content if scraping was requested
        /// </param>
        /// <param name="html">
        /// HTML content if requested in formats
        /// </param>
        /// <param name="rawHtml">
        /// Raw HTML content if requested in formats
        /// </param>
        /// <param name="links">
        /// Links found if requested in formats
        /// </param>
        /// <param name="screenshot">
        /// Screenshot URL if requested in formats
        /// </param>
        /// <param name="metadata"></param>
        public SearchAndScrapeResponseDataItem(
            string? title,
            string? description,
            string? url,
            string? markdown,
            string? html,
            string? rawHtml,
            global::System.Collections.Generic.IList<string>? links,
            string? screenshot,
            global::G.SearchAndScrapeResponseDataItemMetadata? metadata)
        {
            this.Title = title;
            this.Description = description;
            this.Url = url;
            this.Markdown = markdown;
            this.Html = html;
            this.RawHtml = rawHtml;
            this.Links = links;
            this.Screenshot = screenshot;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeResponseDataItem" /> class.
        /// </summary>
        public SearchAndScrapeResponseDataItem()
        {
        }
    }
}