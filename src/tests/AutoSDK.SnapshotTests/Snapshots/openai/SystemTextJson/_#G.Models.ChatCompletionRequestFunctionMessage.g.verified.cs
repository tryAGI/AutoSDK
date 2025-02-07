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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatCompletionRequestFunctionMessageRole Role { get; set; }

        /// <summary>
        /// The contents of the function message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string? Content { get; set; }

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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