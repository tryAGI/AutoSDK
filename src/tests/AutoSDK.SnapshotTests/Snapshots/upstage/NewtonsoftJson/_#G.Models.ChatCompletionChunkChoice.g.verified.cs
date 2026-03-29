//HintName: G.Models.ChatCompletionChunkChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunkChoice
    {
        /// <summary>
        /// The index of the choice in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public global::G.ChatCompletionDelta? Delta { get; set; }

        /// <summary>
        /// The reason the model stopped generating tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public global::G.ChatCompletionChunkChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the choice in the list.
        /// </param>
        /// <param name="delta"></param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens.
        /// </param>
        public ChatCompletionChunkChoice(
            int? index,
            global::G.ChatCompletionDelta? delta,
            global::G.ChatCompletionChunkChoiceFinishReason? finishReason)
        {
            this.Index = index;
            this.Delta = delta;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        public ChatCompletionChunkChoice()
        {
        }
    }
}