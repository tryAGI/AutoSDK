//HintName: G.Models.CaptionBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Displays a background box behind the caption text.
    /// </summary>
    public sealed partial class CaptionBackground
    {
        /// <summary>
        /// The background color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the background color.<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The padding inside the background box in pixels.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("padding")]
        public int? Padding { get; set; }

        /// <summary>
        /// The border radius of the background box in pixels.<br/>
        /// Example: 18
        /// </summary>
        /// <example>18</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("borderRadius")]
        public int? BorderRadius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionBackground" /> class.
        /// </summary>
        /// <param name="color">
        /// The background color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the background color.<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="padding">
        /// The padding inside the background box in pixels.<br/>
        /// Example: 30
        /// </param>
        /// <param name="borderRadius">
        /// The border radius of the background box in pixels.<br/>
        /// Example: 18
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionBackground(
            string? color,
            double? opacity,
            int? padding,
            int? borderRadius)
        {
            this.Color = color;
            this.Opacity = opacity;
            this.Padding = padding;
            this.BorderRadius = borderRadius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionBackground" /> class.
        /// </summary>
        public CaptionBackground()
        {
        }
    }
}