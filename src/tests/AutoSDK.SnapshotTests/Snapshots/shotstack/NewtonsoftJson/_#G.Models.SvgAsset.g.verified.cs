//HintName: G.Models.SvgAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The SvgAsset is used to add scalable vector graphics (SVG) shapes to a video.<br/>
    /// It provides two mutually exclusive ways to define shapes:<br/>
    /// **Option 1: Import SVG markup using `src`**<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "type": "svg",<br/>
    ///   "src": "&lt;svg width=\"100\" height=\"100\"&gt;&lt;circle cx=\"50\" cy=\"50\" r=\"40\" fill=\"#FF0000\"/&gt;&lt;/svg&gt;"<br/>
    /// }<br/>
    /// ```<br/>
    /// When using `src`, no other properties are allowed. The fill, stroke, and dimensions<br/>
    /// are automatically extracted from the SVG markup.<br/>
    /// **Option 2: Define shapes programmatically using `shape`**<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "type": "svg",<br/>
    ///   "shape": { "type": "circle", "radius": 50 },<br/>
    ///   "fill": { "type": "solid", "color": "#FF0000" }<br/>
    /// }<br/>
    /// ```<br/>
    /// When using `shape`, you can customize fill, stroke, shadow, transform, and other properties.<br/>
    /// The `src` property is not allowed in this mode.<br/>
    /// **Important:** You must provide either `src` OR `shape`, but not both.<br/>
    /// These two modes are mutually exclusive.<br/>
    /// **Available Shapes (Option 2 only):**<br/>
    /// - `rectangle` - Rectangles with optional rounded corners<br/>
    /// - `circle` - Perfect circles<br/>
    /// - `ellipse` - Ellipses/ovals with separate x and y radii<br/>
    /// - `line` - Straight lines with configurable thickness<br/>
    /// - `polygon` - Regular polygons (triangle, pentagon, hexagon, etc.)<br/>
    /// - `star` - Multi-pointed stars<br/>
    /// - `arrow` - Directional arrows<br/>
    /// - `heart` - Heart shapes<br/>
    /// - `cross` - Plus/cross shapes<br/>
    /// - `ring` - Donut/ring shapes<br/>
    /// - `path` - Custom shapes using SVG path data<br/>
    /// See [W3C SVG 2 Specification](https://www.w3.org/TR/SVG2/) for path data syntax.<br/>
    /// Example: {"type":"svg","shape":{"type":"star","points":5,"outerRadius":100,"innerRadius":50},"fill":{"type":"linear","angle":45,"stops":[{"offset":0,"color":"#FFD700"},{"offset":1,"color":"#FF6B6B"}],"opacity":1},"stroke":{"color":"#2C3E50","width":3,"opacity":1,"lineCap":"round","lineJoin":"round"},"transform":{"x":200,"y":150,"rotation":0,"scale":1},"opacity":1}
    /// </summary>
    public sealed partial class SvgAsset
    {
        /// <summary>
        /// The asset type - set to `svg` for SVG shapes.<br/>
        /// Default Value: svg<br/>
        /// Example: svg
        /// </summary>
        /// <default>global::G.SvgAssetType.Svg</default>
        /// <example>svg</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SvgAssetTypeJsonConverter))]
        public global::G.SvgAssetType Type { get; set; } = global::G.SvgAssetType.Svg;

        /// <summary>
        /// Raw SVG markup string to import. When provided, the shape is extracted<br/>
        /// automatically from the SVG content.<br/>
        /// **Supported elements:** `&lt;path&gt;`, `&lt;rect&gt;`, `&lt;circle&gt;`, `&lt;ellipse&gt;`,<br/>
        /// `&lt;line&gt;`, `&lt;polygon&gt;`, `&lt;polyline&gt;`<br/>
        /// **Automatically extracted:**<br/>
        /// - Path data (converted to a single combined path)<br/>
        /// - Fill color (from `fill` attribute or `style`)<br/>
        /// - Stroke color and width (from attributes or `style`)<br/>
        /// - Dimensions (from `width`/`height` or `viewBox`)<br/>
        /// - Opacity (from `opacity` attribute)<br/>
        /// **Important:** When using `src`, no other properties (shape, fill, stroke, etc.)<br/>
        /// are allowed. All styling must be defined within the SVG markup itself.<br/>
        /// Example: &lt;svg width="100" height="100"&gt;&lt;circle cx="50" cy="50" r="40" fill="#3498db"/&gt;&lt;/svg&gt;
        /// </summary>
        /// <example>&lt;svg width="100" height="100"&gt;&lt;circle cx="50" cy="50" r="40" fill="#3498db"/&gt;&lt;/svg&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("src")]
        public string? Src { get; set; }

        /// <summary>
        /// The shape definition for an SVG asset. Each shape type has its own specific<br/>
        /// properties. The `type` field determines which shape is rendered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shape")]
        public global::G.SvgShape? Shape { get; set; }

        /// <summary>
        /// Fill properties for SVG shapes. Supports solid colors and gradients.<br/>
        /// The fill defines how the interior of a shape is painted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fill")]
        public global::G.SvgFill? Fill { get; set; }

        /// <summary>
        /// Stroke (outline) properties for SVG shapes. The stroke defines how the outline<br/>
        /// of a shape is painted, including its color, width, and line style.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stroke")]
        public global::G.SvgStroke? Stroke { get; set; }

        /// <summary>
        /// Drop shadow properties for SVG shapes. Creates a shadow effect behind the shape.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shadow")]
        public global::G.SvgShadow? Shadow { get; set; }

        /// <summary>
        /// Transformation properties for positioning, rotating, and scaling SVG shapes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transform")]
        public global::G.SvgTransform? Transform { get; set; }

        /// <summary>
        /// The overall opacity of the entire shape (including fill, stroke, and shadow).<br/>
        /// `1` is fully opaque, `0` is fully transparent.<br/>
        /// This is applied on top of individual fill/stroke/shadow opacity values.<br/>
        /// **Note:** Only allowed when using `shape`, not with `src`.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The width of the bounding box in pixels.<br/>
        /// If specified, the shape may be scaled to fit within this width.<br/>
        /// If omitted, the shape uses its natural dimensions.<br/>
        /// **Note:** Only allowed when using `shape`, not with `src`.<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height of the bounding box in pixels.<br/>
        /// If specified, the shape may be scaled to fit within this height.<br/>
        /// If omitted, the shape uses its natural dimensions.<br/>
        /// **Note:** Only allowed when using `shape`, not with `src`.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// Raw SVG markup string to import. When provided, the shape is extracted<br/>
        /// automatically from the SVG content.<br/>
        /// **Supported elements:** `&lt;path&gt;`, `&lt;rect&gt;`, `&lt;circle&gt;`, `&lt;ellipse&gt;`,<br/>
        /// `&lt;line&gt;`, `&lt;polygon&gt;`, `&lt;polyline&gt;`<br/>
        /// **Automatically extracted:**<br/>
        /// - Path data (converted to a single combined path)<br/>
        /// - Fill color (from `fill` attribute or `style`)<br/>
        /// - Stroke color and width (from attributes or `style`)<br/>
        /// - Dimensions (from `width`/`height` or `viewBox`)<br/>
        /// - Opacity (from `opacity` attribute)<br/>
        /// **Important:** When using `src`, no other properties (shape, fill, stroke, etc.)<br/>
        /// are allowed. All styling must be defined within the SVG markup itself.<br/>
        /// Example: &lt;svg width="100" height="100"&gt;&lt;circle cx="50" cy="50" r="40" fill="#3498db"/&gt;&lt;/svg&gt;
        /// </param>
        /// <param name="shape">
        /// The shape definition for an SVG asset. Each shape type has its own specific<br/>
        /// properties. The `type` field determines which shape is rendered.
        /// </param>
        /// <param name="fill">
        /// Fill properties for SVG shapes. Supports solid colors and gradients.<br/>
        /// The fill defines how the interior of a shape is painted.
        /// </param>
        /// <param name="stroke">
        /// Stroke (outline) properties for SVG shapes. The stroke defines how the outline<br/>
        /// of a shape is painted, including its color, width, and line style.
        /// </param>
        /// <param name="shadow">
        /// Drop shadow properties for SVG shapes. Creates a shadow effect behind the shape.
        /// </param>
        /// <param name="transform">
        /// Transformation properties for positioning, rotating, and scaling SVG shapes.
        /// </param>
        /// <param name="opacity">
        /// The overall opacity of the entire shape (including fill, stroke, and shadow).<br/>
        /// `1` is fully opaque, `0` is fully transparent.<br/>
        /// This is applied on top of individual fill/stroke/shadow opacity values.<br/>
        /// **Note:** Only allowed when using `shape`, not with `src`.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="width">
        /// The width of the bounding box in pixels.<br/>
        /// If specified, the shape may be scaled to fit within this width.<br/>
        /// If omitted, the shape uses its natural dimensions.<br/>
        /// **Note:** Only allowed when using `shape`, not with `src`.<br/>
        /// Example: 400
        /// </param>
        /// <param name="height">
        /// The height of the bounding box in pixels.<br/>
        /// If specified, the shape may be scaled to fit within this height.<br/>
        /// If omitted, the shape uses its natural dimensions.<br/>
        /// **Note:** Only allowed when using `shape`, not with `src`.<br/>
        /// Example: 300
        /// </param>
        /// <param name="type">
        /// The asset type - set to `svg` for SVG shapes.<br/>
        /// Default Value: svg<br/>
        /// Example: svg
        /// </param>
        public SvgAsset(
            string? src,
            global::G.SvgShape? shape,
            global::G.SvgFill? fill,
            global::G.SvgStroke? stroke,
            global::G.SvgShadow? shadow,
            global::G.SvgTransform? transform,
            double? opacity,
            int? width,
            int? height,
            global::G.SvgAssetType type = global::G.SvgAssetType.Svg)
        {
            this.Type = type;
            this.Src = src;
            this.Shape = shape;
            this.Fill = fill;
            this.Stroke = stroke;
            this.Shadow = shadow;
            this.Transform = transform;
            this.Opacity = opacity;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgAsset" /> class.
        /// </summary>
        public SvgAsset()
        {
        }
    }
}