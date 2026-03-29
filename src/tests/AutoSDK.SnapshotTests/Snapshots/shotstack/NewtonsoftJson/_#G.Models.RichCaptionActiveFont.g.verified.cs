//HintName: G.Models.RichCaptionActiveFont.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Font properties for the active/highlighted word.
    /// </summary>
    public sealed partial class RichCaptionActiveFont
    {
        /// <summary>
        /// The active word color using hexadecimal color notation.<br/>
        /// Default Value: #ffff00<br/>
        /// Example: #ffff00
        /// </summary>
        /// <example>#ffff00</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The background color behind the active word using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public string? Background { get; set; }

        /// <summary>
        /// The opacity of the active word where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The font size of the active word in pixels. Overrides the scale property when set.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Text decoration to apply to the active word.<br/>
        /// Default Value: none<br/>
        /// Example: underline
        /// </summary>
        /// <example>underline</example>
        [global::Newtonsoft.Json.JsonProperty("textDecoration")]
        public global::G.RichCaptionActiveFontTextDecoration? TextDecoration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionActiveFont" /> class.
        /// </summary>
        /// <param name="color">
        /// The active word color using hexadecimal color notation.<br/>
        /// Default Value: #ffff00<br/>
        /// Example: #ffff00
        /// </param>
        /// <param name="background">
        /// The background color behind the active word using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the active word where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="size">
        /// The font size of the active word in pixels. Overrides the scale property when set.<br/>
        /// Example: 120
        /// </param>
        /// <param name="textDecoration">
        /// Text decoration to apply to the active word.<br/>
        /// Default Value: none<br/>
        /// Example: underline
        /// </param>
        public RichCaptionActiveFont(
            string? color,
            string? background,
            double? opacity,
            double? size,
            global::G.RichCaptionActiveFontTextDecoration? textDecoration)
        {
            this.Color = color;
            this.Background = background;
            this.Opacity = opacity;
            this.Size = size;
            this.TextDecoration = textDecoration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionActiveFont" /> class.
        /// </summary>
        public RichCaptionActiveFont()
        {
        }
    }
}