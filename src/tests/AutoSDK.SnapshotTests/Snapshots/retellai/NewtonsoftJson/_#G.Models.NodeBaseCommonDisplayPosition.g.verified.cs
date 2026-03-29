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
        [global::Newtonsoft.Json.JsonProperty("x")]
        public double? X { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseCommonDisplayPosition" /> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
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