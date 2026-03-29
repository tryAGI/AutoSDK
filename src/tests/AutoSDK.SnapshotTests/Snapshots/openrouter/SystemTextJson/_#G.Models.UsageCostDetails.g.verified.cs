//HintName: G.Models.UsageCostDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageCostDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_cost")]
        public double? UpstreamInferenceCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_input_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpstreamInferenceInputCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_output_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpstreamInferenceOutputCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCostDetails" /> class.
        /// </summary>
        /// <param name="upstreamInferenceInputCost"></param>
        /// <param name="upstreamInferenceOutputCost"></param>
        /// <param name="upstreamInferenceCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCostDetails(
            double upstreamInferenceInputCost,
            double upstreamInferenceOutputCost,
            double? upstreamInferenceCost)
        {
            this.UpstreamInferenceCost = upstreamInferenceCost;
            this.UpstreamInferenceInputCost = upstreamInferenceInputCost;
            this.UpstreamInferenceOutputCost = upstreamInferenceOutputCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCostDetails" /> class.
        /// </summary>
        public UsageCostDetails()
        {
        }
    }
}