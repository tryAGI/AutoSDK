//HintName: G.Models.NodeTransitionUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeTransitionUtterance
    {
        /// <summary>
        /// This is result of a node transition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NodeTransitionUtteranceRoleJsonConverter))]
        public global::G.NodeTransitionUtteranceRole Role { get; set; }

        /// <summary>
        /// Former node id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("former_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FormerNodeId { get; set; }

        /// <summary>
        /// Former node name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("former_node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FormerNodeName { get; set; }

        /// <summary>
        /// New node id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewNodeId { get; set; }

        /// <summary>
        /// New node name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewNodeName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionUtterance" /> class.
        /// </summary>
        /// <param name="formerNodeId">
        /// Former node id
        /// </param>
        /// <param name="formerNodeName">
        /// Former node name
        /// </param>
        /// <param name="newNodeId">
        /// New node id
        /// </param>
        /// <param name="newNodeName">
        /// New node name
        /// </param>
        /// <param name="role">
        /// This is result of a node transition
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeTransitionUtterance(
            string formerNodeId,
            string formerNodeName,
            string newNodeId,
            string newNodeName,
            global::G.NodeTransitionUtteranceRole role)
        {
            this.Role = role;
            this.FormerNodeId = formerNodeId ?? throw new global::System.ArgumentNullException(nameof(formerNodeId));
            this.FormerNodeName = formerNodeName ?? throw new global::System.ArgumentNullException(nameof(formerNodeName));
            this.NewNodeId = newNodeId ?? throw new global::System.ArgumentNullException(nameof(newNodeId));
            this.NewNodeName = newNodeName ?? throw new global::System.ArgumentNullException(nameof(newNodeName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionUtterance" /> class.
        /// </summary>
        public NodeTransitionUtterance()
        {
        }
    }
}