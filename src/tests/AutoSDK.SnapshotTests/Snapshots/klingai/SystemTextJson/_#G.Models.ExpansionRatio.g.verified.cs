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
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Top { get; set; }

        /// <summary>
        /// Expansion ratio for bottom direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Bottom { get; set; }

        /// <summary>
        /// Expansion ratio for left direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Left { get; set; }

        /// <summary>
        /// Expansion ratio for right direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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