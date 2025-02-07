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
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionChunkChoiceDelta Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FinishReason FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public double? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="finishReason"></param>
        /// <param name="index"></param>
        /// <param name="logprobs"></param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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