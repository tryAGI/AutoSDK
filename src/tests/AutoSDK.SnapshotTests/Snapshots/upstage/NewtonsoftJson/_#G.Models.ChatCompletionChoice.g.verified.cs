//HintName: G.Models.ChatCompletionChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChoice
    {
        /// <summary>
        /// The index of the choice in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.ChatCompletionMessage? Message { get; set; }

        /// <summary>
        /// The reason the model stopped generating tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter))]
        public global::G.ChatCompletionChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the choice in the list.
        /// </param>
        /// <param name="message"></param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens.
        /// </param>
        public ChatCompletionChoice(
            int? index,
            global::G.ChatCompletionMessage? message,
            global::G.ChatCompletionChoiceFinishReason? finishReason)
        {
            this.Index = index;
            this.Message = message;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoice" /> class.
        /// </summary>
        public ChatCompletionChoice()
        {
        }
    }
}