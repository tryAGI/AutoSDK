//HintName: G.Models.TextItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextItem
    {
        /// <summary>
        /// Text item type<br/>
        /// Default Value: text
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
        /// Text content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextItem" /> class.
        /// </summary>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="value">
        /// Text content
        /// </param>
        /// <param name="type">
        /// Text item type<br/>
        /// Default Value: text
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
        public TextItem(
            string md,
            string value,
            string? type,
            global::System.Collections.Generic.IList<global::G.BBox>? bbox)
        {
            this.Type = type;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Bbox = bbox;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextItem" /> class.
        /// </summary>
        public TextItem()
        {
        }
    }
}