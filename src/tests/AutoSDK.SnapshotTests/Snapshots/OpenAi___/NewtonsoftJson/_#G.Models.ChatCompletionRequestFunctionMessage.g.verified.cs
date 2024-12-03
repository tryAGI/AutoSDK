//HintName: G.Models.ChatCompletionRequestFunctionMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ChatCompletionRequestFunctionMessage
    {
        /// <summary>
        /// The role of the messages author, in this case `function`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatCompletionRequestFunctionMessageRole Role { get; set; }

        /// <summary>
        /// The contents of the function message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Content { get; set; } = default!;

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestFunctionMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the messages author, in this case `function`.
        /// </param>
        /// <param name="content">
        /// The contents of the function message.
        /// </param>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        public ChatCompletionRequestFunctionMessage(
            string? content,
            string name,
            global::G.ChatCompletionRequestFunctionMessageRole role)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestFunctionMessage" /> class.
        /// </summary>
        public ChatCompletionRequestFunctionMessage()
        {
        }
    }
}