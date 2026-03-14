//HintName: G.Models.ChatCompletionRequestMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A message in the chat completion request, representing part of the conversation.
    /// </summary>
    public sealed partial class ChatCompletionRequestMessage
    {
        /// <summary>
        /// The role of the author of this message. Common values include 'system', 'user', 'assistant', 'function', and 'tool'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The contents of the message. Follows the exact format of the content field in the OpenAI Chat Completions API (https://platform.openai.com/docs/api-reference/chat/create). Can be a string for text-only messages, or an array of content parts for multimodal messages with text and images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// The name of the author of this message, used to connect messages in a conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the author of this message. Common values include 'system', 'user', 'assistant', 'function', and 'tool'.
        /// </param>
        /// <param name="content">
        /// The contents of the message. Follows the exact format of the content field in the OpenAI Chat Completions API (https://platform.openai.com/docs/api-reference/chat/create). Can be a string for text-only messages, or an array of content parts for multimodal messages with text and images.
        /// </param>
        /// <param name="name">
        /// The name of the author of this message, used to connect messages in a conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessage(
            string role,
            object content,
            string? name)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessage" /> class.
        /// </summary>
        public ChatCompletionRequestMessage()
        {
        }
    }
}