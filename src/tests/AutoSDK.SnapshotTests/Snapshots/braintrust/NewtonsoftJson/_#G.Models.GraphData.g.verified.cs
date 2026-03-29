//HintName: G.Models.GraphData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This feature is preliminary and unsupported.
    /// </summary>
    public sealed partial class GraphData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GraphDataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public object Nodes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.GraphEdge> Edges { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphData" /> class.
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
        /// <param name="type"></param>
        public GraphData(
            object nodes,
            global::System.Collections.Generic.Dictionary<string, global::G.GraphEdge> edges,
            global::G.GraphDataType type)
        {
            this.Type = type;
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphData" /> class.
        /// </summary>
        public GraphData()
        {
        }
    }
}