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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionChunkChoiceDelta Delta { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public double? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="finishReason"></param>
        /// <param name="index"></param>
        /// <param name="logprobs"></param>
        /// <param name="seed"></param>
        public ChatCompletionChunkChoice(
            global::G.ChatCompletionChunkChoiceDelta delta,
            global::G.FinishReason finishReason,
            int index,
            double? logprobs,
            int? seed)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        public ChatCompletionChunkChoice()
        {
        }
    }
}