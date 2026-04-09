//HintName: G.Models.PromptBlockDataChat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptBlockDataChat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptBlockDataChatTypeJsonConverter))]
        public global::G.PromptBlockDataChatType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageParam> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public string? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataChat" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="type"></param>
        /// <param name="tools"></param>
        public PromptBlockDataChat(
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageParam> messages,
            global::G.PromptBlockDataChatType type,
            string? tools)
        {
            this.Type = type;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataChat" /> class.
        /// </summary>
        public PromptBlockDataChat()
        {
        }
    }
}