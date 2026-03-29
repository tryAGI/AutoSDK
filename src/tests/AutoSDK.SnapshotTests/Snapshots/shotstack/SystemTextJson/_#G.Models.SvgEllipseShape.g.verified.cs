//HintName: G.Models.SvgEllipseShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An ellipse (oval) shape with separate horizontal and vertical radii.<br/>
    /// The ellipse is centered at the shape's position.
    /// </summary>
    public sealed partial class SvgEllipseShape
    {
        /// <summary>
        /// The shape type - set to `ellipse`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgEllipseShapeTypeJsonConverter))]
        public global::G.SvgEllipseShapeType Type { get; set; }

        /// <summary>
        /// The horizontal radius (semi-major axis) in pixels.<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("radiusX")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RadiusX { get; set; }

        /// <summary>
        /// The vertical radius (semi-minor axis) in pixels.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("radiusY")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RadiusY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgEllipseShape" /> class.
        /// </summary>
        /// <param name="radiusX">
        /// The horizontal radius (semi-major axis) in pixels.<br/>
        /// Example: 80
        /// </param>
        /// <param name="radiusY">
        /// The vertical radius (semi-minor axis) in pixels.<br/>
        /// Example: 50
        /// </param>
        /// <param name="type">
        /// The shape type - set to `ellipse`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgEllipseShape(
            double radiusX,
            double radiusY,
            global::G.SvgEllipseShapeType type)
        {
            this.Type = type;
            this.RadiusX = radiusX;
            this.RadiusY = radiusY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgEllipseShape" /> class.
        /// </summary>
        public SvgEllipseShape()
        {
        }
    }
}