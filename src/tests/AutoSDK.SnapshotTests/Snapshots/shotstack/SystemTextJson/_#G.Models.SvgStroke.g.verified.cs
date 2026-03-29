//HintName: G.Models.SvgStroke.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stroke (outline) properties for SVG shapes. The stroke defines how the outline<br/>
    /// of a shape is painted, including its color, width, and line style.
    /// </summary>
    public sealed partial class SvgStroke
    {
        /// <summary>
        /// The stroke color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #2c3e50
        /// </summary>
        /// <example>#2c3e50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The width of the stroke in pixels. Must be greater than 0.<br/>
        /// Larger values create thicker outlines.<br/>
        /// Default Value: 1<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// The opacity of the stroke where `1` is opaque and `0` is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The shape at the end of open paths (lines, polylines, unclosed paths).<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;`butt` - flat edge perpendicular to the line (default)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`round` - semicircular cap extending beyond the endpoint&lt;/li&gt;<br/>
        ///   &lt;li&gt;`square` - rectangular cap extending beyond the endpoint&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: butt<br/>
        /// Example: round
        /// </summary>
        /// <example>round</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineCap")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgStrokeLineCapJsonConverter))]
        public global::G.SvgStrokeLineCap? LineCap { get; set; }

        /// <summary>
        /// The shape at the corners where two lines meet.<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;`miter` - sharp corner (default)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`round` - rounded corner&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bevel` - flattened corner&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: miter<br/>
        /// Example: round
        /// </summary>
        /// <example>round</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineJoin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgStrokeLineJoinJsonConverter))]
        public global::G.SvgStrokeLineJoin? LineJoin { get; set; }

        /// <summary>
        /// Pattern of dashes and gaps for the stroke. An array of numbers where<br/>
        /// odd indices are dash lengths and even indices are gap lengths.<br/>
        /// For example, `[10, 5]` creates 10px dashes with 5px gaps.<br/>
        /// `[10, 5, 2, 5]` creates alternating 10px and 2px dashes with 5px gaps.<br/>
        /// Example: [10, 5]
        /// </summary>
        /// <example>[10, 5]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashArray")]
        public global::System.Collections.Generic.IList<double>? DashArray { get; set; }

        /// <summary>
        /// Offset for the dash pattern. Positive values shift the pattern<br/>
        /// forward along the path, negative values shift it backward.<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashOffset")]
        public double? DashOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgStroke" /> class.
        /// </summary>
        /// <param name="color">
        /// The stroke color using hexadecimal color notation.<br/>
        /// Default Value: #000000<br/>
        /// Example: #2c3e50
        /// </param>
        /// <param name="width">
        /// The width of the stroke in pixels. Must be greater than 0.<br/>
        /// Larger values create thicker outlines.<br/>
        /// Default Value: 1<br/>
        /// Example: 2
        /// </param>
        /// <param name="opacity">
        /// The opacity of the stroke where `1` is opaque and `0` is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="lineCap">
        /// The shape at the end of open paths (lines, polylines, unclosed paths).<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;`butt` - flat edge perpendicular to the line (default)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`round` - semicircular cap extending beyond the endpoint&lt;/li&gt;<br/>
        ///   &lt;li&gt;`square` - rectangular cap extending beyond the endpoint&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: butt<br/>
        /// Example: round
        /// </param>
        /// <param name="lineJoin">
        /// The shape at the corners where two lines meet.<br/>
        /// &lt;ul&gt;<br/>
        ///   &lt;li&gt;`miter` - sharp corner (default)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`round` - rounded corner&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bevel` - flattened corner&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: miter<br/>
        /// Example: round
        /// </param>
        /// <param name="dashArray">
        /// Pattern of dashes and gaps for the stroke. An array of numbers where<br/>
        /// odd indices are dash lengths and even indices are gap lengths.<br/>
        /// For example, `[10, 5]` creates 10px dashes with 5px gaps.<br/>
        /// `[10, 5, 2, 5]` creates alternating 10px and 2px dashes with 5px gaps.<br/>
        /// Example: [10, 5]
        /// </param>
        /// <param name="dashOffset">
        /// Offset for the dash pattern. Positive values shift the pattern<br/>
        /// forward along the path, negative values shift it backward.<br/>
        /// Default Value: 0<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgStroke(
            string? color,
            double? width,
            double? opacity,
            global::G.SvgStrokeLineCap? lineCap,
            global::G.SvgStrokeLineJoin? lineJoin,
            global::System.Collections.Generic.IList<double>? dashArray,
            double? dashOffset)
        {
            this.Color = color;
            this.Width = width;
            this.Opacity = opacity;
            this.LineCap = lineCap;
            this.LineJoin = lineJoin;
            this.DashArray = dashArray;
            this.DashOffset = dashOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgStroke" /> class.
        /// </summary>
        public SvgStroke()
        {
        }
    }
}