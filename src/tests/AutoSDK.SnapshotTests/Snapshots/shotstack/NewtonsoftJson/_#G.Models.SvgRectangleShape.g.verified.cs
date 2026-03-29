//HintName: G.Models.SvgRectangleShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A rectangle shape with optional rounded corners.<br/>
    /// The rectangle is defined by its width and height dimensions.
    /// </summary>
    public sealed partial class SvgRectangleShape
    {
        /// <summary>
        /// The shape type - set to `rectangle`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SvgRectangleShapeType Type { get; set; }

        /// <summary>
        /// The width of the rectangle in pixels.<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public double Width { get; set; } = default!;

        /// <summary>
        /// The height of the rectangle in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public double Height { get; set; } = default!;

        /// <summary>
        /// The corner radius for rounded corners in pixels.<br/>
        /// Set to `0` for sharp corners. The radius is automatically clamped<br/>
        /// to half of the smallest dimension.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("cornerRadius")]
        public double? CornerRadius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgRectangleShape" /> class.
        /// </summary>
        /// <param name="width">
        /// The width of the rectangle in pixels.<br/>
        /// Example: 200
        /// </param>
        /// <param name="height">
        /// The height of the rectangle in pixels.<br/>
        /// Example: 100
        /// </param>
        /// <param name="type">
        /// The shape type - set to `rectangle`.
        /// </param>
        /// <param name="cornerRadius">
        /// The corner radius for rounded corners in pixels.<br/>
        /// Set to `0` for sharp corners. The radius is automatically clamped<br/>
        /// to half of the smallest dimension.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        public SvgRectangleShape(
            double width,
            double height,
            global::G.SvgRectangleShapeType type,
            double? cornerRadius)
        {
            this.Type = type;
            this.Width = width;
            this.Height = height;
            this.CornerRadius = cornerRadius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgRectangleShape" /> class.
        /// </summary>
        public SvgRectangleShape()
        {
        }
    }
}