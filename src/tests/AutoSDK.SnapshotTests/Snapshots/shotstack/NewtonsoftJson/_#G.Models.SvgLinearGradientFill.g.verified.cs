//HintName: G.Models.SvgLinearGradientFill.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A linear gradient fill that transitions colors along a straight line.<br/>
    /// The gradient direction is controlled by the `angle` property.
    /// </summary>
    public sealed partial class SvgLinearGradientFill
    {
        /// <summary>
        /// The fill type - set to `linear` for a linear gradient fill.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SvgLinearGradientFillTypeJsonConverter))]
        public global::G.SvgLinearGradientFillType Type { get; set; }

        /// <summary>
        /// The angle of the gradient in degrees. `0` is horizontal (left to right),<br/>
        /// `90` is vertical (bottom to top), `180` is right to left, etc.<br/>
        /// Default Value: 0<br/>
        /// Example: 45
        /// </summary>
        /// <example>45</example>
        [global::Newtonsoft.Json.JsonProperty("angle")]
        public double? Angle { get; set; }

        /// <summary>
        /// Array of color stops that define the gradient colors and their positions.<br/>
        /// Must have at least 2 stops. Offsets should increase from 0 to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stops", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SvgGradientStop> Stops { get; set; } = default!;

        /// <summary>
        /// The overall opacity of the gradient where `1` is fully opaque and `0` is fully transparent.<br/>
        /// Default Value: 1<br/>
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
        /// Initializes a new instance of the <see cref="SvgLinearGradientFill" /> class.
        /// </summary>
        /// <param name="stops">
        /// Array of color stops that define the gradient colors and their positions.<br/>
        /// Must have at least 2 stops. Offsets should increase from 0 to 1.
        /// </param>
        /// <param name="type">
        /// The fill type - set to `linear` for a linear gradient fill.
        /// </param>
        /// <param name="angle">
        /// The angle of the gradient in degrees. `0` is horizontal (left to right),<br/>
        /// `90` is vertical (bottom to top), `180` is right to left, etc.<br/>
        /// Default Value: 0<br/>
        /// Example: 45
        /// </param>
        /// <param name="opacity">
        /// The overall opacity of the gradient where `1` is fully opaque and `0` is fully transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        public SvgLinearGradientFill(
            global::System.Collections.Generic.IList<global::G.SvgGradientStop> stops,
            global::G.SvgLinearGradientFillType type,
            double? angle,
            double? opacity)
        {
            this.Type = type;
            this.Angle = angle;
            this.Stops = stops ?? throw new global::System.ArgumentNullException(nameof(stops));
            this.Opacity = opacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgLinearGradientFill" /> class.
        /// </summary>
        public SvgLinearGradientFill()
        {
        }
    }
}