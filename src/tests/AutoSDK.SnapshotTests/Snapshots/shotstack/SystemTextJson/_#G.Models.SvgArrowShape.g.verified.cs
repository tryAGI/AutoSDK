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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgArrowShapeTypeJsonConverter))]
        public global::G.SvgArrowShapeType Type { get; set; }

        /// <summary>
        /// The total length of the arrow from tail to tip in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Length { get; set; }

        /// <summary>
        /// The width of the arrow head (the widest part) in pixels.<br/>
        /// Example: 40
        /// </summary>
        /// <example>40</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headWidth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HeadWidth { get; set; }

        /// <summary>
        /// The length of the arrow head portion in pixels.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HeadLength { get; set; }

        /// <summary>
        /// The width of the arrow shaft (body) in pixels.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("shaftWidth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ShaftWidth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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