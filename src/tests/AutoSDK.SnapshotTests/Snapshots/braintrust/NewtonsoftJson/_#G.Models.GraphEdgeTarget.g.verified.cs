//HintName: G.Models.GraphEdgeTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphEdgeTarget
    {
        /// <summary>
        /// The id of the node in the graph
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node", Required = global::Newtonsoft.Json.Required.Always)]
        public string Node { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variable", Required = global::Newtonsoft.Json.Required.Always)]
        public string Variable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphEdgeTarget" /> class.
        /// </summary>
        /// <param name="node">
        /// The id of the node in the graph
        /// </param>
        /// <param name="variable"></param>
        public GraphEdgeTarget(
            string node,
            string variable)
        {
            this.Node = node ?? throw new global::System.ArgumentNullException(nameof(node));
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphEdgeTarget" /> class.
        /// </summary>
        public GraphEdgeTarget()
        {
        }
    }
}