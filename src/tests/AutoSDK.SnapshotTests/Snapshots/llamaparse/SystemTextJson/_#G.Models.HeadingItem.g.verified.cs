//HintName: G.Models.HeadingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeadingItem
    {
        /// <summary>
        /// Heading item type<br/>
        /// Default Value: heading
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
        /// Heading level (1-6)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Level { get; set; }

        /// <summary>
        /// Heading text content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadingItem" /> class.
        /// </summary>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="level">
        /// Heading level (1-6)
        /// </param>
        /// <param name="value">
        /// Heading text content
        /// </param>
        /// <param name="type">
        /// Heading item type<br/>
        /// Default Value: heading
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeadingItem(
            string md,
            int level,
            string value,
            string? type,
            global::System.Collections.Generic.IList<global::G.BBox>? bbox)
        {
            this.Type = type;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Bbox = bbox;
            this.Level = level;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadingItem" /> class.
        /// </summary>
        public HeadingItem()
        {
        }
    }
}