//HintName: G.Models.NewsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single news search result.
    /// </summary>
    public sealed partial class NewsResult
    {
        /// <summary>
        /// The type of the result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// URL of the news article.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Title of the news article.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description or snippet from the article.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Human-readable age (e.g., "1 hour ago").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age")]
        public string? Age { get; set; }

        /// <summary>
        /// Page age (ISO 8601 date).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_age")]
        public string? PageAge { get; set; }

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
        /// News source name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Whether this is breaking news.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breaking")]
        public bool? Breaking { get; set; }

        /// <summary>
        /// Whether the article is family-friendly.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("family_friendly")]
        public bool? FamilyFriendly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsResult" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the result.
        /// </param>
        /// <param name="url">
        /// URL of the news article.
        /// </param>
        /// <param name="title">
        /// Title of the news article.
        /// </param>
        /// <param name="description">
        /// Description or snippet from the article.
        /// </param>
        /// <param name="age">
        /// Human-readable age (e.g., "1 hour ago").
        /// </param>
        /// <param name="pageAge">
        /// Page age (ISO 8601 date).
        /// </param>
        /// <param name="metaUrl">
        /// Aggregated URL information for a result.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="source">
        /// News source name.
        /// </param>
        /// <param name="breaking">
        /// Whether this is breaking news.
        /// </param>
        /// <param name="familyFriendly">
        /// Whether the article is family-friendly.
        /// </param>
        public NewsResult(
            string? type,
            string? url,
            string? title,
            string? description,
            string? age,
            string? pageAge,
            global::G.MetaUrl? metaUrl,
            global::G.Thumbnail? thumbnail,
            string? source,
            bool? breaking,
            bool? familyFriendly)
        {
            this.Type = type;
            this.Url = url;
            this.Title = title;
            this.Description = description;
            this.Age = age;
            this.PageAge = pageAge;
            this.MetaUrl = metaUrl;
            this.Thumbnail = thumbnail;
            this.Source = source;
            this.Breaking = breaking;
            this.FamilyFriendly = familyFriendly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsResult" /> class.
        /// </summary>
        public NewsResult()
        {
        }
    }
}