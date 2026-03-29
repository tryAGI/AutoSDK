//HintName: G.Models.ChatCompletionMessageContentPartRedactedThinking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageContentPartRedactedThinking
    {
        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionMessageContentPartRedactedThinkingType Type { get; set; }

        /// <summary>
        /// The redacted thinking content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageContentPartRedactedThinking" /> class.
        /// </summary>
        /// <param name="data">
        /// The redacted thinking content.
        /// </param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
        public ChatCompletionMessageContentPartRedactedThinking(
            string data,
            global::G.ChatCompletionMessageContentPartRedactedThinkingType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageContentPartRedactedThinking" /> class.
        /// </summary>
        public ChatCompletionMessageContentPartRedactedThinking()
        {
        }
    }
}