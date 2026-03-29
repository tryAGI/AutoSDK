//HintName: G.Models.LlamaParseCropBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Crop box boundaries for processing only a portion of each page.<br/>
    /// All values are ratios from 0 to 1, where (0,0) is the top-left corner and (1,1) is<br/>
    /// the bottom-right corner. For example, to process only the top half of each page,<br/>
    /// set bottom=0.5 (keeping top=0, left=0, right=1).
    /// </summary>
    public sealed partial class LlamaParseCropBox
    {
        /// <summary>
        /// Bottom boundary as ratio (0-1). 0=top edge, 1=bottom edge. Content below this line is excluded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bottom")]
        public double? Bottom { get; set; }

        /// <summary>
        /// Left boundary as ratio (0-1). 0=left edge, 1=right edge. Content left of this line is excluded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left")]
        public double? Left { get; set; }

        /// <summary>
        /// Right boundary as ratio (0-1). 0=left edge, 1=right edge. Content right of this line is excluded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right")]
        public double? Right { get; set; }

        /// <summary>
        /// Top boundary as ratio (0-1). 0=top edge, 1=bottom edge. Content above this line is excluded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top")]
        public double? Top { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseCropBox" /> class.
        /// </summary>
        /// <param name="bottom">
        /// Bottom boundary as ratio (0-1). 0=top edge, 1=bottom edge. Content below this line is excluded
        /// </param>
        /// <param name="left">
        /// Left boundary as ratio (0-1). 0=left edge, 1=right edge. Content left of this line is excluded
        /// </param>
        /// <param name="right">
        /// Right boundary as ratio (0-1). 0=left edge, 1=right edge. Content right of this line is excluded
        /// </param>
        /// <param name="top">
        /// Top boundary as ratio (0-1). 0=top edge, 1=bottom edge. Content above this line is excluded
        /// </param>
        public LlamaParseCropBox(
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
        /// Initializes a new instance of the <see cref="LlamaParseCropBox" /> class.
        /// </summary>
        public LlamaParseCropBox()
        {
        }
    }
}