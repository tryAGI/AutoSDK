//HintName: G.Models.RichTextPadding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Padding properties for individual sides of the text bounding box.
    /// </summary>
    public sealed partial class RichTextPadding
    {
        /// <summary>
        /// Top padding in pixels.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("top")]
        public double? Top { get; set; }

        /// <summary>
        /// Right padding in pixels.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("right")]
        public double? Right { get; set; }

        /// <summary>
        /// Bottom padding in pixels.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("bottom")]
        public double? Bottom { get; set; }

        /// <summary>
        /// Left padding in pixels.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("left")]
        public double? Left { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextPadding" /> class.
        /// </summary>
        /// <param name="top">
        /// Top padding in pixels.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        /// <param name="right">
        /// Right padding in pixels.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        /// <param name="bottom">
        /// Bottom padding in pixels.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        /// <param name="left">
        /// Left padding in pixels.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        public RichTextPadding(
            double? top,
            double? right,
            double? bottom,
            double? left)
        {
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
            this.Left = left;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextPadding" /> class.
        /// </summary>
        public RichTextPadding()
        {
        }
    }
}