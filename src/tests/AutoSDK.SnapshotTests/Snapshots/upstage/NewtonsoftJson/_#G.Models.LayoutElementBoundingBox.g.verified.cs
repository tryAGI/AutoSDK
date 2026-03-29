//HintName: G.Models.LayoutElementBoundingBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bounding box coordinates.
    /// </summary>
    public sealed partial class LayoutElementBoundingBox
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x")]
        public double? X { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public double? Y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public double? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutElementBoundingBox" /> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public LayoutElementBoundingBox(
            double? x,
            double? y,
            double? width,
            double? height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutElementBoundingBox" /> class.
        /// </summary>
        public LayoutElementBoundingBox()
        {
        }
    }
}