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
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNodeName { get; set; }

        /// <summary>
        /// The target node name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNodeName { get; set; }

        /// <summary>
        /// Whether multiple conditionals use AND logic (true) or OR logic (false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_and")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAnd { get; set; }

        /// <summary>
        /// At least one conditional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditionals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EdgeConditional> Conditionals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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