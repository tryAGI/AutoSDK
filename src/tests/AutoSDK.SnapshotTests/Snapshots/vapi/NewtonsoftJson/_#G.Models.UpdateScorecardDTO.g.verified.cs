//HintName: G.Models.UpdateScorecardDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateScorecardDTO
    {
        /// <summary>
        /// This is the name of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the description of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// These are the metrics that will be used to evaluate the scorecard.<br/>
        /// Each metric will have a set of conditions and points that will be used to generate the score.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics")]
        public global::System.Collections.Generic.IList<global::G.ScorecardMetric>? Metrics { get; set; }

        /// <summary>
        /// These are the assistant IDs that this scorecard is linked to.<br/>
        /// When linked to assistants, this scorecard will be available for evaluation during those assistants' calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantIds")]
        public global::System.Collections.Generic.IList<string>? AssistantIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScorecardDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </param>
        /// <param name="description">
        /// This is the description of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </param>
        /// <param name="metrics">
        /// These are the metrics that will be used to evaluate the scorecard.<br/>
        /// Each metric will have a set of conditions and points that will be used to generate the score.
        /// </param>
        /// <param name="assistantIds">
        /// These are the assistant IDs that this scorecard is linked to.<br/>
        /// When linked to assistants, this scorecard will be available for evaluation during those assistants' calls.
        /// </param>
        public UpdateScorecardDTO(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::G.ScorecardMetric>? metrics,
            global::System.Collections.Generic.IList<string>? assistantIds)
        {
            this.Name = name;
            this.Description = description;
            this.Metrics = metrics;
            this.AssistantIds = assistantIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScorecardDTO" /> class.
        /// </summary>
        public UpdateScorecardDTO()
        {
        }
    }
}