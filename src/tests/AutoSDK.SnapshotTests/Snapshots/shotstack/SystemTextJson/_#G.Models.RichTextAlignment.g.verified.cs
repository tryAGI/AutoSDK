//HintName: G.Models.RichTextAlignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text alignment properties (horizontal and vertical).
    /// </summary>
    public sealed partial class RichTextAlignment
    {
        /// <summary>
        /// The horizontal alignment of the text.<br/>
        /// Default Value: center<br/>
        /// Example: center
        /// </summary>
        /// <example>center</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RichTextAlignmentHorizontalJsonConverter))]
        public global::G.RichTextAlignmentHorizontal? Horizontal { get; set; }

        /// <summary>
        /// The vertical alignment of the text within the bounding box.<br/>
        /// Default Value: middle<br/>
        /// Example: middle
        /// </summary>
        /// <example>middle</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RichTextAlignmentVerticalJsonConverter))]
        public global::G.RichTextAlignmentVertical? Vertical { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextAlignment" /> class.
        /// </summary>
        /// <param name="horizontal">
        /// The horizontal alignment of the text.<br/>
        /// Default Value: center<br/>
        /// Example: center
        /// </param>
        /// <param name="vertical">
        /// The vertical alignment of the text within the bounding box.<br/>
        /// Default Value: middle<br/>
        /// Example: middle
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTextAlignment(
            global::G.RichTextAlignmentHorizontal? horizontal,
            global::G.RichTextAlignmentVertical? vertical)
        {
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextAlignment" /> class.
        /// </summary>
        public RichTextAlignment()
        {
        }
    }
}