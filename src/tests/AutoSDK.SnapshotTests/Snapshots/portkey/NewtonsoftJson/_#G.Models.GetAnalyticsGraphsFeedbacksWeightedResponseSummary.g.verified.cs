//HintName: G.Models.GetAnalyticsGraphsFeedbacksWeightedResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsFeedbacksWeightedResponseSummary
    {
        /// <summary>
        /// Average weighted feedback across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg", Required = global::Newtonsoft.Json.Required.Always)]
        public int Avg { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksWeightedResponseSummary" /> class.
        /// </summary>
        /// <param name="avg">
        /// Average weighted feedback across all data points
        /// </param>
        public GetAnalyticsGraphsFeedbacksWeightedResponseSummary(
            int avg)
        {
            this.Avg = avg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksWeightedResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsFeedbacksWeightedResponseSummary()
        {
        }
    }
}