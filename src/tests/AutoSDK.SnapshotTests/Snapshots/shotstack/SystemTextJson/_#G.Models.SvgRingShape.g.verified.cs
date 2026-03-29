//HintName: G.Models.SvgRingShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ring (donut/annulus) shape - a circle with a circular hole in the center.<br/>
    /// The ring is defined by outer and inner radii.
    /// </summary>
    public sealed partial class SvgRingShape
    {
        /// <summary>
        /// The shape type - set to `ring`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgRingShapeTypeJsonConverter))]
        public global::G.SvgRingShapeType Type { get; set; }

        /// <summary>
        /// The outer radius of the ring in pixels.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outerRadius")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OuterRadius { get; set; }

        /// <summary>
        /// The inner radius (hole) of the ring in pixels.<br/>
        /// Must be smaller than outerRadius.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("innerRadius")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InnerRadius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgRingShape" /> class.
        /// </summary>
        /// <param name="outerRadius">
        /// The outer radius of the ring in pixels.<br/>
        /// Example: 50
        /// </param>
        /// <param name="innerRadius">
        /// The inner radius (hole) of the ring in pixels.<br/>
        /// Must be smaller than outerRadius.<br/>
        /// Example: 30
        /// </param>
        /// <param name="type">
        /// The shape type - set to `ring`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgRingShape(
            double outerRadius,
            double innerRadius,
            global::G.SvgRingShapeType type)
        {
            this.Type = type;
            this.OuterRadius = outerRadius;
            this.InnerRadius = innerRadius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgRingShape" /> class.
        /// </summary>
        public SvgRingShape()
        {
        }
    }
}