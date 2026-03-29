//HintName: G.Models.TextBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Displays a background box behind the text.
    /// </summary>
    public sealed partial class TextBackground
    {
        /// <summary>
        /// The background color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the background where 1 is opaque and 0 is transparent.<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// Padding inside the background box in pixels.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("padding")]
        public double? Padding { get; set; }

        /// <summary>
        /// The border radius of the background box in pixels for rounded corners.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("borderRadius")]
        public double? BorderRadius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBackground" /> class.
        /// </summary>
        /// <param name="color">
        /// The background color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the background where 1 is opaque and 0 is transparent.<br/>
        /// Example: 0.8F
        /// </param>
        /// <param name="padding">
        /// Padding inside the background box in pixels.<br/>
        /// Example: 10
        /// </param>
        /// <param name="borderRadius">
        /// The border radius of the background box in pixels for rounded corners.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextBackground(
            string? color,
            double? opacity,
            double? padding,
            double? borderRadius)
        {
            this.Color = color;
            this.Opacity = opacity;
            this.Padding = padding;
            this.BorderRadius = borderRadius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBackground" /> class.
        /// </summary>
        public TextBackground()
        {
        }
    }
}