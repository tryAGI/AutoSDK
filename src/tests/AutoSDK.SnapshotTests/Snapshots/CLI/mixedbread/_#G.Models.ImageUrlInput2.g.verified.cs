//HintName: G.Models.ImageUrlInput2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for image URL validation.
    /// </summary>
    public sealed partial class ImageUrlInput2
    {
        /// <summary>
        /// The image URL. Can be either a URL or a Data URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The image format/mimetype
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlInput2" /> class.
        /// </summary>
        /// <param name="url">
        /// The image URL. Can be either a URL or a Data URI.
        /// </param>
        /// <param name="format">
        /// The image format/mimetype
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageUrlInput2(
            string url,
            string? format)
        {
            this.Url = url;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlInput2" /> class.
        /// </summary>
        public ImageUrlInput2()
        {
        }

    }
}