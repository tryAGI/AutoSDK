//HintName: G.Models.RichCaptionStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text style properties for rich captions. Same as RichTextStyle but without wordSpacing.
    /// </summary>
    public sealed partial class RichCaptionStyle
    {
        /// <summary>
        /// Additional spacing between letters in pixels. Can be negative for tighter spacing.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("letterSpacing")]
        public double? LetterSpacing { get; set; }

        /// <summary>
        /// The line height as a multiplier of the font size. Must be between 0 and 10.<br/>
        /// Default Value: 1.2F<br/>
        /// Example: 1.5F
        /// </summary>
        /// <example>1.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineHeight")]
        public double? LineHeight { get; set; }

        /// <summary>
        /// Text transformation to apply.<br/>
        /// Default Value: none<br/>
        /// Example: uppercase
        /// </summary>
        /// <example>uppercase</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("textTransform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RichCaptionStyleTextTransformJsonConverter))]
        public global::G.RichCaptionStyleTextTransform? TextTransform { get; set; }

        /// <summary>
        /// The font size of the active word in pixels. Overrides the scale property when set.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Text decoration to apply.<br/>
        /// Default Value: none<br/>
        /// Example: underline
        /// </summary>
        /// <example>underline</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("textDecoration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RichCaptionStyleTextDecorationJsonConverter))]
        public global::G.RichCaptionStyleTextDecoration? TextDecoration { get; set; }

        /// <summary>
        /// Gradient properties for text fill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gradient")]
        public global::G.RichTextGradient? Gradient { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionStyle" /> class.
        /// </summary>
        /// <param name="letterSpacing">
        /// Additional spacing between letters in pixels. Can be negative for tighter spacing.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
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
        /// <param name="size">
        /// The font size of the active word in pixels. Overrides the scale property when set.<br/>
        /// Example: 120
        /// </param>
        /// <param name="textDecoration">
        /// Text decoration to apply.<br/>
        /// Default Value: none<br/>
        /// Example: underline
        /// </param>
        /// <param name="gradient">
        /// Gradient properties for text fill.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichCaptionStyle(
            double? letterSpacing,
            double? lineHeight,
            global::G.RichCaptionStyleTextTransform? textTransform,
            double? size,
            global::G.RichCaptionStyleTextDecoration? textDecoration,
            global::G.RichTextGradient? gradient)
        {
            this.LetterSpacing = letterSpacing;
            this.LineHeight = lineHeight;
            this.TextTransform = textTransform;
            this.Size = size;
            this.TextDecoration = textDecoration;
            this.Gradient = gradient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionStyle" /> class.
        /// </summary>
        public RichCaptionStyle()
        {
        }
    }
}