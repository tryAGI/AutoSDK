//HintName: G.Models.CodeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeItem
    {
        /// <summary>
        /// Code block item type<br/>
        /// Default Value: code
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
        /// Code content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Programming language identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeItem" /> class.
        /// </summary>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="value">
        /// Code content
        /// </param>
        /// <param name="type">
        /// Code block item type<br/>
        /// Default Value: code
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
        /// <param name="language">
        /// Programming language identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeItem(
            string md,
            string value,
            string? type,
            global::System.Collections.Generic.IList<global::G.BBox>? bbox,
            string? language)
        {
            this.Type = type;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Bbox = bbox;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeItem" /> class.
        /// </summary>
        public CodeItem()
        {
        }
    }
}