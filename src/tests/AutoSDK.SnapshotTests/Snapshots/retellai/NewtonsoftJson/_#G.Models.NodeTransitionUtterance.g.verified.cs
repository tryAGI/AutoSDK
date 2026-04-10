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
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NodeTransitionUtteranceRoleJsonConverter))]
        public global::G.NodeTransitionUtteranceRole Role { get; set; }

        /// <summary>
        /// Former node id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("former_node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FormerNodeId { get; set; } = default!;

        /// <summary>
        /// Former node name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("former_node_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FormerNodeName { get; set; } = default!;

        /// <summary>
        /// New node id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewNodeId { get; set; } = default!;

        /// <summary>
        /// New node name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_node_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewNodeName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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