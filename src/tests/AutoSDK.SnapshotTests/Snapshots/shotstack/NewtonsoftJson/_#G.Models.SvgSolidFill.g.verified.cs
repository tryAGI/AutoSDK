//HintName: G.Models.SvgSolidFill.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A solid color fill for SVG shapes.
    /// </summary>
    public sealed partial class SvgSolidFill
    {
        /// <summary>
        /// The fill type - set to `solid` for a single color fill.<br/>
        /// Default Value: solid
        /// </summary>
        /// <default>global::G.SvgSolidFillType.Solid</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SvgSolidFillType Type { get; set; } = global::G.SvgSolidFillType.Solid;

        /// <summary>
        /// The fill color using hexadecimal color notation (e.g., `#FF0000` for red).<br/>
        /// Must be a 6-digit hex color code prefixed with `#`.<br/>
        /// Default Value: #000000<br/>
        /// Example: #3498db
        /// </summary>
        /// <default>"#000000"</default>
        /// <example>#3498db</example>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// The opacity of the fill where `1` is fully opaque and `0` is fully transparent.<br/>
        /// Values between 0 and 1 create semi-transparent fills.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgSolidFill" /> class.
        /// </summary>
        /// <param name="color">
        /// The fill color using hexadecimal color notation (e.g., `#FF0000` for red).<br/>
        /// Must be a 6-digit hex color code prefixed with `#`.<br/>
        /// Default Value: #000000<br/>
        /// Example: #3498db
        /// </param>
        /// <param name="opacity">
        /// The opacity of the fill where `1` is fully opaque and `0` is fully transparent.<br/>
        /// Values between 0 and 1 create semi-transparent fills.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.8F
        /// </param>
        /// <param name="type">
        /// The fill type - set to `solid` for a single color fill.<br/>
        /// Default Value: solid
        /// </param>
        public SvgSolidFill(
            string color,
            double? opacity,
            global::G.SvgSolidFillType type = global::G.SvgSolidFillType.Solid)
        {
            this.Type = type;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.Opacity = opacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgSolidFill" /> class.
        /// </summary>
        public SvgSolidFill()
        {
        }
    }
}