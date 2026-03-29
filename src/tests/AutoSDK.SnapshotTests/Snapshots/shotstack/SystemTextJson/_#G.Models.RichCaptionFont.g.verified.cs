//HintName: G.Models.RichCaptionFont.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Font properties for rich captions. Defaults to Roboto.
    /// </summary>
    public sealed partial class RichCaptionFont
    {
        /// <summary>
        /// The font family name. This must be the Family name embedded in the font, i.e. "Roboto".<br/>
        /// Default Value: Roboto<br/>
        /// Example: Roboto
        /// </summary>
        /// <example>Roboto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("family")]
        public string? Family { get; set; }

        /// <summary>
        /// The size of the font in pixels (px). Must be between 1 and 500.<br/>
        /// Default Value: 24<br/>
        /// Example: 48
        /// </summary>
        /// <example>48</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// The weight of the font. Can be a number (100-900) or a string ('normal', 'bold', etc.). 100 is lightest, 900 is heaviest (boldest).<br/>
        /// Default Value: 400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public object? Weight { get; set; }

        /// <summary>
        /// The text color using hexadecimal color notation.<br/>
        /// Default Value: #ffffff<br/>
        /// Example: #ffffff
        /// </summary>
        /// <example>#ffffff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the text where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.9F
        /// </summary>
        /// <example>0.9F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The background color behind the text using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public string? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionFont" /> class.
        /// </summary>
        /// <param name="family">
        /// The font family name. This must be the Family name embedded in the font, i.e. "Roboto".<br/>
        /// Default Value: Roboto<br/>
        /// Example: Roboto
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
        /// Default Value: #ffffff<br/>
        /// Example: #ffffff
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichCaptionFont(
            string? family,
            int? size,
            object? weight,
            string? color,
            double? opacity,
            string? background)
        {
            this.Family = family;
            this.Size = size;
            this.Weight = weight;
            this.Color = color;
            this.Opacity = opacity;
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionFont" /> class.
        /// </summary>
        public RichCaptionFont()
        {
        }
    }
}