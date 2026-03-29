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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.AssistantMessage? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public global::G.Delta? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoice" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="message"></param>
        /// <param name="delta"></param>
        /// <param name="finishReason"></param>
        public ChatCompletionChoice(
            int? index,
            global::G.AssistantMessage? message,
            global::G.Delta? delta,
            string? finishReason)
        {
            this.Index = index;
            this.Message = message;
            this.Delta = delta;
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