//HintName: G.Models.ChatChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chat completion choice
    /// </summary>
    public sealed partial class ChatChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatChoiceFinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatChoiceFinishReason FinishReason { get; set; }

        /// <summary>
        /// Choice index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Index { get; set; }

        /// <summary>
        /// Assistant message for requests and responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatAssistantMessage Message { get; set; }

        /// <summary>
        /// Log probabilities for the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::G.ChatTokenLogprobs? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChoice" /> class.
        /// </summary>
        /// <param name="finishReason"></param>
        /// <param name="index">
        /// Choice index
        /// </param>
        /// <param name="message">
        /// Assistant message for requests and responses
        /// </param>
        /// <param name="logprobs">
        /// Log probabilities for the completion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatChoice(
            global::G.ChatChoiceFinishReason finishReason,
            double index,
            global::G.ChatAssistantMessage message,
            global::G.ChatTokenLogprobs? logprobs)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChoice" /> class.
        /// </summary>
        public ChatChoice()
        {
        }
    }
}