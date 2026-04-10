//HintName: G.Models.SvgHeartShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A heart shape commonly used for love/like icons.<br/>
    /// The heart is defined by a single size parameter.
    /// </summary>
    public sealed partial class SvgHeartShape
    {
        /// <summary>
        /// The shape type - set to `heart`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SvgHeartShapeTypeJsonConverter))]
        public global::G.SvgHeartShapeType Type { get; set; }

        /// <summary>
        /// The size of the heart in pixels.<br/>
        /// This determines both the width and height proportionally.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public double Size { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgHeartShape" /> class.
        /// </summary>
        /// <param name="size">
        /// The size of the heart in pixels.<br/>
        /// This determines both the width and height proportionally.<br/>
        /// Example: 100
        /// </param>
        /// <param name="type">
        /// The shape type - set to `heart`.
        /// </param>
        public SvgHeartShape(
            double size,
            global::G.SvgHeartShapeType type)
        {
            this.Type = type;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgHeartShape" /> class.
        /// </summary>
        public SvgHeartShape()
        {
        }
    }
}