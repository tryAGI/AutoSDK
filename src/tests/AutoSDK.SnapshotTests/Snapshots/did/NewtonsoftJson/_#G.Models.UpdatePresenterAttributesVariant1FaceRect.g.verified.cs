//HintName: G.Models.UpdatePresenterAttributesVariant1FaceRect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePresenterAttributesVariant1FaceRect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top", Required = global::Newtonsoft.Json.Required.Always)]
        public double Top { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public double Left { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bottom", Required = global::Newtonsoft.Json.Required.Always)]
        public double Bottom { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public double Right { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesVariant1FaceRect" /> class.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="right"></param>
        public UpdatePresenterAttributesVariant1FaceRect(
            double top,
            double left,
            double bottom,
            double right)
        {
            this.Top = top;
            this.Left = left;
            this.Bottom = bottom;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesVariant1FaceRect" /> class.
        /// </summary>
        public UpdatePresenterAttributesVariant1FaceRect()
        {
        }
    }
}