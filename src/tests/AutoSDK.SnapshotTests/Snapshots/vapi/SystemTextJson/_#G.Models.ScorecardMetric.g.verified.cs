//HintName: G.Models.ScorecardMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScorecardMetric
    {
        /// <summary>
        /// This is the unique identifier for the structured output that will be used to evaluate the scorecard.<br/>
        /// The structured output must be of type number or boolean only for now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StructuredOutputId { get; set; }

        /// <summary>
        /// These are the conditions that will be used to evaluate the scorecard.<br/>
        /// Each condition will have a comparator, value, and points that will be used to calculate the final score.<br/>
        /// The points will be added to the overall score if the condition is met.<br/>
        /// The overall score will be normalized to a 100 point scale to ensure uniformity across different scorecards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScorecardMetric" /> class.
        /// </summary>
        /// <param name="structuredOutputId">
        /// This is the unique identifier for the structured output that will be used to evaluate the scorecard.<br/>
        /// The structured output must be of type number or boolean only for now.
        /// </param>
        /// <param name="conditions">
        /// These are the conditions that will be used to evaluate the scorecard.<br/>
        /// Each condition will have a comparator, value, and points that will be used to calculate the final score.<br/>
        /// The points will be added to the overall score if the condition is met.<br/>
        /// The overall score will be normalized to a 100 point scale to ensure uniformity across different scorecards.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScorecardMetric(
            string structuredOutputId,
            global::System.Collections.Generic.IList<object> conditions)
        {
            this.StructuredOutputId = structuredOutputId ?? throw new global::System.ArgumentNullException(nameof(structuredOutputId));
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScorecardMetric" /> class.
        /// </summary>
        public ScorecardMetric()
        {
        }
    }
}