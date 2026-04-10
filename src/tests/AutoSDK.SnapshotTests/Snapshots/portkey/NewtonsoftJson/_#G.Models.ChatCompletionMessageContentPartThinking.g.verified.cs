//HintName: G.Models.ChatCompletionMessageContentPartThinking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageContentPartThinking
    {
        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter))]
        public global::G.ChatCompletionMessageContentPartThinkingType Type { get; set; }

        /// <summary>
        /// The thinking content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinking", Required = global::Newtonsoft.Json.Required.Always)]
        public string Thinking { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageContentPartThinking" /> class.
        /// </summary>
        /// <param name="thinking">
        /// The thinking content.
        /// </param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
        public ChatCompletionMessageContentPartThinking(
            string thinking,
            global::G.ChatCompletionMessageContentPartThinkingType type)
        {
            this.Type = type;
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageContentPartThinking" /> class.
        /// </summary>
        public ChatCompletionMessageContentPartThinking()
        {
        }
    }
}