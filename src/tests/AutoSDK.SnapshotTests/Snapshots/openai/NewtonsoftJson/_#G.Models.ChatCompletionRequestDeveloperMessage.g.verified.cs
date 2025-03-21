//HintName: G.Models.ChatCompletionRequestDeveloperMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Developer-provided instructions that the model should follow, regardless of<br/>
    /// messages sent by the user. With o1 models and newer, `developer` messages<br/>
    /// replace the previous `system` messages.
    /// </summary>
    public sealed partial class ChatCompletionRequestDeveloperMessage
    {
        /// <summary>
        /// The contents of the developer message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessageContentPartText>> Content { get; set; } = default!;

        /// <summary>
        /// The role of the messages author, in this case `developer`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionRequestDeveloperMessageRole Role { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestDeveloperMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the developer message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `developer`.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
        public ChatCompletionRequestDeveloperMessage(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessageContentPartText>> content,
            global::G.ChatCompletionRequestDeveloperMessageRole role,
            string? name)
        {
            this.Content = content;
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