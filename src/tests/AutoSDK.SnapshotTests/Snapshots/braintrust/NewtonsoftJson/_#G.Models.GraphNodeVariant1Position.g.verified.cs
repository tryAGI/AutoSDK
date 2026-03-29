//HintName: G.Models.GraphNodeVariant1Position.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The position of the node
    /// </summary>
    public sealed partial class GraphNodeVariant1Position
    {
        /// <summary>
        /// The x position of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public double X { get; set; } = default!;

        /// <summary>
        /// The y position of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public double Y { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant1Position" /> class.
        /// </summary>
        /// <param name="x">
        /// The x position of the node
        /// </param>
        /// <param name="y">
        /// The y position of the node
        /// </param>
        public GraphNodeVariant1Position(
            double x,
            double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant1Position" /> class.
        /// </summary>
        public GraphNodeVariant1Position()
        {
        }
    }
}