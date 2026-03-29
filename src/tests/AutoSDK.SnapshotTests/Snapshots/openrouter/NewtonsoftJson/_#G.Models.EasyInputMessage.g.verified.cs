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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EasyInputMessageType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EasyInputMessageRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.EasyInputMessageContent? Content { get; set; }

        /// <summary>
        /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phase")]
        public global::G.EasyInputMessagePhase? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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