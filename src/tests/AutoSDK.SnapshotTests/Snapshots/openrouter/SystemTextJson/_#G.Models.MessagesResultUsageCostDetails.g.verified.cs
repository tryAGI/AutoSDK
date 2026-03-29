//HintName: G.Models.MessagesResultUsageCostDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResultUsageCostDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_cost")]
        public double? UpstreamInferenceCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_prompt_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpstreamInferencePromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_completions_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpstreamInferenceCompletionsCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageCostDetails" /> class.
        /// </summary>
        /// <param name="upstreamInferencePromptCost"></param>
        /// <param name="upstreamInferenceCompletionsCost"></param>
        /// <param name="upstreamInferenceCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResultUsageCostDetails(
            double upstreamInferencePromptCost,
            double upstreamInferenceCompletionsCost,
            double? upstreamInferenceCost)
        {
            this.UpstreamInferenceCost = upstreamInferenceCost;
            this.UpstreamInferencePromptCost = upstreamInferencePromptCost;
            this.UpstreamInferenceCompletionsCost = upstreamInferenceCompletionsCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageCostDetails" /> class.
        /// </summary>
        public MessagesResultUsageCostDetails()
        {
        }
    }
}