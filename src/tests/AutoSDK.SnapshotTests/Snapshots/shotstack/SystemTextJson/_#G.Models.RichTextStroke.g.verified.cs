//HintName: G.Models.RichTextStroke.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text stroke (outline) properties.
    /// </summary>
    public sealed partial class RichTextStroke
    {
        /// <summary>
        /// The width of the stroke in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// The stroke color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the stroke where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextStroke" /> class.
        /// </summary>
        /// <param name="width">
        /// The width of the stroke in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
        /// <param name="color">
        /// The stroke color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #000000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the stroke where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.8F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTextStroke(
            double? width,
            string? color,
            double? opacity)
        {
            this.Width = width;
            this.Color = color;
            this.Opacity = opacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextStroke" /> class.
        /// </summary>
        public RichTextStroke()
        {
        }
    }
}