//HintName: G.Models.SvgArrowShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An arrow shape pointing to the right by default.<br/>
    /// Use transform rotation to change direction.
    /// </summary>
    public sealed partial class SvgArrowShape
    {
        /// <summary>
        /// The shape type - set to `arrow`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SvgArrowShapeType Type { get; set; }

        /// <summary>
        /// The total length of the arrow from tail to tip in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("length", Required = global::Newtonsoft.Json.Required.Always)]
        public double Length { get; set; } = default!;

        /// <summary>
        /// The width of the arrow head (the widest part) in pixels.<br/>
        /// Example: 40
        /// </summary>
        /// <example>40</example>
        [global::Newtonsoft.Json.JsonProperty("headWidth", Required = global::Newtonsoft.Json.Required.Always)]
        public double HeadWidth { get; set; } = default!;

        /// <summary>
        /// The length of the arrow head portion in pixels.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("headLength", Required = global::Newtonsoft.Json.Required.Always)]
        public double HeadLength { get; set; } = default!;

        /// <summary>
        /// The width of the arrow shaft (body) in pixels.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::Newtonsoft.Json.JsonProperty("shaftWidth", Required = global::Newtonsoft.Json.Required.Always)]
        public double ShaftWidth { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgArrowShape" /> class.
        /// </summary>
        /// <param name="length">
        /// The total length of the arrow from tail to tip in pixels.<br/>
        /// Example: 100
        /// </param>
        /// <param name="headWidth">
        /// The width of the arrow head (the widest part) in pixels.<br/>
        /// Example: 40
        /// </param>
        /// <param name="headLength">
        /// The length of the arrow head portion in pixels.<br/>
        /// Example: 30
        /// </param>
        /// <param name="shaftWidth">
        /// The width of the arrow shaft (body) in pixels.<br/>
        /// Example: 20
        /// </param>
        /// <param name="type">
        /// The shape type - set to `arrow`.
        /// </param>
        public SvgArrowShape(
            double length,
            double headWidth,
            double headLength,
            double shaftWidth,
            global::G.SvgArrowShapeType type)
        {
            this.Type = type;
            this.Length = length;
            this.HeadWidth = headWidth;
            this.HeadLength = headLength;
            this.ShaftWidth = shaftWidth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgArrowShape" /> class.
        /// </summary>
        public SvgArrowShape()
        {
        }
    }
}