//HintName: G.Models.EasyInputMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EasyInputMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EasyInputMessageTypeJsonConverter))]
        public global::G.EasyInputMessageType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EasyInputMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EasyInputMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EasyInputMessageContentJsonConverter))]
        public global::G.EasyInputMessageContent? Content { get; set; }

        /// <summary>
        /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EasyInputMessagePhaseJsonConverter))]
        public global::G.EasyInputMessagePhase? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EasyInputMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="phase">
        /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EasyInputMessage(
            global::G.EasyInputMessageRole role,
            global::G.EasyInputMessageType? type,
            global::G.EasyInputMessageContent? content,
            global::G.EasyInputMessagePhase? phase)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EasyInputMessage" /> class.
        /// </summary>
        public EasyInputMessage()
        {
        }
    }
}