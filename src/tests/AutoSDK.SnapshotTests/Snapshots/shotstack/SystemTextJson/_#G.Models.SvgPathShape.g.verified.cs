//HintName: G.Models.SvgPathShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A custom shape defined by SVG path data.<br/>
    /// Supports all standard SVG path commands for creating complex shapes.<br/>
    /// **Path Commands:**<br/>
    /// - `M x y` / `m dx dy` - Move to (absolute/relative)<br/>
    /// - `L x y` / `l dx dy` - Line to<br/>
    /// - `H x` / `h dx` - Horizontal line to<br/>
    /// - `V y` / `v dy` - Vertical line to<br/>
    /// - `C x1 y1 x2 y2 x y` / `c` - Cubic Bezier curve<br/>
    /// - `S x2 y2 x y` / `s` - Smooth cubic Bezier<br/>
    /// - `Q x1 y1 x y` / `q` - Quadratic Bezier curve<br/>
    /// - `T x y` / `t` - Smooth quadratic Bezier<br/>
    /// - `A rx ry angle large-arc sweep x y` / `a` - Elliptical arc<br/>
    /// - `Z` / `z` - Close path
    /// </summary>
    public sealed partial class SvgPathShape
    {
        /// <summary>
        /// The shape type - set to `path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SvgPathShapeTypeJsonConverter))]
        public global::G.SvgPathShapeType Type { get; set; }

        /// <summary>
        /// The SVG path data string defining the shape.<br/>
        /// Uses standard SVG path commands (M, L, C, Q, A, Z, etc.).<br/>
        /// Example: `M 0 0 L 100 0 L 100 100 L 0 100 Z` draws a square.<br/>
        /// Example: M 0 0 L 100 0 L 50 86.6 Z
        /// </summary>
        /// <example>M 0 0 L 100 0 L 50 86.6 Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("d")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string D { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgPathShape" /> class.
        /// </summary>
        /// <param name="d">
        /// The SVG path data string defining the shape.<br/>
        /// Uses standard SVG path commands (M, L, C, Q, A, Z, etc.).<br/>
        /// Example: `M 0 0 L 100 0 L 100 100 L 0 100 Z` draws a square.<br/>
        /// Example: M 0 0 L 100 0 L 50 86.6 Z
        /// </param>
        /// <param name="type">
        /// The shape type - set to `path`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgPathShape(
            string d,
            global::G.SvgPathShapeType type)
        {
            this.Type = type;
            this.D = d ?? throw new global::System.ArgumentNullException(nameof(d));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgPathShape" /> class.
        /// </summary>
        public SvgPathShape()
        {
        }
    }
}