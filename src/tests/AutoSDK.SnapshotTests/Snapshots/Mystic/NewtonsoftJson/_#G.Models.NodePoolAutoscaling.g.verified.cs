//HintName: G.Models.NodePoolAutoscaling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class NodePoolAutoscaling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinNodes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxNodes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public int CurrentNodes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePoolAutoscaling" /> class.
        /// </summary>
        /// <param name="minNodes"></param>
        /// <param name="maxNodes"></param>
        /// <param name="currentNodes"></param>
        public NodePoolAutoscaling(
            int minNodes,
            int maxNodes,
            int currentNodes)
        {
            this.MinNodes = minNodes;
            this.MaxNodes = maxNodes;
            this.CurrentNodes = currentNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePoolAutoscaling" /> class.
        /// </summary>
        public NodePoolAutoscaling()
        {
        }
    }
}