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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Version ID this node belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_version_id")]
        public int? WorkflowVersionId { get; set; }

        /// <summary>
        /// Node name (unique within a version)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Type of node (e.g. PROMPT_TEMPLATE, CODE_EXECUTION, VARIABLE)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeType { get; set; } = default!;

        /// <summary>
        /// Whether this node is an output node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_output_node", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsOutputNode { get; set; } = default!;

        /// <summary>
        /// Full node configuration (structure depends on node_type)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration", Required = global::Newtonsoft.Json.Required.Always)]
        public object Configuration { get; set; } = default!;

        /// <summary>
        /// Names of nodes this node depends on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependencies", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Dependencies { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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