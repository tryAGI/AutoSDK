//HintName: G.Models.RichTextFont.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Font properties for rich text.
    /// </summary>
    public sealed partial class RichTextFont
    {
        /// <summary>
        /// The font family name. This must be the Family name embedded in the font, i.e. "Open Sans".<br/>
        /// Default Value: Open Sans<br/>
        /// Example: Open Sans
        /// </summary>
        /// <example>Open Sans</example>
        [global::Newtonsoft.Json.JsonProperty("family")]
        public string? Family { get; set; }

        /// <summary>
        /// The size of the font in pixels (px). Must be between 1 and 500.<br/>
        /// Default Value: 24<br/>
        /// Example: 48
        /// </summary>
        /// <example>48</example>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// The weight of the font. Can be a number (100-900) or a string ('normal', 'bold', etc.). 100 is lightest, 900 is heaviest (boldest).<br/>
        /// Default Value: 400
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public object? Weight { get; set; }

        /// <summary>
        /// The text color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #ff0000
        /// </summary>
        /// <example>#ff0000</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the text where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.9F
        /// </summary>
        /// <example>0.9F</example>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The background color behind the text using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public string? Background { get; set; }

        /// <summary>
        /// Text stroke (outline) properties.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stroke")]
        public global::G.RichTextStroke? Stroke { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextFont" /> class.
        /// </summary>
        /// <param name="family">
        /// The font family name. This must be the Family name embedded in the font, i.e. "Open Sans".<br/>
        /// Default Value: Open Sans<br/>
        /// Example: Open Sans
        /// </param>
        /// <param name="size">
        /// The size of the font in pixels (px). Must be between 1 and 500.<br/>
        /// Default Value: 24<br/>
        /// Example: 48
        /// </param>
        /// <param name="weight">
        /// The weight of the font. Can be a number (100-900) or a string ('normal', 'bold', etc.). 100 is lightest, 900 is heaviest (boldest).<br/>
        /// Default Value: 400
        /// </param>
        /// <param name="color">
        /// The text color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #ff0000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the text where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.9F
        /// </param>
        /// <param name="background">
        /// The background color behind the text using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="stroke">
        /// Text stroke (outline) properties.
        /// </param>
        public RichTextFont(
            string? family,
            int? size,
            object? weight,
            string? color,
            double? opacity,
            string? background,
            global::G.RichTextStroke? stroke)
        {
            this.Family = family;
            this.Size = size;
            this.Weight = weight;
            this.Color = color;
            this.Opacity = opacity;
            this.Background = background;
            this.Stroke = stroke;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextFont" /> class.
        /// </summary>
        public RichTextFont()
        {
        }
    }
}