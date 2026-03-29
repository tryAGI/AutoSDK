//HintName: G.Models.ShapeAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ShapeAsset is used to add shapes to a video. The shape can be styled with a fill and a stroke.<br/>
    /// You can manipulate properties such as rotation to create dynamic effects like a diamond shape or stripes.
    /// </summary>
    public sealed partial class ShapeAsset
    {
        /// <summary>
        /// The type of asset - set to `shape` for shape.<br/>
        /// Default Value: shape
        /// </summary>
        /// <default>global::G.ShapeAssetType.Shape</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ShapeAssetType Type { get; set; } = global::G.ShapeAssetType.Shape;

        /// <summary>
        /// The shape to display.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shape", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShapeAssetShape Shape { get; set; } = default!;

        /// <summary>
        /// Sets the width of the bounding box in pixels. This value should be larger than the shape's width. If omitted, the entire viewport width and height will be used.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Sets the height of the bounding box in pixels. This value should be larger than the shape's height. If omitted, the entire viewport width and height will be used.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Specifies the fill style of the shape.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fill")]
        public global::G.ShapeAssetFill? Fill { get; set; }

        /// <summary>
        /// Specifies the stroke style of the shape.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stroke")]
        public global::G.ShapeAssetStroke? Stroke { get; set; }

        /// <summary>
        /// Configuration settings for the rectangle shape. Required when `shape` is set to `rectangle`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rectangle")]
        public global::G.ShapeAssetRectangle? Rectangle { get; set; }

        /// <summary>
        /// Configuration settings for the circle shape. Required when `shape` is set to `circle`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("circle")]
        public global::G.ShapeAssetCircle? Circle { get; set; }

        /// <summary>
        /// Configuration settings for the line shape. Required when `shape` is set to `line`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line")]
        public global::G.ShapeAssetLine? Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAsset" /> class.
        /// </summary>
        /// <param name="shape">
        /// The shape to display.
        /// </param>
        /// <param name="width">
        /// Sets the width of the bounding box in pixels. This value should be larger than the shape's width. If omitted, the entire viewport width and height will be used.<br/>
        /// Example: 800
        /// </param>
        /// <param name="height">
        /// Sets the height of the bounding box in pixels. This value should be larger than the shape's height. If omitted, the entire viewport width and height will be used.<br/>
        /// Example: 800
        /// </param>
        /// <param name="fill">
        /// Specifies the fill style of the shape.
        /// </param>
        /// <param name="stroke">
        /// Specifies the stroke style of the shape.
        /// </param>
        /// <param name="rectangle">
        /// Configuration settings for the rectangle shape. Required when `shape` is set to `rectangle`.
        /// </param>
        /// <param name="circle">
        /// Configuration settings for the circle shape. Required when `shape` is set to `circle`.
        /// </param>
        /// <param name="line">
        /// Configuration settings for the line shape. Required when `shape` is set to `line`.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `shape` for shape.<br/>
        /// Default Value: shape
        /// </param>
        public ShapeAsset(
            global::G.ShapeAssetShape shape,
            int? width,
            int? height,
            global::G.ShapeAssetFill? fill,
            global::G.ShapeAssetStroke? stroke,
            global::G.ShapeAssetRectangle? rectangle,
            global::G.ShapeAssetCircle? circle,
            global::G.ShapeAssetLine? line,
            global::G.ShapeAssetType type = global::G.ShapeAssetType.Shape)
        {
            this.Type = type;
            this.Shape = shape;
            this.Width = width;
            this.Height = height;
            this.Fill = fill;
            this.Stroke = stroke;
            this.Rectangle = rectangle;
            this.Circle = circle;
            this.Line = line;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAsset" /> class.
        /// </summary>
        public ShapeAsset()
        {
        }
    }
}