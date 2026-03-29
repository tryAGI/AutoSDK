//HintName: G.Models.RichTextShadow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text shadow properties.
    /// </summary>
    public sealed partial class RichTextShadow
    {
        /// <summary>
        /// Horizontal offset of the shadow in pixels. Positive values move right, negative left.<br/>
        /// Default Value: 0<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::Newtonsoft.Json.JsonProperty("offsetX")]
        public double? OffsetX { get; set; }

        /// <summary>
        /// Vertical offset of the shadow in pixels. Positive values move down, negative up.<br/>
        /// Default Value: 0<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::Newtonsoft.Json.JsonProperty("offsetY")]
        public double? OffsetY { get; set; }

        /// <summary>
        /// The blur radius of the shadow in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::Newtonsoft.Json.JsonProperty("blur")]
        public double? Blur { get; set; }

        /// <summary>
        /// The shadow color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the shadow where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextShadow" /> class.
        /// </summary>
        /// <param name="offsetX">
        /// Horizontal offset of the shadow in pixels. Positive values move right, negative left.<br/>
        /// Default Value: 0<br/>
        /// Example: 4
        /// </param>
        /// <param name="offsetY">
        /// Vertical offset of the shadow in pixels. Positive values move down, negative up.<br/>
        /// Default Value: 0<br/>
        /// Example: 4
        /// </param>
        /// <param name="blur">
        /// The blur radius of the shadow in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 8
        /// </param>
        /// <param name="color">
        /// The shadow color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #000000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the shadow where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.7F
        /// </param>
        public RichTextShadow(
            double? offsetX,
            double? offsetY,
            double? blur,
            string? color,
            double? opacity)
        {
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
            this.Blur = blur;
            this.Color = color;
            this.Opacity = opacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextShadow" /> class.
        /// </summary>
        public RichTextShadow()
        {
        }
    }
}