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
        [global::Newtonsoft.Json.JsonProperty("upstream_inference_cost")]
        public double? UpstreamInferenceCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstream_inference_prompt_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double UpstreamInferencePromptCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstream_inference_completions_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double UpstreamInferenceCompletionsCost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageCostDetails" /> class.
        /// </summary>
        /// <param name="upstreamInferencePromptCost"></param>
        /// <param name="upstreamInferenceCompletionsCost"></param>
        /// <param name="upstreamInferenceCost"></param>
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