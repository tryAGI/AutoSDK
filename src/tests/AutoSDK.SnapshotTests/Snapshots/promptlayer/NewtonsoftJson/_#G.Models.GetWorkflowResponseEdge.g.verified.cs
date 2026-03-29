//HintName: G.Models.GetWorkflowResponseEdge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowResponseEdge
    {
        /// <summary>
        /// UUID of the edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the source node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_node_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceNodeName { get; set; } = default!;

        /// <summary>
        /// Name of the target node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_node_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetNodeName { get; set; } = default!;

        /// <summary>
        /// Whether all conditionals must be true (AND) or any (OR)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_and", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAnd { get; set; } = default!;

        /// <summary>
        /// Conditional rules for this edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditionals")]
        public global::System.Collections.Generic.IList<object>? Conditionals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponseEdge" /> class.
        /// </summary>
        /// <param name="id">
        /// UUID of the edge
        /// </param>
        /// <param name="sourceNodeName">
        /// Name of the source node
        /// </param>
        /// <param name="targetNodeName">
        /// Name of the target node
        /// </param>
        /// <param name="isAnd">
        /// Whether all conditionals must be true (AND) or any (OR)
        /// </param>
        /// <param name="conditionals">
        /// Conditional rules for this edge
        /// </param>
        public GetWorkflowResponseEdge(
            string id,
            string sourceNodeName,
            string targetNodeName,
            bool isAnd,
            global::System.Collections.Generic.IList<object>? conditionals)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SourceNodeName = sourceNodeName ?? throw new global::System.ArgumentNullException(nameof(sourceNodeName));
            this.TargetNodeName = targetNodeName ?? throw new global::System.ArgumentNullException(nameof(targetNodeName));
            this.IsAnd = isAnd;
            this.Conditionals = conditionals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponseEdge" /> class.
        /// </summary>
        public GetWorkflowResponseEdge()
        {
        }
    }
}