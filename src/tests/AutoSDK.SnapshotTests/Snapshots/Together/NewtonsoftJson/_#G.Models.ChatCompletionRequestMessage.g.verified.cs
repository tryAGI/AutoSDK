//HintName: G.Models.ChatCompletionRequestMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessage
    {
        /// <summary>
        /// The contents of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The role of the messages author. Choice between: system, user, or assistant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionRequestMessageRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author. Choice between: system, user, or assistant.
        /// </param>
        public ChatCompletionRequestMessage(
            string content,
            global::G.ChatCompletionRequestMessageRole role)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessage" /> class.
        /// </summary>
        public ChatCompletionRequestMessage()
        {
        }
    }
}