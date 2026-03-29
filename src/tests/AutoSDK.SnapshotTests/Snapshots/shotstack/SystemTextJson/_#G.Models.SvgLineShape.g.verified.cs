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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgLineShapeTypeJsonConverter))]
        public global::G.SvgLineShapeType Type { get; set; }

        /// <summary>
        /// The length of the line in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Length { get; set; }

        /// <summary>
        /// The thickness of the line in pixels.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thickness")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Thickness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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