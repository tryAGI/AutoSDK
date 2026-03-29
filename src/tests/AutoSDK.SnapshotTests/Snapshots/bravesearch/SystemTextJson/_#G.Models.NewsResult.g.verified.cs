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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// URL of the news article.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Title of the news article.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description or snippet from the article.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Human-readable age (e.g., "1 hour ago").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public string? Age { get; set; }

        /// <summary>
        /// Page age (ISO 8601 date).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_age")]
        public string? PageAge { get; set; }

        /// <summary>
        /// Aggregated URL information for a result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_url")]
        public global::G.MetaUrl? MetaUrl { get; set; }

        /// <summary>
        /// Thumbnail image information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// News source name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Whether this is breaking news.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breaking")]
        public bool? Breaking { get; set; }

        /// <summary>
        /// Whether the article is family-friendly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("family_friendly")]
        public bool? FamilyFriendly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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