//HintName: G.Models.RichTextBorder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Border styling properties for the text bounding box.
    /// </summary>
    public sealed partial class RichTextBorder
    {
        /// <summary>
        /// The width of the border in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// The border color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #ff0000
        /// </summary>
        /// <example>#ff0000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the border where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The border radius in pixels for rounded corners. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("radius")]
        public double? Radius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextBorder" /> class.
        /// </summary>
        /// <param name="width">
        /// The width of the border in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
        /// <param name="color">
        /// The border color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #ff0000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the border where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.8F
        /// </param>
        /// <param name="radius">
        /// The border radius in pixels for rounded corners. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTextBorder(
            double? width,
            string? color,
            double? opacity,
            double? radius)
        {
            this.Width = width;
            this.Color = color;
            this.Opacity = opacity;
            this.Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextBorder" /> class.
        /// </summary>
        public RichTextBorder()
        {
        }
    }
}