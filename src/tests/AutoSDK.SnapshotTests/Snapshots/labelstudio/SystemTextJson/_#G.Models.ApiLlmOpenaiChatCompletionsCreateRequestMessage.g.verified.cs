//HintName: G.Models.ApiLlmOpenaiChatCompletionsCreateRequestMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiLlmOpenaiChatCompletionsCreateRequestMessage
    {
        /// <summary>
        /// The content of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The role of the message author
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiLlmOpenaiChatCompletionsCreateRequestMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateRequestMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message
        /// </param>
        /// <param name="role">
        /// The role of the message author
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiLlmOpenaiChatCompletionsCreateRequestMessage(
            string content,
            global::G.ApiLlmOpenaiChatCompletionsCreateRequestMessageRole role)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateRequestMessage" /> class.
        /// </summary>
        public ApiLlmOpenaiChatCompletionsCreateRequestMessage()
        {
        }
    }
}