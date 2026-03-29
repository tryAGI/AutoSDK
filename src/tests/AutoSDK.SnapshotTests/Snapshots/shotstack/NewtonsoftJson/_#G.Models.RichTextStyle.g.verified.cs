//HintName: G.Models.RichTextStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text style properties including spacing, line height, and transformations.
    /// </summary>
    public sealed partial class RichTextStyle
    {
        /// <summary>
        /// Additional spacing between letters in pixels. Can be negative for tighter spacing.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("letterSpacing")]
        public double? LetterSpacing { get; set; }

        /// <summary>
        /// Additional spacing between words in pixels. A value of 0 uses the font's natural space width.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("wordSpacing")]
        public double? WordSpacing { get; set; }

        /// <summary>
        /// The line height as a multiplier of the font size. Must be between 0 and 10.<br/>
        /// Default Value: 1.2F<br/>
        /// Example: 1.5F
        /// </summary>
        /// <example>1.5F</example>
        [global::Newtonsoft.Json.JsonProperty("lineHeight")]
        public double? LineHeight { get; set; }

        /// <summary>
        /// Text transformation to apply.<br/>
        /// Default Value: none<br/>
        /// Example: uppercase
        /// </summary>
        /// <example>uppercase</example>
        [global::Newtonsoft.Json.JsonProperty("textTransform")]
        public global::G.RichTextStyleTextTransform? TextTransform { get; set; }

        /// <summary>
        /// Text decoration to apply.<br/>
        /// Default Value: none<br/>
        /// Example: underline
        /// </summary>
        /// <example>underline</example>
        [global::Newtonsoft.Json.JsonProperty("textDecoration")]
        public global::G.RichTextStyleTextDecoration? TextDecoration { get; set; }

        /// <summary>
        /// Gradient properties for text fill.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gradient")]
        public global::G.RichTextGradient? Gradient { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextStyle" /> class.
        /// </summary>
        /// <param name="letterSpacing">
        /// Additional spacing between letters in pixels. Can be negative for tighter spacing.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
        /// <param name="wordSpacing">
        /// Additional spacing between words in pixels. A value of 0 uses the font's natural space width.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        /// <param name="lineHeight">
        /// The line height as a multiplier of the font size. Must be between 0 and 10.<br/>
        /// Default Value: 1.2F<br/>
        /// Example: 1.5F
        /// </param>
        /// <param name="textTransform">
        /// Text transformation to apply.<br/>
        /// Default Value: none<br/>
        /// Example: uppercase
        /// </param>
        /// <param name="textDecoration">
        /// Text decoration to apply.<br/>
        /// Default Value: none<br/>
        /// Example: underline
        /// </param>
        /// <param name="gradient">
        /// Gradient properties for text fill.
        /// </param>
        public RichTextStyle(
            double? letterSpacing,
            double? wordSpacing,
            double? lineHeight,
            global::G.RichTextStyleTextTransform? textTransform,
            global::G.RichTextStyleTextDecoration? textDecoration,
            global::G.RichTextGradient? gradient)
        {
            this.LetterSpacing = letterSpacing;
            this.WordSpacing = wordSpacing;
            this.LineHeight = lineHeight;
            this.TextTransform = textTransform;
            this.TextDecoration = textDecoration;
            this.Gradient = gradient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextStyle" /> class.
        /// </summary>
        public RichTextStyle()
        {
        }
    }
}