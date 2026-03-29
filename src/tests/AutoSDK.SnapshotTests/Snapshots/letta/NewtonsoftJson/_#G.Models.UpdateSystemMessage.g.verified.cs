//HintName: G.Models.UpdateSystemMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSystemMessage
    {
        /// <summary>
        /// Default Value: system_message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The message content sent by the system (can be a string or an array of multi-modal content parts)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content sent by the system (can be a string or an array of multi-modal content parts)
        /// </param>
        /// <param name="messageType">
        /// Default Value: system_message
        /// </param>
        public UpdateSystemMessage(
            string content,
            string? messageType)
        {
            this.MessageType = messageType;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSystemMessage" /> class.
        /// </summary>
        public UpdateSystemMessage()
        {
        }
    }
}