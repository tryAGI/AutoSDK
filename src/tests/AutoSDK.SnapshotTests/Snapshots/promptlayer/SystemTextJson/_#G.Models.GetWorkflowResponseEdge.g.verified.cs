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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the source node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNodeName { get; set; }

        /// <summary>
        /// Name of the target node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNodeName { get; set; }

        /// <summary>
        /// Whether all conditionals must be true (AND) or any (OR)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_and")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAnd { get; set; }

        /// <summary>
        /// Conditional rules for this edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditionals")]
        public global::System.Collections.Generic.IList<object>? Conditionals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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