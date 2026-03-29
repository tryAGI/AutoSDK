//HintName: G.Models.ImageItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageItem
    {
        /// <summary>
        /// Image item type<br/>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Markdown representation preserving formatting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Md { get; set; }

        /// <summary>
        /// List of bounding boxes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        public global::System.Collections.Generic.IList<global::G.BBox>? Bbox { get; set; }

        /// <summary>
        /// Image caption
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Caption { get; set; }

        /// <summary>
        /// URL to the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageItem" /> class.
        /// </summary>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="caption">
        /// Image caption
        /// </param>
        /// <param name="url">
        /// URL to the image
        /// </param>
        /// <param name="type">
        /// Image item type<br/>
        /// Default Value: image
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageItem(
            string md,
            string caption,
            string url,
            string? type,
            global::System.Collections.Generic.IList<global::G.BBox>? bbox)
        {
            this.Type = type;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Bbox = bbox;
            this.Caption = caption ?? throw new global::System.ArgumentNullException(nameof(caption));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageItem" /> class.
        /// </summary>
        public ImageItem()
        {
        }
    }
}