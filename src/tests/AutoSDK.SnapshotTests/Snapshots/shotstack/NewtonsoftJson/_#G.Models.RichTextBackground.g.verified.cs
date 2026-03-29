//HintName: G.Models.RichTextBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Background styling properties for the text bounding box.
    /// </summary>
    public sealed partial class RichTextBackground
    {
        /// <summary>
        /// The background color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the background where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The border radius of the background box in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("borderRadius")]
        public double? BorderRadius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextBackground" /> class.
        /// </summary>
        /// <param name="color">
        /// The background color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the background where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="borderRadius">
        /// The border radius of the background box in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        public RichTextBackground(
            string? color,
            double? opacity,
            double? borderRadius)
        {
            this.Color = color;
            this.Opacity = opacity;
            this.BorderRadius = borderRadius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextBackground" /> class.
        /// </summary>
        public RichTextBackground()
        {
        }
    }
}