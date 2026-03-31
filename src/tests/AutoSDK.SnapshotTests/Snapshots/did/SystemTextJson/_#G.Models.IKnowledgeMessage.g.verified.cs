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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IKnowledgeMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IKnowledgeMessageRole Role { get; set; }

        /// <summary>
        /// Message for chat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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