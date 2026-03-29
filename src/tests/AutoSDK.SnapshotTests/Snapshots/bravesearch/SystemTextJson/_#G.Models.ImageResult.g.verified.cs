//HintName: G.Models.ImageResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single image search result.
    /// </summary>
    public sealed partial class ImageResult
    {
        /// <summary>
        /// The type of the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// URL of the page containing the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Title/alt text of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Source domain or site name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// When the page was last fetched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_fetched")]
        public string? PageFetched { get; set; }

        /// <summary>
        /// Whether the image is family-friendly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("family_friendly")]
        public bool? FamilyFriendly { get; set; }

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
        /// Properties of an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::G.ImageProperties? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResult" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the result.
        /// </param>
        /// <param name="url">
        /// URL of the page containing the image.
        /// </param>
        /// <param name="title">
        /// Title/alt text of the image.
        /// </param>
        /// <param name="description">
        /// Description of the image.
        /// </param>
        /// <param name="source">
        /// Source domain or site name.
        /// </param>
        /// <param name="pageFetched">
        /// When the page was last fetched.
        /// </param>
        /// <param name="familyFriendly">
        /// Whether the image is family-friendly.
        /// </param>
        /// <param name="metaUrl">
        /// Aggregated URL information for a result.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="properties">
        /// Properties of an image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageResult(
            string? type,
            string? url,
            string? title,
            string? description,
            string? source,
            string? pageFetched,
            bool? familyFriendly,
            global::G.MetaUrl? metaUrl,
            global::G.Thumbnail? thumbnail,
            global::G.ImageProperties? properties)
        {
            this.Type = type;
            this.Url = url;
            this.Title = title;
            this.Description = description;
            this.Source = source;
            this.PageFetched = pageFetched;
            this.FamilyFriendly = familyFriendly;
            this.MetaUrl = metaUrl;
            this.Thumbnail = thumbnail;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResult" /> class.
        /// </summary>
        public ImageResult()
        {
        }
    }
}