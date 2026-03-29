//HintName: G.Models.SvgGradientStop.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A color stop in a gradient. Each stop defines a color at a specific position<br/>
    /// along the gradient vector. Gradients require at least 2 stops.
    /// </summary>
    public sealed partial class SvgGradientStop
    {
        /// <summary>
        /// Position of the color stop along the gradient vector.<br/>
        /// `0` represents the start and `1` represents the end of the gradient.<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::Newtonsoft.Json.JsonProperty("offset", Required = global::Newtonsoft.Json.Required.Always)]
        public double Offset { get; set; } = default!;

        /// <summary>
        /// The color at this stop using hexadecimal color notation.<br/>
        /// Example: #e74c3c
        /// </summary>
        /// <example>#e74c3c</example>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgGradientStop" /> class.
        /// </summary>
        /// <param name="offset">
        /// Position of the color stop along the gradient vector.<br/>
        /// `0` represents the start and `1` represents the end of the gradient.<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="color">
        /// The color at this stop using hexadecimal color notation.<br/>
        /// Example: #e74c3c
        /// </param>
        public SvgGradientStop(
            double offset,
            string color)
        {
            this.Offset = offset;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgGradientStop" /> class.
        /// </summary>
        public SvgGradientStop()
        {
        }
    }
}