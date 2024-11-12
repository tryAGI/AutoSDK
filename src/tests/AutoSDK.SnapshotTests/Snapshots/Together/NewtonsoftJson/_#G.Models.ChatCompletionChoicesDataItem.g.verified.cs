//HintName: G.Models.ChatCompletionChoicesDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChoicesDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public global::G.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::G.LogprobsPart? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.ChatCompletionMessage? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoicesDataItem" /> class.
        /// </summary>
        /// <param name="finishReason"></param>
        /// <param name="index"></param>
        /// <param name="logprobs"></param>
        /// <param name="message"></param>
        /// <param name="seed"></param>
        /// <param name="text"></param>
        public ChatCompletionChoicesDataItem(
            global::G.FinishReason? finishReason,
            int? index,
            global::G.LogprobsPart? logprobs,
            global::G.ChatCompletionMessage? message,
            int? seed,
            string? text)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs;
            this.Message = message;
            this.Seed = seed;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoicesDataItem" /> class.
        /// </summary>
        public ChatCompletionChoicesDataItem()
        {
        }
    }
}