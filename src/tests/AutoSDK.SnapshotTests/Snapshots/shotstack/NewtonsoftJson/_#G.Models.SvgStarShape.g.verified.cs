//HintName: G.Models.SvgStarShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A star shape with a specified number of points.<br/>
    /// The star is defined by outer and inner radii, creating the characteristic<br/>
    /// pointed appearance.
    /// </summary>
    public sealed partial class SvgStarShape
    {
        /// <summary>
        /// The shape type - set to `star`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SvgStarShapeType Type { get; set; }

        /// <summary>
        /// The number of points on the star.<br/>
        /// Minimum 3 for a triangle-like star, typically 5 for a classic star.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("points", Required = global::Newtonsoft.Json.Required.Always)]
        public int Points { get; set; } = default!;

        /// <summary>
        /// The outer radius in pixels - the distance from center to the tips of the points.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("outerRadius", Required = global::Newtonsoft.Json.Required.Always)]
        public double OuterRadius { get; set; } = default!;

        /// <summary>
        /// The inner radius in pixels - the distance from center to the inner vertices.<br/>
        /// Should be smaller than outerRadius for a star effect.<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::Newtonsoft.Json.JsonProperty("innerRadius", Required = global::Newtonsoft.Json.Required.Always)]
        public double InnerRadius { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgStarShape" /> class.
        /// </summary>
        /// <param name="points">
        /// The number of points on the star.<br/>
        /// Minimum 3 for a triangle-like star, typically 5 for a classic star.<br/>
        /// Example: 5
        /// </param>
        /// <param name="outerRadius">
        /// The outer radius in pixels - the distance from center to the tips of the points.<br/>
        /// Example: 50
        /// </param>
        /// <param name="innerRadius">
        /// The inner radius in pixels - the distance from center to the inner vertices.<br/>
        /// Should be smaller than outerRadius for a star effect.<br/>
        /// Example: 25
        /// </param>
        /// <param name="type">
        /// The shape type - set to `star`.
        /// </param>
        public SvgStarShape(
            int points,
            double outerRadius,
            double innerRadius,
            global::G.SvgStarShapeType type)
        {
            this.Type = type;
            this.Points = points;
            this.OuterRadius = outerRadius;
            this.InnerRadius = innerRadius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgStarShape" /> class.
        /// </summary>
        public SvgStarShape()
        {
        }
    }
}