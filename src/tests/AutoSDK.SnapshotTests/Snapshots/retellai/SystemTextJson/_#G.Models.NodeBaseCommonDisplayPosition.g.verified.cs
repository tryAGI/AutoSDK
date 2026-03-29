//HintName: G.Models.NodeBaseCommonDisplayPosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Position for frontend display
    /// </summary>
    public sealed partial class NodeBaseCommonDisplayPosition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public double? X { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseCommonDisplayPosition" /> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeBaseCommonDisplayPosition(
            double? x,
            double? y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseCommonDisplayPosition" /> class.
        /// </summary>
        public NodeBaseCommonDisplayPosition()
        {
        }
    }
}