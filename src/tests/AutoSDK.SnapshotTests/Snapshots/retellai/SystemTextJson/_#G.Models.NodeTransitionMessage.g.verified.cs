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
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// This is a node transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NodeTransitionMessageRoleJsonConverter))]
        public global::G.NodeTransitionMessageRole Role { get; set; }

        /// <summary>
        /// Former node id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("former_node_id")]
        public string? FormerNodeId { get; set; }

        /// <summary>
        /// Former node name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("former_node_name")]
        public string? FormerNodeName { get; set; }

        /// <summary>
        /// New node id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_node_id")]
        public string? NewNodeId { get; set; }

        /// <summary>
        /// New node name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_node_name")]
        public string? NewNodeName { get; set; }

        /// <summary>
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreatedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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