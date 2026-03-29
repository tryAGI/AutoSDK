//HintName: G.Models.CaptionFont.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Font properties for captions text.
    /// </summary>
    public sealed partial class CaptionFont
    {
        /// <summary>
        /// The font family name. This must be Family name embedded in the font, i.e. "Open Sans".<br/>
        /// Example: Open Sans
        /// </summary>
        /// <example>Open Sans</example>
        [global::Newtonsoft.Json.JsonProperty("family")]
        public string? Family { get; set; }

        /// <summary>
        /// The text color using hexadecimal color notation.<br/>
        /// Example: #ffffff
        /// </summary>
        /// <example>#ffffff</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the text where 1 is opaque and 0 is transparent.<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The size of the font in pixels (px).<br/>
        /// Example: 24
        /// </summary>
        /// <example>24</example>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// The line height of the font as a ratio of the font size.<br/>
        /// Example: 0.85F
        /// </summary>
        /// <example>0.85F</example>
        [global::Newtonsoft.Json.JsonProperty("lineHeight")]
        public double? LineHeight { get; set; }

        /// <summary>
        /// The stroke color of the font using hexadecimal color notation.<br/>
        /// Example: #ff6600
        /// </summary>
        /// <example>#ff6600</example>
        [global::Newtonsoft.Json.JsonProperty("stroke")]
        public string? Stroke { get; set; }

        /// <summary>
        /// The width of the stroke in pixels.<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::Newtonsoft.Json.JsonProperty("strokeWidth")]
        public double? StrokeWidth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionFont" /> class.
        /// </summary>
        /// <param name="family">
        /// The font family name. This must be Family name embedded in the font, i.e. "Open Sans".<br/>
        /// Example: Open Sans
        /// </param>
        /// <param name="color">
        /// The text color using hexadecimal color notation.<br/>
        /// Example: #ffffff
        /// </param>
        /// <param name="opacity">
        /// The opacity of the text where 1 is opaque and 0 is transparent.<br/>
        /// Example: 0.8F
        /// </param>
        /// <param name="size">
        /// The size of the font in pixels (px).<br/>
        /// Example: 24
        /// </param>
        /// <param name="lineHeight">
        /// The line height of the font as a ratio of the font size.<br/>
        /// Example: 0.85F
        /// </param>
        /// <param name="stroke">
        /// The stroke color of the font using hexadecimal color notation.<br/>
        /// Example: #ff6600
        /// </param>
        /// <param name="strokeWidth">
        /// The width of the stroke in pixels.<br/>
        /// Example: 0.8F
        /// </param>
        public CaptionFont(
            string? family,
            string? color,
            double? opacity,
            int? size,
            double? lineHeight,
            string? stroke,
            double? strokeWidth)
        {
            this.Family = family;
            this.Color = color;
            this.Opacity = opacity;
            this.Size = size;
            this.LineHeight = lineHeight;
            this.Stroke = stroke;
            this.StrokeWidth = strokeWidth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionFont" /> class.
        /// </summary>
        public CaptionFont()
        {
        }
    }
}