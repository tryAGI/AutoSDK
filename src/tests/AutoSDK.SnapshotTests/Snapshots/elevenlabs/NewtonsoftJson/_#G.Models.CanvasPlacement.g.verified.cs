//HintName: G.Models.CanvasPlacement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines asset positioning and transformation on canvas.
    /// </summary>
    public sealed partial class CanvasPlacement
    {
        /// <summary>
        /// Default Value: 0.5F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x_relative")]
        public double? XRelative { get; set; }

        /// <summary>
        /// Default Value: 0.5F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y_relative")]
        public double? YRelative { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale_x")]
        public double? ScaleX { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale_y")]
        public double? ScaleY { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pivot_x")]
        public double? PivotX { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pivot_y")]
        public double? PivotY { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skew_x")]
        public double? SkewX { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skew_y")]
        public double? SkewY { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop_top")]
        public double? CropTop { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop_right")]
        public double? CropRight { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop_bottom")]
        public double? CropBottom { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop_left")]
        public double? CropLeft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CanvasPlacement" /> class.
        /// </summary>
        /// <param name="xRelative">
        /// Default Value: 0.5F
        /// </param>
        /// <param name="yRelative">
        /// Default Value: 0.5F
        /// </param>
        /// <param name="scaleX">
        /// Default Value: 1F
        /// </param>
        /// <param name="scaleY">
        /// Default Value: 1F
        /// </param>
        /// <param name="pivotX">
        /// Default Value: 0F
        /// </param>
        /// <param name="pivotY">
        /// Default Value: 0F
        /// </param>
        /// <param name="skewX">
        /// Default Value: 0F
        /// </param>
        /// <param name="skewY">
        /// Default Value: 0F
        /// </param>
        /// <param name="cropTop">
        /// Default Value: 0F
        /// </param>
        /// <param name="cropRight">
        /// Default Value: 0F
        /// </param>
        /// <param name="cropBottom">
        /// Default Value: 0F
        /// </param>
        /// <param name="cropLeft">
        /// Default Value: 0F
        /// </param>
        public CanvasPlacement(
            double? xRelative,
            double? yRelative,
            double? scaleX,
            double? scaleY,
            double? pivotX,
            double? pivotY,
            double? skewX,
            double? skewY,
            double? cropTop,
            double? cropRight,
            double? cropBottom,
            double? cropLeft)
        {
            this.XRelative = xRelative;
            this.YRelative = yRelative;
            this.ScaleX = scaleX;
            this.ScaleY = scaleY;
            this.PivotX = pivotX;
            this.PivotY = pivotY;
            this.SkewX = skewX;
            this.SkewY = skewY;
            this.CropTop = cropTop;
            this.CropRight = cropRight;
            this.CropBottom = cropBottom;
            this.CropLeft = cropLeft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CanvasPlacement" /> class.
        /// </summary>
        public CanvasPlacement()
        {
        }
    }
}