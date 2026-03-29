//HintName: G.Models.NodeUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Partial update for a single node.
    /// </summary>
    public sealed partial class NodeUpdate
    {
        /// <summary>
        /// The node type (required for new nodes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_type")]
        public string? NodeType { get; set; }

        /// <summary>
        /// Node configuration to merge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public object? Configuration { get; set; }

        /// <summary>
        /// Dependencies to replace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<string>? Dependencies { get; set; }

        /// <summary>
        /// Whether this is an output node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_output_node")]
        public bool? IsOutputNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeUpdate" /> class.
        /// </summary>
        /// <param name="nodeType">
        /// The node type (required for new nodes).
        /// </param>
        /// <param name="configuration">
        /// Node configuration to merge.
        /// </param>
        /// <param name="dependencies">
        /// Dependencies to replace.
        /// </param>
        /// <param name="isOutputNode">
        /// Whether this is an output node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeUpdate(
            string? nodeType,
            object? configuration,
            global::System.Collections.Generic.IList<string>? dependencies,
            bool? isOutputNode)
        {
            this.NodeType = nodeType;
            this.Configuration = configuration;
            this.Dependencies = dependencies;
            this.IsOutputNode = isOutputNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeUpdate" /> class.
        /// </summary>
        public NodeUpdate()
        {
        }
    }
}