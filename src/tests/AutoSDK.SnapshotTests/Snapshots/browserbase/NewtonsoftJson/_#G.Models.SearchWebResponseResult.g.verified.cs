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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The URL of the search result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The title of the search result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Author of the content if available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Publication date in ISO 8601 format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publishedDate")]
        public global::System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Image URL if available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Favicon URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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