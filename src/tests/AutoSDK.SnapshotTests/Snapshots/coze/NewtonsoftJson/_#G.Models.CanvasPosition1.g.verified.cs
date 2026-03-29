//HintName: G.Models.CanvasPosition1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CanvasPosition1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public double? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left")]
        public double? Left { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top")]
        public double? Top { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CanvasPosition1" /> class.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        public CanvasPosition1(
            double? height,
            double? left,
            double? top,
            double? width)
        {
            this.Height = height;
            this.Left = left;
            this.Top = top;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CanvasPosition1" /> class.
        /// </summary>
        public CanvasPosition1()
        {
        }
    }
}