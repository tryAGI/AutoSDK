//HintName: G.Models.ChatUsageCompletionTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed completion token usage
    /// </summary>
    public sealed partial class ChatUsageCompletionTokensDetails
    {
        /// <summary>
        /// Tokens used for reasoning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// Tokens used for audio output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public double? AudioTokens { get; set; }

        /// <summary>
        /// Accepted prediction tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_prediction_tokens")]
        public double? AcceptedPredictionTokens { get; set; }

        /// <summary>
        /// Rejected prediction tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected_prediction_tokens")]
        public double? RejectedPredictionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsageCompletionTokensDetails" /> class.
        /// </summary>
        /// <param name="reasoningTokens">
        /// Tokens used for reasoning
        /// </param>
        /// <param name="audioTokens">
        /// Tokens used for audio output
        /// </param>
        /// <param name="acceptedPredictionTokens">
        /// Accepted prediction tokens
        /// </param>
        /// <param name="rejectedPredictionTokens">
        /// Rejected prediction tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatUsageCompletionTokensDetails(
            double? reasoningTokens,
            double? audioTokens,
            double? acceptedPredictionTokens,
            double? rejectedPredictionTokens)
        {
            this.ReasoningTokens = reasoningTokens;
            this.AudioTokens = audioTokens;
            this.AcceptedPredictionTokens = acceptedPredictionTokens;
            this.RejectedPredictionTokens = rejectedPredictionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsageCompletionTokensDetails" /> class.
        /// </summary>
        public ChatUsageCompletionTokensDetails()
        {
        }
    }
}