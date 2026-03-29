//HintName: G.Models.SvgCrossShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A cross or plus shape with equal or different arm lengths.<br/>
    /// Can be styled as a plus sign (+) or a cross (x with rotation).
    /// </summary>
    public sealed partial class SvgCrossShape
    {
        /// <summary>
        /// The shape type - set to `cross`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgCrossShapeTypeJsonConverter))]
        public global::G.SvgCrossShapeType Type { get; set; }

        /// <summary>
        /// The total width of the cross in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Width { get; set; }

        /// <summary>
        /// The total height of the cross in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Height { get; set; }

        /// <summary>
        /// The thickness of the cross arms in pixels.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thickness")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Thickness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgCrossShape" /> class.
        /// </summary>
        /// <param name="width">
        /// The total width of the cross in pixels.<br/>
        /// Example: 100
        /// </param>
        /// <param name="height">
        /// The total height of the cross in pixels.<br/>
        /// Example: 100
        /// </param>
        /// <param name="thickness">
        /// The thickness of the cross arms in pixels.<br/>
        /// Example: 20
        /// </param>
        /// <param name="type">
        /// The shape type - set to `cross`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgCrossShape(
            double width,
            double height,
            double thickness,
            global::G.SvgCrossShapeType type)
        {
            this.Type = type;
            this.Width = width;
            this.Height = height;
            this.Thickness = thickness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgCrossShape" /> class.
        /// </summary>
        public SvgCrossShape()
        {
        }
    }
}