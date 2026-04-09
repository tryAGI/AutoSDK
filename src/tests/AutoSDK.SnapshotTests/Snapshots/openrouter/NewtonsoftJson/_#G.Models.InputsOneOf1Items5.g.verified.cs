//HintName: G.Models.InputsOneOf1Items5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An output message item
    /// </summary>
    public sealed partial class InputsOneOf1Items5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OutputMessageRoleJsonConverter))]
        public global::G.OutputMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OutputMessageTypeJsonConverter))]
        public global::G.OutputMessageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.OutputMessageStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputsOneOf1ItemsOneOf5Content Content { get; set; } = default!;

        /// <summary>
        /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phase")]
        public global::G.OutputMessagePhase? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsOneOf1Items5" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="phase">
        /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
        /// </param>
        public InputsOneOf1Items5(
            string id,
            global::G.InputsOneOf1ItemsOneOf5Content content,
            global::G.OutputMessageRole role,
            global::G.OutputMessageType type,
            global::G.OutputMessageStatus? status,
            global::G.OutputMessagePhase? phase)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
            this.Type = type;
            this.Status = status;
            this.Content = content;
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsOneOf1Items5" /> class.
        /// </summary>
        public InputsOneOf1Items5()
        {
        }
    }
}