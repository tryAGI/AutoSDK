//HintName: G.Models.FooterItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FooterItem
    {
        /// <summary>
        /// Page footer container<br/>
        /// Default Value: footer
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
        /// List of items within the footer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ItemsItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FooterItem" /> class.
        /// </summary>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="items">
        /// List of items within the footer
        /// </param>
        /// <param name="type">
        /// Page footer container<br/>
        /// Default Value: footer
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FooterItem(
            string md,
            global::System.Collections.Generic.IList<global::G.ItemsItem> items,
            string? type,
            global::System.Collections.Generic.IList<global::G.BBox>? bbox)
        {
            this.Type = type;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Bbox = bbox;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FooterItem" /> class.
        /// </summary>
        public FooterItem()
        {
        }
    }
}