//HintName: G.Models.WebSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single web search result.
    /// </summary>
    public sealed partial class WebSearchResult
    {
        /// <summary>
        /// Title of the web page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the web page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Whether the source is local.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_source_local")]
        public bool? IsSourceLocal { get; set; }

        /// <summary>
        /// Whether the source is both local and non-local.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_source_both")]
        public bool? IsSourceBoth { get; set; }

        /// <summary>
        /// Description or snippet from the web page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Age of the page (ISO 8601 date).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_age")]
        public string? PageAge { get; set; }

        /// <summary>
        /// When the page was last fetched.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_fetched")]
        public string? PageFetched { get; set; }

        /// <summary>
        /// Profile information for a content creator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile")]
        public global::G.Profile? Profile { get; set; }

        /// <summary>
        /// Language of the page content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Whether the page is family-friendly.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("family_friendly")]
        public bool? FamilyFriendly { get; set; }

        /// <summary>
        /// Type of the result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebSearchResultTypeJsonConverter))]
        public global::G.WebSearchResultType? Type { get; set; }

        /// <summary>
        /// Subtype of the result (e.g., generic, faq).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtype")]
        public string? Subtype { get; set; }

        /// <summary>
        /// Aggregated URL information for a result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_url")]
        public global::G.MetaUrl? MetaUrl { get; set; }

        /// <summary>
        /// Thumbnail image information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// Human-readable age of the result (e.g., "2 hours ago").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age")]
        public string? Age { get; set; }

        /// <summary>
        /// Additional snippets from the page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_snippets")]
        public global::System.Collections.Generic.IList<string>? ExtraSnippets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the web page.
        /// </param>
        /// <param name="url">
        /// URL of the web page.
        /// </param>
        /// <param name="isSourceLocal">
        /// Whether the source is local.
        /// </param>
        /// <param name="isSourceBoth">
        /// Whether the source is both local and non-local.
        /// </param>
        /// <param name="description">
        /// Description or snippet from the web page.
        /// </param>
        /// <param name="pageAge">
        /// Age of the page (ISO 8601 date).
        /// </param>
        /// <param name="pageFetched">
        /// When the page was last fetched.
        /// </param>
        /// <param name="profile">
        /// Profile information for a content creator.
        /// </param>
        /// <param name="language">
        /// Language of the page content.
        /// </param>
        /// <param name="familyFriendly">
        /// Whether the page is family-friendly.
        /// </param>
        /// <param name="type">
        /// Type of the result.
        /// </param>
        /// <param name="subtype">
        /// Subtype of the result (e.g., generic, faq).
        /// </param>
        /// <param name="metaUrl">
        /// Aggregated URL information for a result.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="age">
        /// Human-readable age of the result (e.g., "2 hours ago").
        /// </param>
        /// <param name="extraSnippets">
        /// Additional snippets from the page.
        /// </param>
        public WebSearchResult(
            string? title,
            string? url,
            bool? isSourceLocal,
            bool? isSourceBoth,
            string? description,
            string? pageAge,
            string? pageFetched,
            global::G.Profile? profile,
            string? language,
            bool? familyFriendly,
            global::G.WebSearchResultType? type,
            string? subtype,
            global::G.MetaUrl? metaUrl,
            global::G.Thumbnail? thumbnail,
            string? age,
            global::System.Collections.Generic.IList<string>? extraSnippets)
        {
            this.Title = title;
            this.Url = url;
            this.IsSourceLocal = isSourceLocal;
            this.IsSourceBoth = isSourceBoth;
            this.Description = description;
            this.PageAge = pageAge;
            this.PageFetched = pageFetched;
            this.Profile = profile;
            this.Language = language;
            this.FamilyFriendly = familyFriendly;
            this.Type = type;
            this.Subtype = subtype;
            this.MetaUrl = metaUrl;
            this.Thumbnail = thumbnail;
            this.Age = age;
            this.ExtraSnippets = extraSnippets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResult" /> class.
        /// </summary>
        public WebSearchResult()
        {
        }
    }
}