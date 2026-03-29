//HintName: G.Models.GetWorkflowResponseNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowResponseNode
    {
        /// <summary>
        /// UUID of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Version ID this node belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_id")]
        public int? WorkflowVersionId { get; set; }

        /// <summary>
        /// Node name (unique within a version)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of node (e.g. PROMPT_TEMPLATE, CODE_EXECUTION, VARIABLE)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeType { get; set; }

        /// <summary>
        /// Whether this node is an output node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_output_node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOutputNode { get; set; }

        /// <summary>
        /// Full node configuration (structure depends on node_type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// Names of nodes this node depends on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponseNode" /> class.
        /// </summary>
        /// <param name="id">
        /// UUID of the node
        /// </param>
        /// <param name="name">
        /// Node name (unique within a version)
        /// </param>
        /// <param name="nodeType">
        /// Type of node (e.g. PROMPT_TEMPLATE, CODE_EXECUTION, VARIABLE)
        /// </param>
        /// <param name="isOutputNode">
        /// Whether this node is an output node
        /// </param>
        /// <param name="configuration">
        /// Full node configuration (structure depends on node_type)
        /// </param>
        /// <param name="dependencies">
        /// Names of nodes this node depends on
        /// </param>
        /// <param name="workflowVersionId">
        /// Version ID this node belongs to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowResponseNode(
            string id,
            string name,
            string nodeType,
            bool isOutputNode,
            object configuration,
            global::System.Collections.Generic.IList<string> dependencies,
            int? workflowVersionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkflowVersionId = workflowVersionId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeType = nodeType ?? throw new global::System.ArgumentNullException(nameof(nodeType));
            this.IsOutputNode = isOutputNode;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Dependencies = dependencies ?? throw new global::System.ArgumentNullException(nameof(dependencies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponseNode" /> class.
        /// </summary>
        public GetWorkflowResponseNode()
        {
        }
    }
}