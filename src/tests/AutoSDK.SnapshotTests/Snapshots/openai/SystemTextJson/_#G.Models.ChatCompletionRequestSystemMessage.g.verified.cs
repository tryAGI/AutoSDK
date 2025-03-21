//HintName: G.Models.ChatCompletionRequestSystemMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Developer-provided instructions that the model should follow, regardless of<br/>
    /// messages sent by the user. With o1 models and newer, use `developer` messages<br/>
    /// for this purpose instead.
    /// </summary>
    public sealed partial class ChatCompletionRequestSystemMessage
    {
        /// <summary>
        /// The contents of the system message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestSystemMessageContentPart>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestSystemMessageContentPart>> Content { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The role of the messages author, in this case `system`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter))]
        public global::G.ChatCompletionRequestSystemMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the system message.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `system`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestSystemMessage(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestSystemMessageContentPart>> content,
            string? name,
            global::G.ChatCompletionRequestSystemMessageRole role)
        {
            this.Content = content;
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestSystemMessage" /> class.
        /// </summary>
        public ChatCompletionRequestSystemMessage()
        {
        }
    }
}