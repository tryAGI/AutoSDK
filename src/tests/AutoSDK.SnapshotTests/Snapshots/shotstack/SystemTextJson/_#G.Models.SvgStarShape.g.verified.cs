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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgStarShapeTypeJsonConverter))]
        public global::G.SvgStarShapeType Type { get; set; }

        /// <summary>
        /// The number of points on the star.<br/>
        /// Minimum 3 for a triangle-like star, typically 5 for a classic star.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Points { get; set; }

        /// <summary>
        /// The outer radius in pixels - the distance from center to the tips of the points.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outerRadius")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OuterRadius { get; set; }

        /// <summary>
        /// The inner radius in pixels - the distance from center to the inner vertices.<br/>
        /// Should be smaller than outerRadius for a star effect.<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("innerRadius")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InnerRadius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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