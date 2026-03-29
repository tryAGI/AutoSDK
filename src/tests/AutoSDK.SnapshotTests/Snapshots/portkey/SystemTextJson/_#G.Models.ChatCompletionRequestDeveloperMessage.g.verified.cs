//HintName: G.Models.ChatCompletionRequestDeveloperMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// New role by OpenAI for select models. Must be explicitly used for models that support it. When used with incompatible models or providers, Portkey automatically converts it to a system role.
    /// </summary>
    public sealed partial class ChatCompletionRequestDeveloperMessage
    {
        /// <summary>
        /// The contents of the Developer message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The role of the messages author, in this case `Developer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter))]
        public global::G.ChatCompletionRequestDeveloperMessageRole Role { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestDeveloperMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the Developer message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `Developer`.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestDeveloperMessage(
            string content,
            global::G.ChatCompletionRequestDeveloperMessageRole role,
            string? name)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestDeveloperMessage" /> class.
        /// </summary>
        public ChatCompletionRequestDeveloperMessage()
        {
        }
    }
}