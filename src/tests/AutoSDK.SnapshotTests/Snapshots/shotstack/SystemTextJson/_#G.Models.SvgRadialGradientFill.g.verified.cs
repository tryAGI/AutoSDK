//HintName: G.Models.SvgRadialGradientFill.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A radial gradient fill that transitions colors radiating outward from a center point.<br/>
    /// The gradient creates a circular or elliptical color transition.
    /// </summary>
    public sealed partial class SvgRadialGradientFill
    {
        /// <summary>
        /// The fill type - set to `radial` for a radial gradient fill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgRadialGradientFillTypeJsonConverter))]
        public global::G.SvgRadialGradientFillType Type { get; set; }

        /// <summary>
        /// Array of color stops that define the gradient colors and their positions.<br/>
        /// Must have at least 2 stops. Offset `0` is the center, `1` is the outer edge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SvgGradientStop> Stops { get; set; }

        /// <summary>
        /// The overall opacity of the gradient where `1` is fully opaque and `0` is fully transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgRadialGradientFill" /> class.
        /// </summary>
        /// <param name="stops">
        /// Array of color stops that define the gradient colors and their positions.<br/>
        /// Must have at least 2 stops. Offset `0` is the center, `1` is the outer edge.
        /// </param>
        /// <param name="type">
        /// The fill type - set to `radial` for a radial gradient fill.
        /// </param>
        /// <param name="opacity">
        /// The overall opacity of the gradient where `1` is fully opaque and `0` is fully transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgRadialGradientFill(
            global::System.Collections.Generic.IList<global::G.SvgGradientStop> stops,
            global::G.SvgRadialGradientFillType type,
            double? opacity)
        {
            this.Type = type;
            this.Stops = stops ?? throw new global::System.ArgumentNullException(nameof(stops));
            this.Opacity = opacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgRadialGradientFill" /> class.
        /// </summary>
        public SvgRadialGradientFill()
        {
        }
    }
}