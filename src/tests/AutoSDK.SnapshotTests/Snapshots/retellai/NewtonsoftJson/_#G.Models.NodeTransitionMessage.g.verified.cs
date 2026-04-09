//HintName: G.Models.NodeTransitionMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeTransitionMessage
    {
        /// <summary>
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::Newtonsoft.Json.JsonProperty("message_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// This is a node transition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NodeTransitionMessageRoleJsonConverter))]
        public global::G.NodeTransitionMessageRole Role { get; set; }

        /// <summary>
        /// Former node id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("former_node_id")]
        public string? FormerNodeId { get; set; }

        /// <summary>
        /// Former node name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("former_node_name")]
        public string? FormerNodeName { get; set; }

        /// <summary>
        /// New node id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_node_id")]
        public string? NewNodeId { get; set; }

        /// <summary>
        /// New node name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_node_name")]
        public string? NewNodeName { get; set; }

        /// <summary>
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::Newtonsoft.Json.JsonProperty("created_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long CreatedTimestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionMessage" /> class.
        /// </summary>
        /// <param name="messageId">
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="createdTimestamp">
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </param>
        /// <param name="role">
        /// This is a node transition.
        /// </param>
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
        public NodeTransitionMessage(
            string messageId,
            long createdTimestamp,
            global::G.NodeTransitionMessageRole role,
            string? formerNodeId,
            string? formerNodeName,
            string? newNodeId,
            string? newNodeName)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Role = role;
            this.FormerNodeId = formerNodeId;
            this.FormerNodeName = formerNodeName;
            this.NewNodeId = newNodeId;
            this.NewNodeName = newNodeName;
            this.CreatedTimestamp = createdTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeTransitionMessage" /> class.
        /// </summary>
        public NodeTransitionMessage()
        {
        }
    }
}