//HintName: G.Models.Scorecard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Scorecard
    {
        /// <summary>
        /// This is the unique identifier for the scorecard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this scorecard belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the scorecard was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the scorecard was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="Scorecard" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the scorecard.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this scorecard belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the scorecard was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the scorecard was last updated.
        /// </param>
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
        public Scorecard(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::G.ScorecardMetric> metrics,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? assistantIds)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.Description = description;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.AssistantIds = assistantIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scorecard" /> class.
        /// </summary>
        public Scorecard()
        {
        }
    }
}