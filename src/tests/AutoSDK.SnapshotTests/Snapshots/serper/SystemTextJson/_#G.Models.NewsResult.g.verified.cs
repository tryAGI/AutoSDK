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
        /// Title of the news article.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the news article.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Text snippet from the article.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Publication date of the article.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// News source name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// URL of the article thumbnail image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Position of the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the news article.
        /// </param>
        /// <param name="link">
        /// URL of the news article.
        /// </param>
        /// <param name="snippet">
        /// Text snippet from the article.
        /// </param>
        /// <param name="date">
        /// Publication date of the article.
        /// </param>
        /// <param name="source">
        /// News source name.
        /// </param>
        /// <param name="imageUrl">
        /// URL of the article thumbnail image.
        /// </param>
        /// <param name="position">
        /// Position of the result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewsResult(
            string? title,
            string? link,
            string? snippet,
            string? date,
            string? source,
            string? imageUrl,
            int? position)
        {
            this.Title = title;
            this.Link = link;
            this.Snippet = snippet;
            this.Date = date;
            this.Source = source;
            this.ImageUrl = imageUrl;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsResult" /> class.
        /// </summary>
        public NewsResult()
        {
        }
    }
}