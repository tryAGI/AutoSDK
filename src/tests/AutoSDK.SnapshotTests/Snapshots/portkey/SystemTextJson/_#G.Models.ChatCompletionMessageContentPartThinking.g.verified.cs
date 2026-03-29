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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter))]
        public global::G.ChatCompletionMessageContentPartThinkingType Type { get; set; }

        /// <summary>
        /// The thinking content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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