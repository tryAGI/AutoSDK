//HintName: G.Models.ImageProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Properties of an image.
    /// </summary>
    public sealed partial class ImageProperties
    {
        /// <summary>
        /// URL of the full-size image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// URL of the resized image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resized")]
        public string? Resized { get; set; }

        /// <summary>
        /// Height of the image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width of the image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Image file format (e.g., jpeg, png).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// File size of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_size")]
        public string? ContentSize { get; set; }

        /// <summary>
        /// Base64-encoded low-quality placeholder image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder")]
        public string? Placeholder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageProperties" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the full-size image.
        /// </param>
        /// <param name="resized">
        /// URL of the resized image.
        /// </param>
        /// <param name="height">
        /// Height of the image in pixels.
        /// </param>
        /// <param name="width">
        /// Width of the image in pixels.
        /// </param>
        /// <param name="format">
        /// Image file format (e.g., jpeg, png).
        /// </param>
        /// <param name="contentSize">
        /// File size of the image.
        /// </param>
        /// <param name="placeholder">
        /// Base64-encoded low-quality placeholder image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageProperties(
            string? url,
            string? resized,
            int? height,
            int? width,
            string? format,
            string? contentSize,
            string? placeholder)
        {
            this.Url = url;
            this.Resized = resized;
            this.Height = height;
            this.Width = width;
            this.Format = format;
            this.ContentSize = contentSize;
            this.Placeholder = placeholder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageProperties" /> class.
        /// </summary>
        public ImageProperties()
        {
        }
    }
}