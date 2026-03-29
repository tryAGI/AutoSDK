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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Markdown representation preserving formatting
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md", Required = global::Newtonsoft.Json.Required.Always)]
        public string Md { get; set; } = default!;

        /// <summary>
        /// List of bounding boxes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bbox")]
        public global::System.Collections.Generic.IList<global::G.BBox>? Bbox { get; set; }

        /// <summary>
        /// Image caption
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caption", Required = global::Newtonsoft.Json.Required.Always)]
        public string Caption { get; set; } = default!;

        /// <summary>
        /// URL to the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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