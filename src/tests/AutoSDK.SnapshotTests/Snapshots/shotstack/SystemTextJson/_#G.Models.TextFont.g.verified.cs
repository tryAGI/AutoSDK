//HintName: G.Models.TextFont.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Font properties for text.
    /// </summary>
    public sealed partial class TextFont
    {
        /// <summary>
        /// The font family name. This must be Family name embedded in the font, i.e. "Open Sans".<br/>
        /// Example: Open Sans
        /// </summary>
        /// <example>Open Sans</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("family")]
        public string? Family { get; set; }

        /// <summary>
        /// The text color using hexadecimal color notation.<br/>
        /// Example: #ffffff
        /// </summary>
        /// <example>#ffffff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the text where 1 is opaque and 0 is transparent.<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The size of the font in pixels (px).<br/>
        /// Example: 24
        /// </summary>
        /// <example>24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// The weight of the font. 100 is lightest, 900 is heaviest (boldest).<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// The line height of the font as a ratio of the font size.<br/>
        /// Example: 0.85F
        /// </summary>
        /// <example>0.85F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineHeight")]
        public double? LineHeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFont" /> class.
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
        /// <param name="weight">
        /// The weight of the font. 100 is lightest, 900 is heaviest (boldest).<br/>
        /// Example: 400
        /// </param>
        /// <param name="lineHeight">
        /// The line height of the font as a ratio of the font size.<br/>
        /// Example: 0.85F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextFont(
            string? family,
            string? color,
            double? opacity,
            int? size,
            int? weight,
            double? lineHeight)
        {
            this.Family = family;
            this.Color = color;
            this.Opacity = opacity;
            this.Size = size;
            this.Weight = weight;
            this.LineHeight = lineHeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFont" /> class.
        /// </summary>
        public TextFont()
        {
        }
    }
}