//HintName: G.Models.ShapeAssetFill.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the fill style of the shape.
    /// </summary>
    public sealed partial class ShapeAssetFill
    {
        /// <summary>
        /// The color of the fill using hexadecimal color notation.<br/>
        /// Example: #ffffff
        /// </summary>
        /// <example>#ffffff</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the fill where 1 is opaque and 0 is transparent.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetFill" /> class.
        /// </summary>
        /// <param name="color">
        /// The color of the fill using hexadecimal color notation.<br/>
        /// Example: #ffffff
        /// </param>
        /// <param name="opacity">
        /// The opacity of the fill where 1 is opaque and 0 is transparent.<br/>
        /// Example: 1
        /// </param>
        public ShapeAssetFill(
            string? color,
            double? opacity)
        {
            this.Color = color;
            this.Opacity = opacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetFill" /> class.
        /// </summary>
        public ShapeAssetFill()
        {
        }
    }
}