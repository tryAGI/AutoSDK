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
        /// Example: stop
        /// </summary>
        /// <example>stop</example>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionChoiceFinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssistantMessage Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoice" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// Example: stop
        /// </param>
        /// <param name="index">
        /// Example: 0
        /// </param>
        /// <param name="message"></param>
        public ChatCompletionChoice(
            global::G.ChatCompletionChoiceFinishReason finishReason,
            int index,
            global::G.AssistantMessage message)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChoice" /> class.
        /// </summary>
        public ChatCompletionChoice()
        {
        }
    }
}