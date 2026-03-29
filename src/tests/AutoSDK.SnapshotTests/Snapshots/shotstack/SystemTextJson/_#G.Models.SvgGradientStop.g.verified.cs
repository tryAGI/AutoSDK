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
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Offset { get; set; }

        /// <summary>
        /// The color at this stop using hexadecimal color notation.<br/>
        /// Example: #e74c3c
        /// </summary>
        /// <example>#e74c3c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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