//HintName: G.Models.AutoModeCropBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Crop box options for auto mode parsing configuration.
    /// </summary>
    public sealed partial class AutoModeCropBox
    {
        /// <summary>
        /// Bottom boundary of crop box as ratio (0-1)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bottom")]
        public double? Bottom { get; set; }

        /// <summary>
        /// Left boundary of crop box as ratio (0-1)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left")]
        public double? Left { get; set; }

        /// <summary>
        /// Right boundary of crop box as ratio (0-1)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right")]
        public double? Right { get; set; }

        /// <summary>
        /// Top boundary of crop box as ratio (0-1)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top")]
        public double? Top { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeCropBox" /> class.
        /// </summary>
        /// <param name="bottom">
        /// Bottom boundary of crop box as ratio (0-1)
        /// </param>
        /// <param name="left">
        /// Left boundary of crop box as ratio (0-1)
        /// </param>
        /// <param name="right">
        /// Right boundary of crop box as ratio (0-1)
        /// </param>
        /// <param name="top">
        /// Top boundary of crop box as ratio (0-1)
        /// </param>
        public AutoModeCropBox(
            double? bottom,
            double? left,
            double? right,
            double? top)
        {
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
            this.Top = top;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeCropBox" /> class.
        /// </summary>
        public AutoModeCropBox()
        {
        }
    }
}