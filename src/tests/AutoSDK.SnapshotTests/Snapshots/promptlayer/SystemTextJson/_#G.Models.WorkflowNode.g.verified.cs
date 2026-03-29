//HintName: G.Models.WorkflowNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowNode
    {
        /// <summary>
        /// Unique name for the node within this workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of node. Common types include VARIABLE, CODE_EXECUTION, PROMPT_TEMPLATE, ENDPOINT, COMPARE, CONTAINS, LLM_ASSERTION, AI_DATA_EXTRACTION, CODING_AGENT. See Node &amp; Column Types documentation for the complete list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeType { get; set; }

        /// <summary>
        /// Node-specific configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// Names of nodes or input variables this node depends on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<string>? Dependencies { get; set; }

        /// <summary>
        /// Whether this node is an output node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_output_node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOutputNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowNode" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique name for the node within this workflow.
        /// </param>
        /// <param name="nodeType">
        /// The type of node. Common types include VARIABLE, CODE_EXECUTION, PROMPT_TEMPLATE, ENDPOINT, COMPARE, CONTAINS, LLM_ASSERTION, AI_DATA_EXTRACTION, CODING_AGENT. See Node &amp; Column Types documentation for the complete list.
        /// </param>
        /// <param name="configuration">
        /// Node-specific configuration.
        /// </param>
        /// <param name="isOutputNode">
        /// Whether this node is an output node.
        /// </param>
        /// <param name="dependencies">
        /// Names of nodes or input variables this node depends on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowNode(
            string name,
            string nodeType,
            object configuration,
            bool isOutputNode,
            global::System.Collections.Generic.IList<string>? dependencies)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeType = nodeType ?? throw new global::System.ArgumentNullException(nameof(nodeType));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Dependencies = dependencies;
            this.IsOutputNode = isOutputNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowNode" /> class.
        /// </summary>
        public WorkflowNode()
        {
        }
    }
}