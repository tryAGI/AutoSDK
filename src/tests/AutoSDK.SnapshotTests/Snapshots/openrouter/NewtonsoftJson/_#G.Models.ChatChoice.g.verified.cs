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
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatChoiceFinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// Choice index
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public double Index { get; set; } = default!;

        /// <summary>
        /// Assistant message for requests and responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatAssistantMessage Message { get; set; } = default!;

        /// <summary>
        /// Log probabilities for the completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::G.ChatTokenLogprobs? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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