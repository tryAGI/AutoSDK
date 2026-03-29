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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter))]
        public global::G.ChatCompletionMessageContentPartRedactedThinkingType Type { get; set; }

        /// <summary>
        /// The redacted thinking content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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