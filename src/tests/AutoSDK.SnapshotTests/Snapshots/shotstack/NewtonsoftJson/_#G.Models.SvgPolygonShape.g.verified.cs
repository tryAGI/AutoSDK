//HintName: G.Models.SvgPolygonShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A regular polygon shape with a specified number of sides.<br/>
    /// Examples: triangle (3), square (4), pentagon (5), hexagon (6), etc.<br/>
    /// The polygon is inscribed in a circle of the given radius.
    /// </summary>
    public sealed partial class SvgPolygonShape
    {
        /// <summary>
        /// The shape type - set to `polygon`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SvgPolygonShapeType Type { get; set; }

        /// <summary>
        /// The number of sides of the polygon.<br/>
        /// Minimum 3 (triangle), maximum 100 for practical use.<br/>
        /// Example: 6
        /// </summary>
        /// <example>6</example>
        [global::Newtonsoft.Json.JsonProperty("sides", Required = global::Newtonsoft.Json.Required.Always)]
        public int Sides { get; set; } = default!;

        /// <summary>
        /// The radius of the circumscribed circle in pixels.<br/>
        /// This determines the size of the polygon.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("radius", Required = global::Newtonsoft.Json.Required.Always)]
        public double Radius { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgPolygonShape" /> class.
        /// </summary>
        /// <param name="sides">
        /// The number of sides of the polygon.<br/>
        /// Minimum 3 (triangle), maximum 100 for practical use.<br/>
        /// Example: 6
        /// </param>
        /// <param name="radius">
        /// The radius of the circumscribed circle in pixels.<br/>
        /// This determines the size of the polygon.<br/>
        /// Example: 50
        /// </param>
        /// <param name="type">
        /// The shape type - set to `polygon`.
        /// </param>
        public SvgPolygonShape(
            int sides,
            double radius,
            global::G.SvgPolygonShapeType type)
        {
            this.Type = type;
            this.Sides = sides;
            this.Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgPolygonShape" /> class.
        /// </summary>
        public SvgPolygonShape()
        {
        }
    }
}