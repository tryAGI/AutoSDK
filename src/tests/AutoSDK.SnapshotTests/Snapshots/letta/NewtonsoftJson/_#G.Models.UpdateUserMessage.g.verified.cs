//HintName: G.Models.UpdateUserMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUserMessage
    {
        /// <summary>
        /// Default Value: user_message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The message content sent by the user (can be a string or an array of multi-modal content parts)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content sent by the user (can be a string or an array of multi-modal content parts)
        /// </param>
        /// <param name="messageType">
        /// Default Value: user_message
        /// </param>
        public UpdateUserMessage(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string> content,
            string? messageType)
        {
            this.MessageType = messageType;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserMessage" /> class.
        /// </summary>
        public UpdateUserMessage()
        {
        }
    }
}