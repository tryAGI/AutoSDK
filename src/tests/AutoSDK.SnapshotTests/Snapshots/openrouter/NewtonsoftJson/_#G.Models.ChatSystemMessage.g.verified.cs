//HintName: G.Models.ChatSystemMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// System message for setting behavior
    /// </summary>
    public sealed partial class ChatSystemMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatSystemMessageRoleJsonConverter))]
        public global::G.ChatSystemMessageRole Role { get; set; }

        /// <summary>
        /// System message content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatSystemMessageContent Content { get; set; } = default!;

        /// <summary>
        /// Optional name for the system message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// System message content
        /// </param>
        /// <param name="role"></param>
        /// <param name="name">
        /// Optional name for the system message
        /// </param>
        public ChatSystemMessage(
            global::G.ChatSystemMessageContent content,
            global::G.ChatSystemMessageRole role,
            string? name)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSystemMessage" /> class.
        /// </summary>
        public ChatSystemMessage()
        {
        }
    }
}