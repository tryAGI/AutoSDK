//HintName: G.Models.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Further information about the amount of tokens in the request completion.
    /// </summary>
    public sealed partial class ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails
    {
        /// <summary>
        /// The amount of reasoning tokens used by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// The amount of tokens accepted during the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_prediction_tokens")]
        public int? AcceptedPredictionTokens { get; set; }

        /// <summary>
        /// The amount of tokens rejected during the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected_prediction_tokens")]
        public int? RejectedPredictionTokens { get; set; }

        /// <summary>
        /// The amount of tokens used from output audio files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails" /> class.
        /// </summary>
        /// <param name="reasoningTokens">
        /// The amount of reasoning tokens used by the model.
        /// </param>
        /// <param name="acceptedPredictionTokens">
        /// The amount of tokens accepted during the request.
        /// </param>
        /// <param name="rejectedPredictionTokens">
        /// The amount of tokens rejected during the request.
        /// </param>
        /// <param name="audioTokens">
        /// The amount of tokens used from output audio files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails(
            int? reasoningTokens,
            int? acceptedPredictionTokens,
            int? rejectedPredictionTokens,
            int? audioTokens)
        {
            this.ReasoningTokens = reasoningTokens;
            this.AcceptedPredictionTokens = acceptedPredictionTokens;
            this.RejectedPredictionTokens = rejectedPredictionTokens;
            this.AudioTokens = audioTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails" /> class.
        /// </summary>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails()
        {
        }
    }
}