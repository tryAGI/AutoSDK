//HintName: G.Models.ListItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListItem
    {
        /// <summary>
        /// List item type<br/>
        /// Default Value: list
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
        /// List of nested text or list items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextItem, global::G.ListItem>> Items { get; set; }

        /// <summary>
        /// Whether the list is ordered or unordered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ordered { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem" /> class.
        /// </summary>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="items">
        /// List of nested text or list items
        /// </param>
        /// <param name="ordered">
        /// Whether the list is ordered or unordered
        /// </param>
        /// <param name="type">
        /// List item type<br/>
        /// Default Value: list
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListItem(
            string md,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextItem, global::G.ListItem>> items,
            bool ordered,
            string? type,
            global::System.Collections.Generic.IList<global::G.BBox>? bbox)
        {
            this.Type = type;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Bbox = bbox;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Ordered = ordered;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem" /> class.
        /// </summary>
        public ListItem()
        {
        }
    }
}