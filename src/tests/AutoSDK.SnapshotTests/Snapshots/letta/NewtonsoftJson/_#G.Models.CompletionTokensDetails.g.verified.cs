//HintName: G.Models.CompletionTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of tokens used in a completion.
    /// </summary>
    public sealed partial class CompletionTokensDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accepted_prediction_tokens")]
        public int? AcceptedPredictionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rejected_prediction_tokens")]
        public int? RejectedPredictionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionTokensDetails" /> class.
        /// </summary>
        /// <param name="acceptedPredictionTokens"></param>
        /// <param name="audioTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="rejectedPredictionTokens"></param>
        public CompletionTokensDetails(
            int? acceptedPredictionTokens,
            int? audioTokens,
            int? reasoningTokens,
            int? rejectedPredictionTokens)
        {
            this.AcceptedPredictionTokens = acceptedPredictionTokens;
            this.AudioTokens = audioTokens;
            this.ReasoningTokens = reasoningTokens;
            this.RejectedPredictionTokens = rejectedPredictionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionTokensDetails" /> class.
        /// </summary>
        public CompletionTokensDetails()
        {
        }
    }
}