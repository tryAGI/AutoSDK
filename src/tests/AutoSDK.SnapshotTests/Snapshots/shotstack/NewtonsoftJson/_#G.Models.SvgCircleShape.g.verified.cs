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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SvgCircleShapeTypeJsonConverter))]
        public global::G.SvgCircleShapeType Type { get; set; }

        /// <summary>
        /// The radius of the circle in pixels.<br/>
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
        /// Initializes a new instance of the <see cref="SvgCircleShape" /> class.
        /// </summary>
        /// <param name="radius">
        /// The radius of the circle in pixels.<br/>
        /// Example: 50
        /// </param>
        /// <param name="type">
        /// The shape type - set to `circle`.
        /// </param>
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