//HintName: G.Models.SvgCircleShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A perfect circle shape defined by its radius.<br/>
    /// The circle is centered at the shape's position.
    /// </summary>
    public sealed partial class SvgCircleShape
    {
        /// <summary>
        /// The shape type - set to `circle`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgCircleShapeTypeJsonConverter))]
        public global::G.SvgCircleShapeType Type { get; set; }

        /// <summary>
        /// The radius of the circle in pixels.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("radius")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Radius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgCircleShape" /> class.
        /// </summary>
        /// <param name="radius">
        /// The radius of the circle in pixels.<br/>
        /// Example: 50
        /// </param>
        /// <param name="type">
        /// The shape type - set to `circle`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgCircleShape(
            double radius,
            global::G.SvgCircleShapeType type)
        {
            this.Type = type;
            this.Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgCircleShape" /> class.
        /// </summary>
        public SvgCircleShape()
        {
        }
    }
}