//HintName: G.Models.CreateScorecardDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateScorecardDTO
    {
        /// <summary>
        /// This is the name of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the description of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// These are the metrics that will be used to evaluate the scorecard.<br/>
        /// Each metric will have a set of conditions and points that will be used to generate the score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ScorecardMetric> Metrics { get; set; }

        /// <summary>
        /// These are the assistant IDs that this scorecard is linked to.<br/>
        /// When linked to assistants, this scorecard will be available for evaluation during those assistants' calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantIds")]
        public global::System.Collections.Generic.IList<string>? AssistantIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScorecardDTO" /> class.
        /// </summary>
        /// <param name="metrics">
        /// These are the metrics that will be used to evaluate the scorecard.<br/>
        /// Each metric will have a set of conditions and points that will be used to generate the score.
        /// </param>
        /// <param name="name">
        /// This is the name of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </param>
        /// <param name="description">
        /// This is the description of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </param>
        /// <param name="assistantIds">
        /// These are the assistant IDs that this scorecard is linked to.<br/>
        /// When linked to assistants, this scorecard will be available for evaluation during those assistants' calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateScorecardDTO(
            global::System.Collections.Generic.IList<global::G.ScorecardMetric> metrics,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? assistantIds)
        {
            this.Name = name;
            this.Description = description;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.AssistantIds = assistantIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScorecardDTO" /> class.
        /// </summary>
        public CreateScorecardDTO()
        {
        }
    }
}