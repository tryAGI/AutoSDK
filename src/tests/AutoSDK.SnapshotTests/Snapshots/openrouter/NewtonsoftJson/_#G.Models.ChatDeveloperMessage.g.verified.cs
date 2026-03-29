//HintName: G.Models.ChatDeveloperMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Developer message
    /// </summary>
    public sealed partial class ChatDeveloperMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatDeveloperMessageRole Role { get; set; }

        /// <summary>
        /// Developer message content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatDeveloperMessageContent Content { get; set; } = default!;

        /// <summary>
        /// Optional name for the developer message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDeveloperMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Developer message content
        /// </param>
        /// <param name="role"></param>
        /// <param name="name">
        /// Optional name for the developer message
        /// </param>
        public ChatDeveloperMessage(
            global::G.ChatDeveloperMessageContent content,
            global::G.ChatDeveloperMessageRole role,
            string? name)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDeveloperMessage" /> class.
        /// </summary>
        public ChatDeveloperMessage()
        {
        }
    }
}