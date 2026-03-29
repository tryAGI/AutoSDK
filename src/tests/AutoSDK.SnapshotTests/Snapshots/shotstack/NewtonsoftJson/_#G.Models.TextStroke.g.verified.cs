//HintName: G.Models.TextStroke.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text stroke (outline) properties.
    /// </summary>
    public sealed partial class TextStroke
    {
        /// <summary>
        /// The width of the stroke in pixels.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public double? Width { get; set; }

        /// <summary>
        /// The stroke color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextStroke" /> class.
        /// </summary>
        /// <param name="width">
        /// The width of the stroke in pixels.<br/>
        /// Example: 2
        /// </param>
        /// <param name="color">
        /// The stroke color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        public TextStroke(
            double? width,
            string? color)
        {
            this.Width = width;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextStroke" /> class.
        /// </summary>
        public TextStroke()
        {
        }
    }
}