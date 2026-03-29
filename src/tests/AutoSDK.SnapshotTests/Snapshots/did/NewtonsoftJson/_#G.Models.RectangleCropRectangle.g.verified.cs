//HintName: G.Models.RectangleCropRectangle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of numbers between 0 and 1 representing the top, left, right and bottom of the crop.<br/>
    /// Each number correlates to the distance from the top left corner of the image, relative the the image width.<br/>
    /// For example, right: 0.75 means that the right side of the crop is 75% of the image width from the left side.
    /// </summary>
    public sealed partial class RectangleCropRectangle
    {
        /// <summary>
        /// Bottom position.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("bottom", Required = global::Newtonsoft.Json.Required.Always)]
        public double Bottom { get; set; } = default!;

        /// <summary>
        /// Right position.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public double Right { get; set; } = default!;

        /// <summary>
        /// Left position.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public double Left { get; set; } = default!;

        /// <summary>
        /// Top position.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("top", Required = global::Newtonsoft.Json.Required.Always)]
        public double Top { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleCropRectangle" /> class.
        /// </summary>
        /// <param name="bottom">
        /// Bottom position.<br/>
        /// Example: 1
        /// </param>
        /// <param name="right">
        /// Right position.<br/>
        /// Example: 1
        /// </param>
        /// <param name="left">
        /// Left position.<br/>
        /// Example: 0
        /// </param>
        /// <param name="top">
        /// Top position.<br/>
        /// Example: 0
        /// </param>
        public RectangleCropRectangle(
            double bottom,
            double right,
            double left,
            double top)
        {
            this.Bottom = bottom;
            this.Right = right;
            this.Left = left;
            this.Top = top;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleCropRectangle" /> class.
        /// </summary>
        public RectangleCropRectangle()
        {
        }
    }
}