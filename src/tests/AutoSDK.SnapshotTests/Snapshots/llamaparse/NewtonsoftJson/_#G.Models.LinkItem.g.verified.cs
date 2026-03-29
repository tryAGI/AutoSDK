//HintName: G.Models.LinkItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkItem
    {
        /// <summary>
        /// Link item type<br/>
        /// Default Value: link
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
        /// URL of the link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Display text of the link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkItem" /> class.
        /// </summary>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="url">
        /// URL of the link
        /// </param>
        /// <param name="text">
        /// Display text of the link
        /// </param>
        /// <param name="type">
        /// Link item type<br/>
        /// Default Value: link
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
        public LinkItem(
            string md,
            string url,
            string text,
            string? type,
            global::System.Collections.Generic.IList<global::G.BBox>? bbox)
        {
            this.Type = type;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Bbox = bbox;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkItem" /> class.
        /// </summary>
        public LinkItem()
        {
        }
    }
}