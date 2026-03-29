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
        /// Title/alt text of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the full-size image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Width of the image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageWidth")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// Height of the image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageHeight")]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// URL of the thumbnail image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// Source page title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Domain of the source page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// URL of the page containing the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Google image viewer URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("googleUrl")]
        public string? GoogleUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="ImageResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Title/alt text of the image.
        /// </param>
        /// <param name="imageUrl">
        /// URL of the full-size image.
        /// </param>
        /// <param name="imageWidth">
        /// Width of the image in pixels.
        /// </param>
        /// <param name="imageHeight">
        /// Height of the image in pixels.
        /// </param>
        /// <param name="thumbnailUrl">
        /// URL of the thumbnail image.
        /// </param>
        /// <param name="source">
        /// Source page title.
        /// </param>
        /// <param name="domain">
        /// Domain of the source page.
        /// </param>
        /// <param name="link">
        /// URL of the page containing the image.
        /// </param>
        /// <param name="googleUrl">
        /// Google image viewer URL.
        /// </param>
        /// <param name="position">
        /// Position of the result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageResult(
            string? title,
            string? imageUrl,
            int? imageWidth,
            int? imageHeight,
            string? thumbnailUrl,
            string? source,
            string? domain,
            string? link,
            string? googleUrl,
            int? position)
        {
            this.Title = title;
            this.ImageUrl = imageUrl;
            this.ImageWidth = imageWidth;
            this.ImageHeight = imageHeight;
            this.ThumbnailUrl = thumbnailUrl;
            this.Source = source;
            this.Domain = domain;
            this.Link = link;
            this.GoogleUrl = googleUrl;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResult" /> class.
        /// </summary>
        public ImageResult()
        {
        }
    }
}