//HintName: G.Models.SearchWebResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchWebResponseResult
    {
        /// <summary>
        /// Unique identifier for the result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The URL of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The title of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Author of the content if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Publication date in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedDate")]
        public global::System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Image URL if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Favicon URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebResponseResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the result
        /// </param>
        /// <param name="url">
        /// The URL of the search result
        /// </param>
        /// <param name="title">
        /// The title of the search result
        /// </param>
        /// <param name="author">
        /// Author of the content if available
        /// </param>
        /// <param name="publishedDate">
        /// Publication date in ISO 8601 format
        /// </param>
        /// <param name="image">
        /// Image URL if available
        /// </param>
        /// <param name="favicon">
        /// Favicon URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebResponseResult(
            string id,
            string url,
            string title,
            string? author,
            global::System.DateTime? publishedDate,
            string? image,
            string? favicon)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Author = author;
            this.PublishedDate = publishedDate;
            this.Image = image;
            this.Favicon = favicon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebResponseResult" /> class.
        /// </summary>
        public SearchWebResponseResult()
        {
        }
    }
}