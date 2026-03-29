//HintName: G.Models.Edge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Edge
    {
        /// <summary>
        /// The source node name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_node_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceNodeName { get; set; } = default!;

        /// <summary>
        /// The target node name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_node_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetNodeName { get; set; } = default!;

        /// <summary>
        /// Whether multiple conditionals use AND logic (true) or OR logic (false).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_and", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAnd { get; set; } = default!;

        /// <summary>
        /// At least one conditional.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditionals", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EdgeConditional> Conditionals { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Edge" /> class.
        /// </summary>
        /// <param name="sourceNodeName">
        /// The source node name.
        /// </param>
        /// <param name="targetNodeName">
        /// The target node name.
        /// </param>
        /// <param name="isAnd">
        /// Whether multiple conditionals use AND logic (true) or OR logic (false).
        /// </param>
        /// <param name="conditionals">
        /// At least one conditional.
        /// </param>
        public Edge(
            string sourceNodeName,
            string targetNodeName,
            bool isAnd,
            global::System.Collections.Generic.IList<global::G.EdgeConditional> conditionals)
        {
            this.SourceNodeName = sourceNodeName ?? throw new global::System.ArgumentNullException(nameof(sourceNodeName));
            this.TargetNodeName = targetNodeName ?? throw new global::System.ArgumentNullException(nameof(targetNodeName));
            this.IsAnd = isAnd;
            this.Conditionals = conditionals ?? throw new global::System.ArgumentNullException(nameof(conditionals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Edge" /> class.
        /// </summary>
        public Edge()
        {
        }
    }
}