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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SvgEllipseShapeType Type { get; set; }

        /// <summary>
        /// The horizontal radius (semi-major axis) in pixels.<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::Newtonsoft.Json.JsonProperty("radiusX", Required = global::Newtonsoft.Json.Required.Always)]
        public double RadiusX { get; set; } = default!;

        /// <summary>
        /// The vertical radius (semi-minor axis) in pixels.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("radiusY", Required = global::Newtonsoft.Json.Required.Always)]
        public double RadiusY { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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