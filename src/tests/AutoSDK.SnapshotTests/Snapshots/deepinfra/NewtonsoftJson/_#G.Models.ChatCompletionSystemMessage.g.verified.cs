//HintName: G.Models.ChatCompletionSystemMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionSystemMessage
    {
        /// <summary>
        /// the role of the author of this message<br/>
        /// Default Value: system
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// the message content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// the message content
        /// </param>
        /// <param name="role">
        /// the role of the author of this message<br/>
        /// Default Value: system
        /// </param>
        /// <param name="name"></param>
        public ChatCompletionSystemMessage(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>> content,
            string? role,
            string? name)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessage" /> class.
        /// </summary>
        public ChatCompletionSystemMessage()
        {
        }
    }
}