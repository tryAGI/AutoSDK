//HintName: G.Models.InputMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is distinct from a ChatMessage because this schema is enforced by the AI Chat library used in the frontend
    /// </summary>
    public sealed partial class InputMessage
    {
        /// <summary>
        /// ID of the message, if any. a UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Message role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional data to be stored with the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// Message role.
        /// </param>
        /// <param name="content"></param>
        /// <param name="id">
        /// ID of the message, if any. a UUID.
        /// </param>
        /// <param name="data">
        /// Additional data to be stored with the message.
        /// </param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputMessage(
            global::G.MessageRole role,
            string content,
            global::System.Guid? id,
            object? data,
            string? className)
        {
            this.Id = id;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Data = data;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessage" /> class.
        /// </summary>
        public InputMessage()
        {
        }
    }
}