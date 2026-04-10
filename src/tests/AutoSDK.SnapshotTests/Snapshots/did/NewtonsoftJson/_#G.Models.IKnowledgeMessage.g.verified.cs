//HintName: G.Models.IKnowledgeMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IKnowledgeMessage
    {
        /// <summary>
        /// Role is used to mark from whom is the message<br/>
        /// assistant mean from agent<br/>
        /// user means from user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.IKnowledgeMessageRoleJsonConverter))]
        public global::G.IKnowledgeMessageRole Role { get; set; } = default!;

        /// <summary>
        /// Message for chat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="IKnowledgeMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// Role is used to mark from whom is the message<br/>
        /// assistant mean from agent<br/>
        /// user means from user
        /// </param>
        /// <param name="content">
        /// Message for chat
        /// </param>
        /// <param name="name"></param>
        public IKnowledgeMessage(
            global::G.IKnowledgeMessageRole role,
            string content,
            string? name)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IKnowledgeMessage" /> class.
        /// </summary>
        public IKnowledgeMessage()
        {
        }
    }
}