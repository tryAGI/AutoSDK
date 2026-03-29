//HintName: G.Models.ExpansionRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpansionRatio
    {
        /// <summary>
        /// Expansion ratio for top direction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top", Required = global::Newtonsoft.Json.Required.Always)]
        public double Top { get; set; } = default!;

        /// <summary>
        /// Expansion ratio for bottom direction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bottom", Required = global::Newtonsoft.Json.Required.Always)]
        public double Bottom { get; set; } = default!;

        /// <summary>
        /// Expansion ratio for left direction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public double Left { get; set; } = default!;

        /// <summary>
        /// Expansion ratio for right direction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right", Required = global::Newtonsoft.Json.Required.Always)]
        public double Right { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpansionRatio" /> class.
        /// </summary>
        /// <param name="top">
        /// Expansion ratio for top direction.
        /// </param>
        /// <param name="bottom">
        /// Expansion ratio for bottom direction.
        /// </param>
        /// <param name="left">
        /// Expansion ratio for left direction.
        /// </param>
        /// <param name="right">
        /// Expansion ratio for right direction.
        /// </param>
        public ExpansionRatio(
            double top,
            double bottom,
            double left,
            double right)
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpansionRatio" /> class.
        /// </summary>
        public ExpansionRatio()
        {
        }
    }
}