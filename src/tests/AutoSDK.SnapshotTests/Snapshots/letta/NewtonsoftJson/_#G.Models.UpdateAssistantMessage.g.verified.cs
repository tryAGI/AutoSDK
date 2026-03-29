//HintName: G.Models.UpdateAssistantMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssistantMessage
    {
        /// <summary>
        /// Default Value: assistant_message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The message content sent by the assistant (can be a string or an array of content parts)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaAssistantMessageContentUnion>, string> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssistantMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content sent by the assistant (can be a string or an array of content parts)
        /// </param>
        /// <param name="messageType">
        /// Default Value: assistant_message
        /// </param>
        public UpdateAssistantMessage(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.LettaAssistantMessageContentUnion>, string> content,
            string? messageType)
        {
            this.MessageType = messageType;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssistantMessage" /> class.
        /// </summary>
        public UpdateAssistantMessage()
        {
        }
    }
}