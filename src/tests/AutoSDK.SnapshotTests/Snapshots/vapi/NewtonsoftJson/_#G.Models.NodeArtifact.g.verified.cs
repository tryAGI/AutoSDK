//HintName: G.Models.NodeArtifact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeArtifact
    {
        /// <summary>
        /// These are the messages that were spoken during the node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// This is the node name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodeName")]
        public string? NodeName { get; set; }

        /// <summary>
        /// These are the variable values that were extracted from the node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variableValues")]
        public object? VariableValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeArtifact" /> class.
        /// </summary>
        /// <param name="messages">
        /// These are the messages that were spoken during the node.
        /// </param>
        /// <param name="nodeName">
        /// This is the node name.
        /// </param>
        /// <param name="variableValues">
        /// These are the variable values that were extracted from the node.
        /// </param>
        public NodeArtifact(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? messages,
            string? nodeName,
            object? variableValues)
        {
            this.Messages = messages;
            this.NodeName = nodeName;
            this.VariableValues = variableValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeArtifact" /> class.
        /// </summary>
        public NodeArtifact()
        {
        }
    }
}