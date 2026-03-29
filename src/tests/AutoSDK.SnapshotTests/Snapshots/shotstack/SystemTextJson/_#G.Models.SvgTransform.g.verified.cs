//HintName: G.Models.SvgTransform.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Transformation properties for positioning, rotating, and scaling SVG shapes.
    /// </summary>
    public sealed partial class SvgTransform
    {
        /// <summary>
        /// The x-coordinate position of the shape in pixels.<br/>
        /// Relative to the top-left corner of the viewport.<br/>
        /// Default Value: 0<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public double? X { get; set; }

        /// <summary>
        /// The y-coordinate position of the shape in pixels.<br/>
        /// Relative to the top-left corner of the viewport.<br/>
        /// Default Value: 0<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Rotation angle in degrees. Positive values rotate clockwise,<br/>
        /// negative values rotate counter-clockwise. Range: -360 to 360.<br/>
        /// Default Value: 0<br/>
        /// Example: 45
        /// </summary>
        /// <example>45</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation")]
        public double? Rotation { get; set; }

        /// <summary>
        /// Scale factor for the shape. `1` is original size, `2` is double size,<br/>
        /// `0.5` is half size. Must be greater than 0.<br/>
        /// Default Value: 1<br/>
        /// Example: 1.5F
        /// </summary>
        /// <example>1.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        public double? Scale { get; set; }

        /// <summary>
        /// The x-coordinate of the transformation origin as a value from 0 to 1.<br/>
        /// `0` is the left edge, `0.5` is the center, `1` is the right edge.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("originX")]
        public double? OriginX { get; set; }

        /// <summary>
        /// The y-coordinate of the transformation origin as a value from 0 to 1.<br/>
        /// `0` is the top edge, `0.5` is the center, `1` is the bottom edge.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("originY")]
        public double? OriginY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgTransform" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-coordinate position of the shape in pixels.<br/>
        /// Relative to the top-left corner of the viewport.<br/>
        /// Default Value: 0<br/>
        /// Example: 100
        /// </param>
        /// <param name="y">
        /// The y-coordinate position of the shape in pixels.<br/>
        /// Relative to the top-left corner of the viewport.<br/>
        /// Default Value: 0<br/>
        /// Example: 100
        /// </param>
        /// <param name="rotation">
        /// Rotation angle in degrees. Positive values rotate clockwise,<br/>
        /// negative values rotate counter-clockwise. Range: -360 to 360.<br/>
        /// Default Value: 0<br/>
        /// Example: 45
        /// </param>
        /// <param name="scale">
        /// Scale factor for the shape. `1` is original size, `2` is double size,<br/>
        /// `0.5` is half size. Must be greater than 0.<br/>
        /// Default Value: 1<br/>
        /// Example: 1.5F
        /// </param>
        /// <param name="originX">
        /// The x-coordinate of the transformation origin as a value from 0 to 1.<br/>
        /// `0` is the left edge, `0.5` is the center, `1` is the right edge.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="originY">
        /// The y-coordinate of the transformation origin as a value from 0 to 1.<br/>
        /// `0` is the top edge, `0.5` is the center, `1` is the bottom edge.<br/>
        /// Default Value: 0.5F<br/>
        /// Example: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgTransform(
            double? x,
            double? y,
            double? rotation,
            double? scale,
            double? originX,
            double? originY)
        {
            this.X = x;
            this.Y = y;
            this.Rotation = rotation;
            this.Scale = scale;
            this.OriginX = originX;
            this.OriginY = originY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgTransform" /> class.
        /// </summary>
        public SvgTransform()
        {
        }
    }
}