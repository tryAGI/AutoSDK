//HintName: G.Models.ShapeAssetStroke.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the stroke style of the shape.
    /// </summary>
    public sealed partial class ShapeAssetStroke
    {
        /// <summary>
        /// The stroke color of the font using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The width of the stroke in pixels.<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetStroke" /> class.
        /// </summary>
        /// <param name="color">
        /// The stroke color of the font using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="width">
        /// The width of the stroke in pixels.<br/>
        /// Example: 0.8F
        /// </param>
        public ShapeAssetStroke(
            string? color,
            double? width)
        {
            this.Color = color;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetStroke" /> class.
        /// </summary>
        public ShapeAssetStroke()
        {
        }
    }
}