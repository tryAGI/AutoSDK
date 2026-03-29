//HintName: G.Models.SvgLineShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A straight line shape with a specified length and thickness.<br/>
    /// The line is drawn horizontally by default and can be rotated using transform.
    /// </summary>
    public sealed partial class SvgLineShape
    {
        /// <summary>
        /// The shape type - set to `line`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SvgLineShapeType Type { get; set; }

        /// <summary>
        /// The length of the line in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("length", Required = global::Newtonsoft.Json.Required.Always)]
        public double Length { get; set; } = default!;

        /// <summary>
        /// The thickness of the line in pixels.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::Newtonsoft.Json.JsonProperty("thickness", Required = global::Newtonsoft.Json.Required.Always)]
        public double Thickness { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgLineShape" /> class.
        /// </summary>
        /// <param name="length">
        /// The length of the line in pixels.<br/>
        /// Example: 100
        /// </param>
        /// <param name="thickness">
        /// The thickness of the line in pixels.<br/>
        /// Example: 4
        /// </param>
        /// <param name="type">
        /// The shape type - set to `line`.
        /// </param>
        public SvgLineShape(
            double length,
            double thickness,
            global::G.SvgLineShapeType type)
        {
            this.Type = type;
            this.Length = length;
            this.Thickness = thickness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgLineShape" /> class.
        /// </summary>
        public SvgLineShape()
        {
        }
    }
}