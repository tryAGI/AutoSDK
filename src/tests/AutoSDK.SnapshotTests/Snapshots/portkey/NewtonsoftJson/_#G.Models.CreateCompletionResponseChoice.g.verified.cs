//HintName: G.Models.CreateCompletionResponseChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCompletionResponseChoice
    {
        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// or `content_filter` if content was omitted due to a flag from our content filters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter))]
        public global::G.CreateCompletionResponseChoiceFinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::G.CreateCompletionResponseChoiceLogprobs? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionResponseChoice" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// or `content_filter` if content was omitted due to a flag from our content filters.
        /// </param>
        /// <param name="index"></param>
        /// <param name="text"></param>
        /// <param name="logprobs"></param>
        public CreateCompletionResponseChoice(
            global::G.CreateCompletionResponseChoiceFinishReason finishReason,
            int index,
            string text,
            global::G.CreateCompletionResponseChoiceLogprobs? logprobs)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionResponseChoice" /> class.
        /// </summary>
        public CreateCompletionResponseChoice()
        {
        }
    }
}